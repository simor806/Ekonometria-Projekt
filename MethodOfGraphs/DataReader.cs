using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MethodOfGraphs {
    public class DataReader : IDisposable {
        public string fileName = @"C:\Users\ula\Dropbox\projekt-ekonometria\Dane_testowe2.txt";
        public StreamReader sr;
        public int count = 0;
        public double[] yMatrix;
        public double[,] xMatrix;
        public string[] seperators = { "\t", " " };
        public string[] elements;
        public string source;

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

        public double[] TheCreationOfYMatrix() {
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

        public double[,] TheCreationOfXMatrix() {
            int length = CountLines();
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            xMatrix = new double[3, length];

            while (hasNextLine()) {
                   for (int j = 0; j < 21; j++) {
                       source = ReadLine();
                       elements = source.Split(seperators, StringSplitOptions.None);
                       for (int i = 0; i < 3;i++ )
                           xMatrix[i, j] = Convert.ToDouble(elements[i+1]);
                   } 
            }        
           return xMatrix;
        }
    }
}
