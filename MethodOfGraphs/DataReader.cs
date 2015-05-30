using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MethodOfGraphs {
    public class DataReader : IDisposable {
        public string fileName;
        public StreamReader sr;
        public int count = 0;
        public double[] yMatrix;
        public double[,] xMatrix;
        public string[] seperators = { "\t", " " };
        public string[] elements;
        public string source;
        public double alfa;

        public DataReader(string fileName) {
            this.fileName = fileName;
            sr = File.OpenText(fileName);
        }

        public string ReadLine() {
            return sr.ReadLine();
        }

        public void Dispose() {
            sr.Dispose();
        }

        public bool hasNextLine() {
            return !sr.EndOfStream;
        }

        public int CountLines() {
            while (hasNextLine()) {
                ReadLine();
                count++;
            }
            return count;
        }

        public double[] CreationOfYMatrix() {
            int length = CountLines();
            yMatrix = new double[length];
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (hasNextLine()) {
                for (int i = 0; i < length; ++i) {
                    source = ReadLine();
                    elements = source.Split(seperators, StringSplitOptions.None);
                    yMatrix[i] = Convert.ToDouble(elements[0]);
                }
            }
            return yMatrix;
        }

        public double[,] CreationOfXMatrixForCorrelationBetweenX1X2X3() {
            int length = CountLines();
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            xMatrix = new double[3, length];

            while (hasNextLine()) {
                   for (int j = 0; j < length; j++) {
                       source = ReadLine();
                       elements = source.Split(seperators, StringSplitOptions.None);
                       for (int i = 0; i < 3;i++ )
                           xMatrix[i, j] = Convert.ToDouble(elements[i+1]);
                   } 
            }        
           return xMatrix;
        }

        public string[,] UploadingDGVDataFromFile() {
            int length = CountLines();
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string[,] data = new string[4, length];
            while (hasNextLine()) {
                for (int j = 0; j < length; j++) {
                    source = ReadLine();
                    elements = source.Split(seperators, StringSplitOptions.None);
                    for (int i = 0; i < 4; i++)
                        data[i, j] = elements[i];
                }
            }
            return data;
        }

        public double[] UploadingDGVR0() {
            Calculations cal = new Calculations(fileName);
            double[] R0=cal.CreationR0Matrix();
            return R0;
        }

        public double[,] UploadingDGVCorrelation() {
            Calculations cal = new Calculations(fileName);
            double[,] R = cal.CreationRMatrix();
            return R;
        }

        public double[,] UploadingDGVR(double alfa) {
            Calculations cal = new Calculations(fileName);
            double[,] Ralfa = cal.VerificationOfTheHypothesis(alfa);
            return Ralfa;
        }

        public string[] UploadingCalculationValue(double alfa,int n) {
            string[] w = new string[5];
            Calculations cal = new Calculations(fileName);
            w[0] = Convert.ToString(cal.CriticalValue(alfa).ToString("0.###e+00"));
            w[1] = Convert.ToString(Math.Sqrt(cal.CalcStandardDeviation2(n)).ToString("0.###e+00"));
            double[] a = cal.CreateAMatrix(CreationXMatrix(), CreationOfYMatrix());
            string[] nA = new string[4];
            for (int i = 0; i < 4; i++)
                nA[i] = a[i].ToString("0.###e+00");
            w[2] = "y=" + nA[0] + "+" + nA[1] + "x1+" + nA[2] + "x2+" + nA[3] + "x3";

            return w;
        }

        public double[,] CreationXMatrix() {
            double[,] pom = CreationOfXMatrixForCorrelationBetweenX1X2X3();
            int len= CountLines();
            double[,] X = new double[4, len];
            int p=0;
            int m;

            for (int i = 0; i < 4; i++) 
                for (int j = 0; j < len; j++) 
                    if (i == 0)
                        X[i, j] = 1;
                    else {
                        if (i != 0) {
                            m = i - 1;
                            X[i, j] = pom[m, j];
                        }
                        else {
                            p = j - 1;
                            X[i, j] = pom[i, p];
                        }
                    }
            
            return X;
       }

    }
}

