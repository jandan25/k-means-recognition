namespace WindowsFormsApplication3
{
    partial class Gen_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gen_Form));
            this.recognize = new System.Windows.Forms.Button();
            this.Teach = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.etal1btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.etalonpanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.etal1lb = new System.Windows.Forms.Label();
            this.etal1pb = new System.Windows.Forms.PictureBox();
            this.etal2pb = new System.Windows.Forms.PictureBox();
            this.etal3pb = new System.Windows.Forms.PictureBox();
            this.etal4pb = new System.Windows.Forms.PictureBox();
            this.etal5pb = new System.Windows.Forms.PictureBox();
            this.etal6pb = new System.Windows.Forms.PictureBox();
            this.etal7pb = new System.Windows.Forms.PictureBox();
            this.etal8pb = new System.Windows.Forms.PictureBox();
            this.etal9pb = new System.Windows.Forms.PictureBox();
            this.etal10pb = new System.Windows.Forms.PictureBox();
            this.Contourpanel = new System.Windows.Forms.Panel();
            this.recogobjcontour1pb = new System.Windows.Forms.PictureBox();
            this.recogobjcontour2pb = new System.Windows.Forms.PictureBox();
            this.recogobjcontour3pb = new System.Windows.Forms.PictureBox();
            this.Hullpanel = new System.Windows.Forms.Panel();
            this.recogobjhull1pb = new System.Windows.Forms.PictureBox();
            this.recogobjhull2pb = new System.Windows.Forms.PictureBox();
            this.recogobjhull3pb = new System.Windows.Forms.PictureBox();
            this.comboBox_VideoCam = new System.Windows.Forms.ComboBox();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_StartStop = new System.Windows.Forms.Button();
            this.label_StatusCam = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_centmed = new System.Windows.Forms.GroupBox();
            this.rB_Med = new System.Windows.Forms.RadioButton();
            this.rB_centroid = new System.Windows.Forms.RadioButton();
            this.gB_ContHull = new System.Windows.Forms.GroupBox();
            this.rB_Hull = new System.Windows.Forms.RadioButton();
            this.rB_Kont = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.objectpb = new System.Windows.Forms.PictureBox();
            this.etalpb = new System.Windows.Forms.PictureBox();
            this.vebpb = new System.Windows.Forms.PictureBox();
            this.etalonpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etal1pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal2pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal3pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal4pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal5pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal6pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal7pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal8pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal9pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal10pb)).BeginInit();
            this.Contourpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recogobjcontour1pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recogobjcontour2pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recogobjcontour3pb)).BeginInit();
            this.Hullpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recogobjhull1pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recogobjhull2pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recogobjhull3pb)).BeginInit();
            this.groupBox_centmed.SuspendLayout();
            this.gB_ContHull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etalpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vebpb)).BeginInit();
            this.SuspendLayout();
            // 
            // recognize
            // 
            this.recognize.Location = new System.Drawing.Point(590, 33);
            this.recognize.Name = "recognize";
            this.recognize.Size = new System.Drawing.Size(186, 23);
            this.recognize.TabIndex = 1;
            this.recognize.Text = "Распознать";
            this.recognize.UseVisualStyleBackColor = true;
            this.recognize.Click += new System.EventHandler(this.recognize_Click);
            // 
            // Teach
            // 
            this.Teach.Location = new System.Drawing.Point(405, 33);
            this.Teach.Name = "Teach";
            this.Teach.Size = new System.Drawing.Size(179, 23);
            this.Teach.TabIndex = 4;
            this.Teach.Text = "Обучить";
            this.Teach.UseVisualStyleBackColor = true;
            this.Teach.Click += new System.EventHandler(this.Teach_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 673);
            this.progressBar1.Maximum = 180;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1023, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // etal1btn
            // 
            this.etal1btn.Location = new System.Drawing.Point(12, 338);
            this.etal1btn.Name = "etal1btn";
            this.etal1btn.Size = new System.Drawing.Size(130, 23);
            this.etal1btn.TabIndex = 12;
            this.etal1btn.Text = "Добавить эталон";
            this.etal1btn.UseVisualStyleBackColor = true;
            this.etal1btn.Click += new System.EventHandler(this.etal1btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // etalonpanel
            // 
            this.etalonpanel.AutoScroll = true;
            this.etalonpanel.Controls.Add(this.label10);
            this.etalonpanel.Controls.Add(this.label9);
            this.etalonpanel.Controls.Add(this.label8);
            this.etalonpanel.Controls.Add(this.label7);
            this.etalonpanel.Controls.Add(this.label5);
            this.etalonpanel.Controls.Add(this.label4);
            this.etalonpanel.Controls.Add(this.label3);
            this.etalonpanel.Controls.Add(this.label2);
            this.etalonpanel.Controls.Add(this.label1);
            this.etalonpanel.Controls.Add(this.etal1lb);
            this.etalonpanel.Controls.Add(this.etal1pb);
            this.etalonpanel.Controls.Add(this.etal2pb);
            this.etalonpanel.Controls.Add(this.etal3pb);
            this.etalonpanel.Controls.Add(this.etal4pb);
            this.etalonpanel.Controls.Add(this.etal5pb);
            this.etalonpanel.Controls.Add(this.etal6pb);
            this.etalonpanel.Controls.Add(this.etal7pb);
            this.etalonpanel.Controls.Add(this.etal8pb);
            this.etalonpanel.Controls.Add(this.etal9pb);
            this.etalonpanel.Controls.Add(this.etal10pb);
            this.etalonpanel.Location = new System.Drawing.Point(12, 35);
            this.etalonpanel.Name = "etalonpanel";
            this.etalonpanel.Size = new System.Drawing.Size(130, 297);
            this.etalonpanel.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 825);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 737);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 648);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "2";
            // 
            // etal1lb
            // 
            this.etal1lb.AutoSize = true;
            this.etal1lb.Location = new System.Drawing.Point(17, 18);
            this.etal1lb.Name = "etal1lb";
            this.etal1lb.Size = new System.Drawing.Size(13, 13);
            this.etal1lb.TabIndex = 20;
            this.etal1lb.Text = "1";
            // 
            // etal1pb
            // 
            this.etal1pb.Image = ((System.Drawing.Image)(resources.GetObject("etal1pb.Image")));
            this.etal1pb.Location = new System.Drawing.Point(7, 8);
            this.etal1pb.Name = "etal1pb";
            this.etal1pb.Size = new System.Drawing.Size(100, 84);
            this.etal1pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etal1pb.TabIndex = 11;
            this.etal1pb.TabStop = false;
            this.etal1pb.Click += new System.EventHandler(this.etal1pb_Click);
            // 
            // etal2pb
            // 
            this.etal2pb.Image = ((System.Drawing.Image)(resources.GetObject("etal2pb.Image")));
            this.etal2pb.Location = new System.Drawing.Point(7, 98);
            this.etal2pb.Name = "etal2pb";
            this.etal2pb.Size = new System.Drawing.Size(100, 84);
            this.etal2pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etal2pb.TabIndex = 11;
            this.etal2pb.TabStop = false;
            this.etal2pb.Click += new System.EventHandler(this.etal2pb_Click);
            // 
            // etal3pb
            // 
            this.etal3pb.Image = ((System.Drawing.Image)(resources.GetObject("etal3pb.Image")));
            this.etal3pb.Location = new System.Drawing.Point(7, 188);
            this.etal3pb.Name = "etal3pb";
            this.etal3pb.Size = new System.Drawing.Size(101, 84);
            this.etal3pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etal3pb.TabIndex = 16;
            this.etal3pb.TabStop = false;
            this.etal3pb.Click += new System.EventHandler(this.etal3pb_Click);
            // 
            // etal4pb
            // 
            this.etal4pb.Image = ((System.Drawing.Image)(resources.GetObject("etal4pb.Image")));
            this.etal4pb.Location = new System.Drawing.Point(7, 278);
            this.etal4pb.Name = "etal4pb";
            this.etal4pb.Size = new System.Drawing.Size(100, 84);
            this.etal4pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etal4pb.TabIndex = 17;
            this.etal4pb.TabStop = false;
            this.etal4pb.Click += new System.EventHandler(this.etal4pb_Click);
            // 
            // etal5pb
            // 
            this.etal5pb.Image = ((System.Drawing.Image)(resources.GetObject("etal5pb.Image")));
            this.etal5pb.Location = new System.Drawing.Point(7, 368);
            this.etal5pb.Name = "etal5pb";
            this.etal5pb.Size = new System.Drawing.Size(100, 84);
            this.etal5pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etal5pb.TabIndex = 18;
            this.etal5pb.TabStop = false;
            this.etal5pb.Click += new System.EventHandler(this.etal5pb_Click);
            // 
            // etal6pb
            // 
            this.etal6pb.Image = global::WindowsFormsApplication3.Properties.Resources._66;
            this.etal6pb.Location = new System.Drawing.Point(7, 458);
            this.etal6pb.Name = "etal6pb";
            this.etal6pb.Size = new System.Drawing.Size(100, 84);
            this.etal6pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etal6pb.TabIndex = 19;
            this.etal6pb.TabStop = false;
            this.etal6pb.Click += new System.EventHandler(this.etal6pb_Click);
            // 
            // etal7pb
            // 
            this.etal7pb.Image = ((System.Drawing.Image)(resources.GetObject("etal7pb.Image")));
            this.etal7pb.Location = new System.Drawing.Point(7, 548);
            this.etal7pb.Name = "etal7pb";
            this.etal7pb.Size = new System.Drawing.Size(100, 84);
            this.etal7pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etal7pb.TabIndex = 20;
            this.etal7pb.TabStop = false;
            this.etal7pb.Click += new System.EventHandler(this.etal7pb_Click);
            // 
            // etal8pb
            // 
            this.etal8pb.Image = ((System.Drawing.Image)(resources.GetObject("etal8pb.Image")));
            this.etal8pb.Location = new System.Drawing.Point(7, 638);
            this.etal8pb.Name = "etal8pb";
            this.etal8pb.Size = new System.Drawing.Size(100, 84);
            this.etal8pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etal8pb.TabIndex = 21;
            this.etal8pb.TabStop = false;
            this.etal8pb.Click += new System.EventHandler(this.etal8pb_Click);
            // 
            // etal9pb
            // 
            this.etal9pb.Image = ((System.Drawing.Image)(resources.GetObject("etal9pb.Image")));
            this.etal9pb.Location = new System.Drawing.Point(7, 728);
            this.etal9pb.Name = "etal9pb";
            this.etal9pb.Size = new System.Drawing.Size(100, 84);
            this.etal9pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etal9pb.TabIndex = 22;
            this.etal9pb.TabStop = false;
            this.etal9pb.Click += new System.EventHandler(this.etal9pb_Click);
            // 
            // etal10pb
            // 
            this.etal10pb.Location = new System.Drawing.Point(7, 818);
            this.etal10pb.Name = "etal10pb";
            this.etal10pb.Size = new System.Drawing.Size(100, 84);
            this.etal10pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etal10pb.TabIndex = 23;
            this.etal10pb.TabStop = false;
            this.etal10pb.Click += new System.EventHandler(this.etal10pb_Click);
            // 
            // Contourpanel
            // 
            this.Contourpanel.Controls.Add(this.recogobjcontour1pb);
            this.Contourpanel.Controls.Add(this.recogobjcontour2pb);
            this.Contourpanel.Controls.Add(this.recogobjcontour3pb);
            this.Contourpanel.Location = new System.Drawing.Point(792, 35);
            this.Contourpanel.Name = "Contourpanel";
            this.Contourpanel.Size = new System.Drawing.Size(117, 297);
            this.Contourpanel.TabIndex = 12;
            // 
            // recogobjcontour1pb
            // 
            this.recogobjcontour1pb.Location = new System.Drawing.Point(9, 8);
            this.recogobjcontour1pb.Name = "recogobjcontour1pb";
            this.recogobjcontour1pb.Size = new System.Drawing.Size(100, 84);
            this.recogobjcontour1pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recogobjcontour1pb.TabIndex = 18;
            this.recogobjcontour1pb.TabStop = false;
            this.recogobjcontour1pb.Click += new System.EventHandler(this.recogobjcontour1pb_Click);
            // 
            // recogobjcontour2pb
            // 
            this.recogobjcontour2pb.Location = new System.Drawing.Point(9, 99);
            this.recogobjcontour2pb.Name = "recogobjcontour2pb";
            this.recogobjcontour2pb.Size = new System.Drawing.Size(100, 83);
            this.recogobjcontour2pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recogobjcontour2pb.TabIndex = 17;
            this.recogobjcontour2pb.TabStop = false;
            this.recogobjcontour2pb.Click += new System.EventHandler(this.recogobjcontour2pb_Click);
            // 
            // recogobjcontour3pb
            // 
            this.recogobjcontour3pb.Location = new System.Drawing.Point(9, 188);
            this.recogobjcontour3pb.Name = "recogobjcontour3pb";
            this.recogobjcontour3pb.Size = new System.Drawing.Size(100, 84);
            this.recogobjcontour3pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recogobjcontour3pb.TabIndex = 12;
            this.recogobjcontour3pb.TabStop = false;
            this.recogobjcontour3pb.Click += new System.EventHandler(this.recogobjcontour3pb_Click);
            // 
            // Hullpanel
            // 
            this.Hullpanel.Controls.Add(this.recogobjhull1pb);
            this.Hullpanel.Controls.Add(this.recogobjhull2pb);
            this.Hullpanel.Controls.Add(this.recogobjhull3pb);
            this.Hullpanel.Location = new System.Drawing.Point(915, 35);
            this.Hullpanel.Name = "Hullpanel";
            this.Hullpanel.Size = new System.Drawing.Size(117, 297);
            this.Hullpanel.TabIndex = 16;
            // 
            // recogobjhull1pb
            // 
            this.recogobjhull1pb.Location = new System.Drawing.Point(8, 8);
            this.recogobjhull1pb.Name = "recogobjhull1pb";
            this.recogobjhull1pb.Size = new System.Drawing.Size(100, 84);
            this.recogobjhull1pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recogobjhull1pb.TabIndex = 17;
            this.recogobjhull1pb.TabStop = false;
            this.recogobjhull1pb.Click += new System.EventHandler(this.recogobjhull1pb_Click);
            // 
            // recogobjhull2pb
            // 
            this.recogobjhull2pb.Location = new System.Drawing.Point(8, 99);
            this.recogobjhull2pb.Name = "recogobjhull2pb";
            this.recogobjhull2pb.Size = new System.Drawing.Size(100, 83);
            this.recogobjhull2pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recogobjhull2pb.TabIndex = 12;
            this.recogobjhull2pb.TabStop = false;
            this.recogobjhull2pb.Click += new System.EventHandler(this.recogobjhull2pb_Click);
            // 
            // recogobjhull3pb
            // 
            this.recogobjhull3pb.Location = new System.Drawing.Point(8, 188);
            this.recogobjhull3pb.Name = "recogobjhull3pb";
            this.recogobjhull3pb.Size = new System.Drawing.Size(100, 84);
            this.recogobjhull3pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recogobjhull3pb.TabIndex = 18;
            this.recogobjhull3pb.TabStop = false;
            this.recogobjhull3pb.Click += new System.EventHandler(this.recogobjhull3pb_Click);
            // 
            // comboBox_VideoCam
            // 
            this.comboBox_VideoCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VideoCam.FormattingEnabled = true;
            this.comboBox_VideoCam.Location = new System.Drawing.Point(164, 35);
            this.comboBox_VideoCam.Name = "comboBox_VideoCam";
            this.comboBox_VideoCam.Size = new System.Drawing.Size(230, 21);
            this.comboBox_VideoCam.TabIndex = 22;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(164, 66);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(107, 54);
            this.button_Refresh.TabIndex = 23;
            this.button_Refresh.Text = "Обновить";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // button_StartStop
            // 
            this.button_StartStop.Location = new System.Drawing.Point(287, 66);
            this.button_StartStop.Name = "button_StartStop";
            this.button_StartStop.Size = new System.Drawing.Size(107, 54);
            this.button_StartStop.TabIndex = 24;
            this.button_StartStop.Text = "Старт";
            this.button_StartStop.UseVisualStyleBackColor = true;
            this.button_StartStop.Click += new System.EventHandler(this.StartStop_button_Click);
            // 
            // label_StatusCam
            // 
            this.label_StatusCam.AutoSize = true;
            this.label_StatusCam.Location = new System.Drawing.Point(330, 153);
            this.label_StatusCam.Name = "label_StatusCam";
            this.label_StatusCam.Size = new System.Drawing.Size(0, 13);
            this.label_StatusCam.TabIndex = 25;
            // 
            // groupBox_centmed
            // 
            this.groupBox_centmed.Controls.Add(this.rB_Med);
            this.groupBox_centmed.Controls.Add(this.rB_centroid);
            this.groupBox_centmed.Location = new System.Drawing.Point(405, 66);
            this.groupBox_centmed.Name = "groupBox_centmed";
            this.groupBox_centmed.Size = new System.Drawing.Size(199, 57);
            this.groupBox_centmed.TabIndex = 27;
            this.groupBox_centmed.TabStop = false;
            this.groupBox_centmed.Text = "Параметры алгоритма к средних:";
            // 
            // rB_Med
            // 
            this.rB_Med.AutoSize = true;
            this.rB_Med.Location = new System.Drawing.Point(6, 39);
            this.rB_Med.Name = "rB_Med";
            this.rB_Med.Size = new System.Drawing.Size(64, 17);
            this.rB_Med.TabIndex = 1;
            this.rB_Med.Text = "Медоид";
            this.rB_Med.UseVisualStyleBackColor = true;
            // 
            // rB_centroid
            // 
            this.rB_centroid.AutoSize = true;
            this.rB_centroid.Checked = true;
            this.rB_centroid.Location = new System.Drawing.Point(6, 16);
            this.rB_centroid.Name = "rB_centroid";
            this.rB_centroid.Size = new System.Drawing.Size(74, 17);
            this.rB_centroid.TabIndex = 0;
            this.rB_centroid.TabStop = true;
            this.rB_centroid.Text = "Центроид";
            this.rB_centroid.UseVisualStyleBackColor = true;
            // 
            // gB_ContHull
            // 
            this.gB_ContHull.Controls.Add(this.rB_Hull);
            this.gB_ContHull.Controls.Add(this.rB_Kont);
            this.gB_ContHull.Location = new System.Drawing.Point(610, 66);
            this.gB_ContHull.Name = "gB_ContHull";
            this.gB_ContHull.Size = new System.Drawing.Size(166, 57);
            this.gB_ContHull.TabIndex = 0;
            this.gB_ContHull.TabStop = false;
            this.gB_ContHull.Text = "Распознать по:";
            // 
            // rB_Hull
            // 
            this.rB_Hull.AutoSize = true;
            this.rB_Hull.Location = new System.Drawing.Point(6, 37);
            this.rB_Hull.Name = "rB_Hull";
            this.rB_Hull.Size = new System.Drawing.Size(125, 17);
            this.rB_Hull.TabIndex = 1;
            this.rB_Hull.Text = "Выпуклая оболочка";
            this.rB_Hull.UseVisualStyleBackColor = true;
            // 
            // rB_Kont
            // 
            this.rB_Kont.AutoSize = true;
            this.rB_Kont.Checked = true;
            this.rB_Kont.Location = new System.Drawing.Point(6, 16);
            this.rB_Kont.Name = "rB_Kont";
            this.rB_Kont.Size = new System.Drawing.Size(60, 17);
            this.rB_Kont.TabIndex = 0;
            this.rB_Kont.TabStop = true;
            this.rB_Kont.Text = "Контур";
            this.rB_Kont.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Загруженные эталоны:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Web - камера:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(789, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Контур:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(912, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Выпуклая оболочка:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(635, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 20);
            this.label15.TabIndex = 33;
            // 
            // objectpb
            // 
            this.objectpb.Location = new System.Drawing.Point(609, 421);
            this.objectpb.Name = "objectpb";
            this.objectpb.Size = new System.Drawing.Size(423, 246);
            this.objectpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.objectpb.TabIndex = 18;
            this.objectpb.TabStop = false;
            // 
            // etalpb
            // 
            this.etalpb.Location = new System.Drawing.Point(12, 421);
            this.etalpb.Name = "etalpb";
            this.etalpb.Size = new System.Drawing.Size(423, 246);
            this.etalpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.etalpb.TabIndex = 17;
            this.etalpb.TabStop = false;
            // 
            // vebpb
            // 
            this.vebpb.Location = new System.Drawing.Point(287, 133);
            this.vebpb.Name = "vebpb";
            this.vebpb.Size = new System.Drawing.Size(440, 282);
            this.vebpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vebpb.TabIndex = 0;
            this.vebpb.TabStop = false;
            // 
            // Gen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 708);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gB_ContHull);
            this.Controls.Add(this.groupBox_centmed);
            this.Controls.Add(this.label_StatusCam);
            this.Controls.Add(this.button_StartStop);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.comboBox_VideoCam);
            this.Controls.Add(this.objectpb);
            this.Controls.Add(this.etalpb);
            this.Controls.Add(this.Hullpanel);
            this.Controls.Add(this.Contourpanel);
            this.Controls.Add(this.etalonpanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.etal1btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Teach);
            this.Controls.Add(this.recognize);
            this.Controls.Add(this.vebpb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gen_Form";
            this.Text = "Распознавание изображений методом k - средних";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gen_Form_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.etalonpanel.ResumeLayout(false);
            this.etalonpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etal1pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal2pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal3pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal4pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal5pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal6pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal7pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal8pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal9pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etal10pb)).EndInit();
            this.Contourpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recogobjcontour1pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recogobjcontour2pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recogobjcontour3pb)).EndInit();
            this.Hullpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recogobjhull1pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recogobjhull2pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recogobjhull3pb)).EndInit();
            this.groupBox_centmed.ResumeLayout(false);
            this.groupBox_centmed.PerformLayout();
            this.gB_ContHull.ResumeLayout(false);
            this.gB_ContHull.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etalpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vebpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vebpb;
        private System.Windows.Forms.Button recognize;
        private System.Windows.Forms.Button Teach;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox etal1pb;
        private System.Windows.Forms.Button etal1btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel etalonpanel;
        private System.Windows.Forms.PictureBox etal2pb;
        private System.Windows.Forms.Panel Contourpanel;
        private System.Windows.Forms.PictureBox recogobjcontour1pb;
        private System.Windows.Forms.PictureBox etal3pb;
        private System.Windows.Forms.PictureBox recogobjcontour2pb;
        private System.Windows.Forms.PictureBox recogobjcontour3pb;
        private System.Windows.Forms.Panel Hullpanel;
        private System.Windows.Forms.PictureBox recogobjhull3pb;
        private System.Windows.Forms.PictureBox recogobjhull2pb;
        private System.Windows.Forms.PictureBox recogobjhull1pb;
        private System.Windows.Forms.PictureBox etalpb;
        private System.Windows.Forms.PictureBox objectpb;
        private System.Windows.Forms.PictureBox etal10pb;
        private System.Windows.Forms.PictureBox etal9pb;
        private System.Windows.Forms.PictureBox etal8pb;
        private System.Windows.Forms.PictureBox etal7pb;
        private System.Windows.Forms.PictureBox etal6pb;
        private System.Windows.Forms.PictureBox etal5pb;
        private System.Windows.Forms.PictureBox etal4pb;
        private System.Windows.Forms.Label etal1lb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_VideoCam;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_StartStop;
        private System.Windows.Forms.Label label_StatusCam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox_centmed;
        private System.Windows.Forms.RadioButton rB_Med;
        private System.Windows.Forms.RadioButton rB_centroid;
        private System.Windows.Forms.GroupBox gB_ContHull;
        private System.Windows.Forms.RadioButton rB_Hull;
        private System.Windows.Forms.RadioButton rB_Kont;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

