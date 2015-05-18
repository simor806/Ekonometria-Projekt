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
        public int[] yMatrix;
        public double[] xMatrix;

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

        public int[] CreateYMatrix() {
            int length = CountLines();
            yMatrix = new int[length];
            for (int i = 0; i < length; ++i)
                yMatrix[i] = i + 1;
            return yMatrix;
        }


        public double[] LineOfXMatrix() {
            int length = CountLines();
            xMatrix = new double[length];
            string[] tmp = new string[length];
            string c = ReadLine();
            tmp = c.Split('\t');
            for (int i = 0; i < length; ++i) {
                xMatrix[i] = Convert.ToDouble(tmp[i]);
            }
            return xMatrix;
        }

    }
}
