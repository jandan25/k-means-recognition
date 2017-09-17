using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Recognize
    {
        private List<double[]> standards = new List<double[]>();
        public List<double[]> DeleteVEctors(List<double[]> source)
        {
            int j = 0;
            int[] indDel = new int[360];
            double sum = 0;
            double SKO = 0;
            Random rnd = new Random();
            int ind = rnd.Next(source.Count);
            double[] standard = source[ind];
            standards.Add(source[ind]);
            int num = 0;
            foreach (double[] mas in source)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    double k = standard[i] - mas[i];
                    sum += Math.Pow(k,2);
                }
                SKO = sum / mas.Length;
                if (SKO < 0.0001)
                {
                    indDel[j] = num;
                    j++;
                }
                sum = 0;
                num++;
            }
            if (j > 0)
            {
                for (int i = 0; i < j; i++)
                    source.RemoveAt(indDel[i]);
            }
                    
            return source;
        }

        public void FindingStandards(List<double[]> source)
        {
            while (source.Count > 0) {
                DeleteVEctors(source);
            }
        }

        public List<double[]> ReadFromFile()
        {
            List <double[]> VectorsHull = new List<double[]>();
            
            string oper = "";
            int j = 0;
            using (StreamReader fs = new StreamReader(@"VectorsHull.txt"))
            {
                while (true)
                {
                    double[] local = new double[29];
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
                            VectorsHull.Add(local);
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
                return VectorsHull;
            }

        }
        public void RecognizeForBegin(List<double[]> vectors, int numObj)
        {
            int addGr = 0;
            switch (numObj)
            {
                case 1:
                    addGr = 0;
                    break;
                case 2:
                    addGr = 360;
                    break;
                case 3:
                    addGr = 719;
                    break;
                case 4:
                    addGr = 1078;
                    break;
                case 5:
                    addGr = 1437;
                    break;
            }
            double sum = 0;
            int countVec = 359;
            Random rnd = new Random();
            while (true)
            {
                if (countVec <= 0)
                {
                    break;
                }
                int numVec = rnd.Next(countVec)+addGr;
                double[] standard = new double[29];
                standard = vectors[numVec];
                List<double> SKOs = new List<double>();
                standards.Add(standard);
                foreach (double[] mas in vectors)
                {

                    for (int i = 0; i < mas.Length - 1; i++)
                    {
                        double k = standard[i] - mas[i];
                        sum += Math.Pow(k, 2);
                    }
                    SKOs.Add(sum / (mas.Length - 1));
                    sum = 0;

                }
                while (true)
                {
                    int index = SKOs.IndexOf(SKOs.Min());
                    if (vectors[index][28] == numObj)
                    {
                        vectors.RemoveAt(index);
                        SKOs.RemoveAt(index);
                        countVec--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            WriteToFileBegin(standards);
            standards.Clear();
            
        }

        public void WriteToFileBegin(List<double[]> standards)
        {
            string strForHull = "";
            for (int i = 0; i < standards.Count; i++)
            {
                double[] localHull = standards[i];
                for (int j = 0; j < standards[i].Length; j++)
                {
                        strForHull += Convert.ToString(localHull[j]) + ":";
                }
                strForHull += Environment.NewLine;
                File.AppendAllText("standardsHull.txt", strForHull, Encoding.UTF8);
                strForHull = "";
            }
        }
    }
}
