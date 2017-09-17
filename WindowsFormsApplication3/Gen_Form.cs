using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Подключаем библиотеки

using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;
using System.Drawing.Imaging;


namespace WindowsFormsApplication3
{
    public partial class Gen_Form : Form
    {
        public Gen_Form()
        {
            InitializeComponent();
        }
        VebCamDriver vebcamdriver = new VebCamDriver();
        //private Capture myCapture = new Capture();
        private Bitmap mainImage;
       // private Image<Bgr, byte> imgNow;
        Bitmap grayImage;
        private List<List<System.Drawing.Point>> convexHull = new List<List<System.Drawing.Point>>();
        private List<List<System.Drawing.Point>> edgePoint = new List<List<System.Drawing.Point>>();

        List<double[]> ContourEtalCentr = new List<double[]>();
        List<double[]> HullEtalCentr = new List<double[]>();

        List<double[]> ContourEtalMedoid = new List<double[]>();
        List<double[]> HullEtalMedoid = new List<double[]>();

        double[] Contourvec = new double[18];
        double[] Hullvec = new double[28];

        List<Bitmap> etalonimages = new List<Bitmap>();
        int num_images = 0;
        private void Teach_Click(object sender, EventArgs e)
        {
            foreach (PictureBox pb in etalonpanel.Controls.OfType<PictureBox>())
            {
                if (pb.Image != null)
                {
                    etalonimages.Add((Bitmap)pb.Image);
                }
                else break;
            }

            ContourEtalCentr = ReadFromFile("ContourCentr.txt", 18);
            HullEtalCentr = ReadFromFile("HullCentr.txt", 28);

            ContourEtalMedoid = ReadFromFile("ContourMed.txt", 18);
            HullEtalMedoid = ReadFromFile("HullCentrMed.txt", 28);

            foreach (Bitmap img in etalonimages)
            {
                if (etalonimages.Count > ContourEtalCentr.Count)
                {
                    if (num_images >= ContourEtalCentr.Count)
                        addetalons(img);
                    else
                        num_images++;
                }
            }

            WriteToFileBegin(ContourEtalCentr, "ContourCentr.txt");
            WriteToFileBegin(HullEtalCentr, "HullCentr.txt");

            WriteToFileBegin(ContourEtalMedoid, "ContourMed.txt");
            WriteToFileBegin(HullEtalMedoid, "HullCentrMed.txt");
        }

        public void addetalons(Bitmap etalon)
        {
            ProcessingImage pi = new ProcessingImage();
            List<double[]> vector360Contur = new List<double[]>();
            List<double[]> vector360Hull = new List<double[]>();
            List<double[]> vector180360Contur = new List<double[]>();
            List<double[]> vector180360Hull = new List<double[]>();

            Bitmap ImageForThread1 = etalon.Clone(
                           new Rectangle(0, 0, etalon.Width, etalon.Height),
                           System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            Bitmap Image24 = etalon.Clone(
                           new Rectangle(0, 0, etalon.Width, etalon.Height),
                           System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            List<Point> localPt = new List<System.Drawing.Point>();
            Thread t1 = new Thread(() => VectorsRotate120(ImageForThread1, vector180360Contur, vector180360Hull));
            t1.Start();
            //рассчет вектора признаков для каждого поворота
            for (int i = 0; i < 180; i++)
            {
                QuickHull qh = new QuickHull();
                Contur cont1 = new Contur();

                //медианный фильтр для шумов границ размытых объектов
                Median filter = new Median();
                filter.ApplyInPlace(Image24);


                //поворот на 1 градус
                Bitmap image1 = pi.RotateImg(Image24, i);
                image1 = pi.ProcImg(image1);
                localPt = pi.GetPoints(image1);
                //выделение выпуклой оболочки
                List<System.Drawing.Point> ConvexHullLocal = qh.quickHull(localPt);
                ConvexHullLocal = qh.DeleteAnglePoints(ConvexHullLocal);
                //и контура
                List<System.Drawing.Point> ConturLocal = cont1.kontur(image1);
                ConturLocal = cont1.DeleteAnglePoints(ConturLocal);
                Primary marks = new Primary(image1, ConturLocal, ConvexHullLocal);
                vector360Contur.Add(marks.Contour());
                vector360Hull.Add(marks.Convex());
                progressBar1.Value = i + 1;
                cont1 = null;
            }
            progressBar1.Value = 0;

            for (int i = 0; i < vector180360Contur.Count; i++)
            {
                vector360Contur.Add(vector180360Contur[i]);
                vector360Hull.Add(vector180360Hull[i]);
            }

            //запись в файл по 1 объекту
            //WriteToFileBegin(vector360Contur, "Contours.txt");
            //WriteToFileBegin(vector360Hull, "Hulls.txt");


            //vector360Contur = ReadFromFile("Contours.txt", 18);
            //vector360Hull = ReadFromFile("Hulls.txt", 28);


            GetConturHullCentroid(vector360Contur, vector360Hull);
            GetConturHullMedoid(vector360Contur, vector360Hull, Contourvec, Hullvec);

        }

        private void GetConturHullMedoid(List<double[]> vector360Contur, List<double[]> vector360Hull, double[] ContourEtalCentr, double[] HullEtalCentr)
        {
            ContourEtalMedoid.Add(GetMedoid(vector360Contur, ContourEtalCentr));
            HullEtalMedoid.Add(GetMedoid(vector360Hull, HullEtalCentr));
        }

        private double[] GetMedoid(List<double[]> vector360, double[] Vec)
        {
            double a, b, c, d;
            double[] k = new double[vector360.Count];
            a = k.Length;
            for (int i = 0; i < vector360.Count; i++)
            {
                for (int j = 0; j < vector360[i].Length; j++)
                {
                    b = Vec[j];
                    c = vector360[i][j];
                    d = 1 / a;
                    k[i] += d * ((b - c) * (b - c));
                }
                d = 1 / a;
                k[i] = d * k[i];
            }
            double min = k[0];
            int ind = 0;
            for (int i = 0; i < k.Length; i++)
                if (k[i] < min)
                {
                    min = k[i];
                    ind = i;
                }
            Vec = vector360[ind];

            return Vec;
        }

        private void GetConturHullCentroid(List<double[]> vector360Contur, List<double[]> vector360Hull)
        {
            Hullvec = GetCentroid(vector360Hull);
            Contourvec = GetCentroid(vector360Contur);
            ContourEtalCentr.Add(Contourvec);
            HullEtalCentr.Add(Hullvec);
        }

        private double[] GetCentroid(List<double[]> vector360)
        {
            double[] Vec = new double[vector360[0].Length];
            foreach (double[] vector in vector360)
            {
                for (int j = 0; j < vector.Length; j++)
                    Vec[j] += vector[j];
            }
            for (int j = 0; j < Vec.Length; j++)
                Vec[j] /= 360;
            return Vec;
        }

        public void VectorsRotate120(Bitmap image, List<double[]> vector360Contur, List<double[]> vector360Hull)
        {
            int i;

            ProcessingImage pi = new ProcessingImage();
            List<System.Drawing.Point> localPt;
            for (i = 180; i < 360; i++)
            {
                QuickHull qh = new QuickHull();
                Contur cont1 = new Contur();


                //медианный фильтр для шумов границ размытых объектов
                Median filter = new Median();
                filter.ApplyInPlace(image);


                //поворот на 1 градус
                Bitmap image1 = pi.RotateImg(image, i);
                image1 = pi.ProcImg(image1);
                localPt = pi.GetPoints(image1);
                //выделение выпуклой оболочки
                List<System.Drawing.Point> ConvexHullLocal = qh.quickHull(localPt);
                ConvexHullLocal = qh.DeleteAnglePoints(ConvexHullLocal);
                //и контура
                List<System.Drawing.Point> ConturLocal = cont1.kontur(image1);
                ConturLocal = cont1.DeleteAnglePoints(ConturLocal);
                Primary marks = new Primary(image1, ConturLocal, ConvexHullLocal);
                vector360Contur.Add(marks.Contour());
                vector360Hull.Add(marks.Convex());
            }
        }

        public void WriteToFileBegin(List<double[]> standards, string str)
        {

            File.Delete(str);
            string strForHull = "";
            for (int i = 0; i < standards.Count; i++)
            {
                double[] localHull = standards[i];
                for (int j = 0; j < standards[i].Length; j++)
                {
                    if (j == standards[i].Length-1)
                        strForHull += Convert.ToString(localHull[j]) + ";";
                    else
                        strForHull += Convert.ToString(localHull[j]) + ":";
                }
                strForHull += Environment.NewLine;
                File.AppendAllText(str, strForHull, Encoding.UTF8);
                strForHull = "";
            }
        }

        public List<double[]> ReadFromFile(string str, int numrows)
        {
            List<double[]> Vectors = new List<double[]>();

            string oper = "";
            int j = 0;
            using (StreamReader fs = new StreamReader(str))
            {
                while (true)
                {
                    double[] local = new double[numrows];
                    // Читаем строку из файла во временную переменную.
                    string temp = fs.ReadLine();
                    // Если достигнут конец файла, прерываем считывание.
                    if (temp == null) break;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (temp[i] == ';')
                        {
                            local[j] = Convert.ToDouble(oper);
                            j = 0;
                            oper = "";
                            Vectors.Add(local);
                            continue;
                        }
                        if (temp[i] == ':')
                        {
                            local[j] = Convert.ToDouble(oper);
                            j++;
                            oper = "";
                        }
                        if (temp[i] != ':')
                        {
                            oper += temp[i];
                        }
                    }
                }
                return Vectors;
            }

        }


        private void recognize_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            if (etalonimages.Count == 0)
            {
                foreach (PictureBox pb in etalonpanel.Controls.OfType<PictureBox>())
                {
                    if (pb.Image != null)
                        etalonimages.Add((Bitmap)pb.Image);
                }

                //чтение из файлов параметров

                ContourEtalCentr = ReadFromFile("ContourCentr.txt", 18);
                HullEtalCentr = ReadFromFile("HullCentr.txt", 28);

                ContourEtalMedoid = ReadFromFile("ContourMed.txt", 18);
                HullEtalMedoid = ReadFromFile("HullCentrMed.txt", 28);

            }
            Grayscale grayfilter = new Grayscale(0.2125, 0.7154, 0.0721);
            // применяем фильтр
            grayImage = grayfilter.Apply((Bitmap)vebpb.Image);
            //выводим на пичербокс
            //pictureBox1.Image = grayImage;

            //Application.Idle -= GetVideo;
            mainImage = grayImage.Clone(
                    new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                    System.Drawing.Imaging.PixelFormat.Format8bppIndexed);


            //медианный фильтр для шумов границ размытых объектов
            Median filter1 = new Median();
            filter1.ApplyInPlace(mainImage);


            OtsuThreshold filter = new OtsuThreshold();
            // apply the filter

            filter.ApplyInPlace(mainImage);
            // check threshold value           
            Invert filter2 = new Invert();
            // apply the filter
            filter2.ApplyInPlace(mainImage);


            // исправили потомучто надо
            //RecursiveBlobCounter bc = new RecursiveBlobCounter();
            BlobCounter bc = new BlobCounter();
            // process binary image
            bc.ProcessImage(mainImage);

            Rectangle[] rects = bc.GetObjectsRectangles();

            List<Bitmap> images = new List<Bitmap>();
            List<Bitmap> imagesWithEdge = new List<Bitmap>();
            Bitmap bp;
            int i = 0;
            foreach (Rectangle rect in rects)
            {
                images.Add(new Bitmap(mainImage.Width, mainImage.Height));
                Graphics g = Graphics.FromImage(images[i]);   //получаю объект графики из битмап
                SolidBrush b = new SolidBrush(Color.Black);  //кисть для заливки
                g.FillRectangle(b, new Rectangle(0, 0, images[i].Width, images[i].Height)); //заполняю
                bp = mainImage.Clone(rects[i], System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
                g.DrawImage(bp, rects[i].X, rects[i].Y, rects[i].Width, rects[i].Height);
                i++;
            }

            //List <List<System.Drawing.Point>> convexHull = new List<List<System.Drawing.Point>>();
            ProcessingImage pi = new ProcessingImage();
            QuickHull qh = new QuickHull();
            Contur cont = new Contur();
            List<System.Drawing.Point> localPt = new List<System.Drawing.Point>();
            foreach (Bitmap img in images)
            {
                //формирование выпуклой оболочки
                localPt = pi.GetPoints(img);
                List<System.Drawing.Point> ConvexHullLocal = qh.quickHull(localPt);
                ConvexHullLocal = qh.DeleteAnglePoints(ConvexHullLocal);
                convexHull.Add(ConvexHullLocal);
                //и контура
                List<System.Drawing.Point> ConturLocal = cont.kontur(img);
                ConturLocal = cont.DeleteAnglePoints(ConturLocal);
                edgePoint.Add(ConturLocal);
                imagesWithEdge.Add(img.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format32bppRgb));
            }

            int hullimagenum = 0;
            foreach (PictureBox pb in Hullpanel.Controls)
            {
                if (hullimagenum < images.Count)
                    pb.Image = images[hullimagenum];
                hullimagenum++;
            }


            //выделение векторов признаков
            List<Primary> marks = new List<Primary>();
            List<double[]> objectMarksHull = new List<double[]>();
            List<double[]> objectMarksContur = new List<double[]>();
            List<double[]> etallMarksCentrHull = new List<double[]>();
            List<double[]> etallMarksCentrContur = new List<double[]>();
            List<double[]> etallMarksMedHull = new List<double[]>();
            List<double[]> etallMarksMedContur = new List<double[]>();

            for (i = 0; i < images.Count; i++)
            {
                marks.Add(new Primary(images[i], edgePoint[i], convexHull[i]));
                objectMarksContur.Add(marks[i].Contour());
                objectMarksHull.Add(marks[i].Convex());
            }

            //Отрисовка выпуклой оболочки
            for (i = 0; i < convexHull.Count; i++)
            {
                Graphics gr1 = Graphics.FromImage(images[i]);
                List<System.Drawing.Point> pt = new List<System.Drawing.Point>(convexHull[i]);
                for (int j = 0; j < pt.Count; j++)
                {
                    qh.PutPixel(gr1, Color.Red, pt[j].X, pt[j].Y, 255);
                }
                gr1 = Graphics.FromImage(imagesWithEdge[i]);
                List<System.Drawing.Point> pt1 = new List<System.Drawing.Point>(edgePoint[i]);
                for (int j = 0; j < pt1.Count; j++)
                {
                    cont.PutPixel(gr1, Color.Red, pt1[j].X, pt1[j].Y, 255);
                }
            }

            int contourimagenum = 0;
            foreach (PictureBox pb in Contourpanel.Controls)
            {
                if (contourimagenum < imagesWithEdge.Count)
                    pb.Image = imagesWithEdge[contourimagenum];
                contourimagenum++;
            }

            //int hullimagenum = 0;
            //foreach (PictureBox pb in Hullpanel.Controls)
            //{
            //    if (hullimagenum < images.Count)
            //        pb.Image = images[hullimagenum];
            //    hullimagenum++;
            //}


            for (int j = 0; j < etalonimages.Count; j++)
            {
                etallMarksCentrContur.Add(ContourEtalCentr[j]);
                etallMarksMedContur.Add(ContourEtalMedoid[j]);
                etallMarksCentrHull.Add(HullEtalCentr[j]);
                etallMarksMedHull.Add(HullEtalMedoid[j]);
            }


            for (int l = 0; l < images.Count; l++)
            {
                compareobjects(objectMarksHull,
                    objectMarksContur,
                    etallMarksCentrContur,
                    etallMarksMedContur,
                    etallMarksCentrHull,
                    etallMarksMedHull, l);
            }


            images.Clear();
            convexHull.Clear();
            edgePoint.Clear();
            imagesWithEdge.Clear();
            marks.Clear();
            //contourMarks.Clear();
            i = 0;

        }


        private void compareobjects(List<double[]> objectMarksHull, 
            List<double[]> objectMarksContur, 
            List<double[]> etallMarksCentrContur, 
            List<double[]> etallMarksMedContur, 
            List<double[]> etallMarksCentrHull, 
            List<double[]> etallMarksMedHull,
            int num)
        {
            List<double[]> obj, etal;
            //блок выбора по чему сравнивать
            //
            //
            if (rB_Hull.Checked & rB_centroid.Checked)
            {
                obj = objectMarksHull;
                etal = etallMarksCentrHull;
            }
            else if (rB_Hull.Checked & rB_Med.Checked)
            {
                obj = objectMarksHull;
                etal = etallMarksMedHull;
            }
            else if (rB_Kont.Checked & rB_centroid.Checked)
            {
                obj = objectMarksContur;
                etal = etallMarksCentrContur;
            }
            else
            {
                obj = objectMarksContur;
                etal = etallMarksMedContur;
            }
            double[] k = new double[etal.Count];
            for (int i = 0; i < etal.Count; i++)
            {
                double a, b, c, d;
                a = obj[num].Length;
                for (int j = 0; j < etal[i].Length; j++)
                {
                    b = obj[num][j];
                    c = etal[i][j];
                    k[i] += ((b - c) * (b - c));
                }
                d = 1 / a;
                k[i] = d * k[i];
            }
            double min = k[0];
            int ind = 0;
            for (int i = 0; i < k.Length; i++)
                if (k[i] < min)
                {
                    min = k[i];
                    ind = i;
                }
            label15.Text += "Объект "+ ++num+" относиться к " + ++ind + " типу."+'\n';
        }


        private void recogobjcontour1pb_Click(object sender, EventArgs e)
        {
            objectpb.Image = recogobjcontour1pb.Image;
        }

        private void recogobjhull1pb_Click(object sender, EventArgs e)
        {
            objectpb.Image = recogobjhull1pb.Image;
        }

        private void etal1pb_Click(object sender, EventArgs e)
        {
            etalpb.Image = etal1pb.Image;
        }

        private void etal1btn_Click(object sender, EventArgs e)
        {
            Grayscale grayfilter = new Grayscale(0.2125, 0.7154, 0.0721);
            // применяем фильтр
            grayImage = grayfilter.Apply((Bitmap)vebpb.Image);
            //выводим на пичербокс
            //pictureBox1.Image = grayImage;

            mainImage = grayImage.Clone(
                    new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                    System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
            Bitmap Image24 = grayImage.Clone(
                            new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                            System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Bitmap Image8 = grayImage.Clone(
                            new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                            System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
            ProcessingImage pi = new ProcessingImage();
            OtsuThreshold filter = new OtsuThreshold();

            // apply the filter
            filter.ApplyInPlace(Image8);

            // check threshold value           
            Invert filter1 = new Invert();
            ////// apply the filter
            filter1.ApplyInPlace(Image8);


            //изменить блобкаунтер
            BlobCounter bc = new BlobCounter();

            // process binary image
            bc.ProcessImage(Image8);

            Rectangle[] rects = bc.GetObjectsRectangles();

            Bitmap bp = new Bitmap(Image8);
            Bitmap final = new Bitmap(Image24.Width, Image24.Height);
            Bitmap bp8 = new Bitmap(Image8);
            int xCenter = Image8.Width / 2;
            int yCenter = Image8.Height / 2;

            Bitmap tempImage = grayImage.Clone(
                            new Rectangle(0, 0, grayImage.Width, grayImage.Height),
                            System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(tempImage);  //получаю объект графики из битмап

            SolidBrush b = new SolidBrush(Color.Black);  //кисть для заливки
            bp = tempImage.Clone(rects[0], System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            bp8 = Image8.Clone(rects[0], System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
            g.FillRectangle(b, new Rectangle(0, 0, tempImage.Width, tempImage.Height)); //заполняю   
            for (int x = 0; x < bp8.Width; x++)
                for (int y = 0; y < bp8.Height; y++)
                {
                    if (bp8.GetPixel(x, y).R == 0)
                    {
                        bp.SetPixel(x, y, Color.Black);
                    }
                }
            int shiftX = xCenter - rects[0].Width / 2;
            int shiftY = yCenter - rects[0].Height / 2;
            g.DrawImage(bp, shiftX, shiftY, rects[0].Width, rects[0].Height);
            //etalonimages.Add(tempImage);

            foreach (PictureBox pb in etalonpanel.Controls.OfType<PictureBox>())
            {
                if (pb.Image == null)
                {
                    pb.Image = tempImage;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vebpb.Image = objectpb.Image;
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            label_StatusCam.Text = "";
            vebcamdriver.getCamList(comboBox_VideoCam);
        }

        private void StartStop_button_Click(object sender, EventArgs e)
        {
            if (button_StartStop.Text == "Старт")
            {
                if (vebcamdriver.DeviceExist)
                {
                    label_StatusCam.Text = "";
                    vebcamdriver.videoSource = new VideoCaptureDevice(vebcamdriver.videoDevices[comboBox_VideoCam.SelectedIndex].MonikerString);
                    vebcamdriver.videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    vebcamdriver.CloseVideoSource();
                    vebcamdriver.videoSource.DesiredFrameSize = new Size(320, 240);
                    //videoSource.DesiredFrameRate = 10;
                    vebcamdriver.videoSource.Start();
                    label_StatusCam.Text = "Устройство запущено...";
                    button_StartStop.Text = "Стоп";
                    timer1.Enabled = true;
                }
                else
                {
                    label_StatusCam.Text = "Ошибка: Устройство не выбрано.";
                }
            }
            else
            {
                if (vebcamdriver.videoSource.IsRunning)
                {
                    timer1.Enabled = false;
                    vebcamdriver.CloseVideoSource();
                    label_StatusCam.Text = "Устройство остановлено.";
                    button_StartStop.Text = "Старт";
                }
            }
        }
        public void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            //do processing here
            vebpb.Image = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vebcamdriver.getCamList(comboBox_VideoCam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image;
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    //вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
                    vebpb.Image = image;
                    vebpb.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //vebpb.Image.Save("dsadas", ImageFormat.Png);
            etalpb.Image.Save("etalpb.png", ImageFormat.Png);
            //objectpb.Image.Save("etalpb.png", ImageFormat.Png);
        }

        private void etal2pb_Click(object sender, EventArgs e)
        {
            etalpb.Image = etal2pb.Image;
        }

        private void etal3pb_Click(object sender, EventArgs e)
        {
            etalpb.Image = etal3pb.Image;
        }

        private void etal4pb_Click(object sender, EventArgs e)
        {
            etalpb.Image = etal4pb.Image;
        }

        private void etal5pb_Click(object sender, EventArgs e)
        {
            etalpb.Image = etal5pb.Image;
        }

        private void etal6pb_Click(object sender, EventArgs e)
        {
            etalpb.Image = etal6pb.Image;
        }

        private void etal7pb_Click(object sender, EventArgs e)
        {
            etalpb.Image = etal7pb.Image;
        }

        private void etal8pb_Click(object sender, EventArgs e)
        {
            etalpb.Image = etal8pb.Image;
        }

        private void etal9pb_Click(object sender, EventArgs e)
        {
            etalpb.Image = etal9pb.Image;
        }

        private void etal10pb_Click(object sender, EventArgs e)
        {
            etalpb.Image = etal10pb.Image;
        }

        private void Gen_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            vebcamdriver.CloseVideoSource();
        }

        private void recogobjcontour2pb_Click(object sender, EventArgs e)
        {
            objectpb.Image = recogobjcontour2pb.Image;
        }

        private void recogobjcontour3pb_Click(object sender, EventArgs e)
        {
            objectpb.Image = recogobjcontour1pb.Image;
        }

        private void recogobjhull2pb_Click(object sender, EventArgs e)
        {
            objectpb.Image = recogobjhull2pb.Image;
        }

        private void recogobjhull3pb_Click(object sender, EventArgs e)
        {
            objectpb.Image = recogobjhull3pb.Image;
        }
    }
}