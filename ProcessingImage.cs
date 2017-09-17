using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AForge.Imaging.Filters;
using AForge.Imaging;

namespace WindowsFormsApplication3
{
    class ProcessingImage
    {
        public List<Point> GetPoints(Bitmap bmp)
        {
            List<Point> Points = new List<Point>();

            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    if (bmp.GetPixel(x, y).R == 255) Points.Add(new Point(x, y));
                }

            return Points;
        }

        public Bitmap RotateImg(Bitmap bp, int angle)
        {
            //Bitmap rotatedImage = new Bitmap(bp.Width, bp.Height);
            //using (Graphics g = Graphics.FromImage(rotatedImage))
            //{
            //    g.TranslateTransform(bp.Width / 2, bp.Height / 2); //set the rotation point as the center into the matrix
            //    g.RotateTransform(angle); //rotate
            //    g.TranslateTransform(-bp.Width / 2, -bp.Height / 2); //restore rotation point into the matrix
            //    g.DrawImage(bp, new Point(0, 0)); //draw the image on the new bitmap
            //}
            //return rotatedImage;
            RotateBilinear filter = new RotateBilinear(angle, true);
            // apply the filter
            Bitmap newImage = filter.Apply(bp);
            return newImage;
        }

        public Bitmap ProcImg(Bitmap source)
        {
            for (int x = 0; x < source.Width; x++)
                for (int y = 0; y < source.Height; y++)
                {
                    if (source.GetPixel(x, y).R != 0)
                    {
                        source.SetPixel(x, y, Color.White);
                    }
                }
            return source;
        }
    }
}
