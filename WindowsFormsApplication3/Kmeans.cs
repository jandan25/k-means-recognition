using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    class Kmeans
    {
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
    }
}
