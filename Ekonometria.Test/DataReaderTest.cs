using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodOfGraphs;

namespace Ekonometria.Test {
    [TestClass]
    public class DataReaderTest {
        private DataReader dr;
        [TestInitialize]
        public void CreateDataReader() {
            dr = new DataReader(@"C:\Users\ula\Dropbox\projekt-ekonometria\Dane_testowe2.txt");
        }

        [TestCleanup]
        public void DisposeDataReader() {
            dr.Dispose();
        }

        [TestMethod]
        public void ReadOneLine() {
            Assert.AreEqual("1	45	0,76	0,036402626", dr.ReadLine());
        }
        [TestMethod]
        public void ReadSomeLines() {
            Assert.AreEqual("1	45	0,76	0,036402626", dr.ReadLine());
            Assert.AreEqual("2	46	0,471567741	0,088", dr.ReadLine());
            Assert.AreEqual("3	47	1,76	0,30255951", dr.ReadLine());
        }

        [TestMethod]
        public void ReadLastLine() {
            string lastLine = "";
            while (dr.hasNextLine())
                lastLine = dr.ReadLine();
            Assert.AreEqual("21	65	0,216860871	10,088", lastLine);
        }

        [TestMethod]
        public void CountLines() {
            Assert.AreEqual(21, dr.CountLines());
        }

        [TestMethod]
        public void YMatrix() {
            double[] yMatrix = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0, 11.0,
                                   12.0, 13.0, 14.0, 15.0, 16.0, 17.0, 18.0, 19.0, 20.0, 21.0 };
            double[] testMatrix = dr.TheCreationOfYMatrix();
            for (int i = 0; i < 21; ++i) {
                Assert.AreEqual(yMatrix[i], testMatrix[i]);
            }
        }

        [TestMethod]
        public void XMatrix() {
            double[,] tmp = { 
                             {45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65 },
                             {0.76,0.471567741,1.76,0.465528073,2.76,0.289902437,3.76,0.93968652,
                              4.76,0.700087366,5.76,0.354166126,6.76,0.977263017,7.76,0.637337373,
                              8.76,0.41246744,9.76,0.72422777,0.216860871},
                              {0.036402626,0.088,0.30255951,1.088,0.166808574,2.088,0.941648856,
                              3.088,0.587729753,4.088,0.476125115,5.088,0.308421578,6.088,0.791577457,
                              7.088,0.399298348,8.088,0.014612991,9.088,10.088}
                            };
            double[,] testXMatrix = dr.TheCreationOfXMatrix();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 21; j++) {
                    Assert.AreEqual(tmp[i, j], testXMatrix[i, j]);
                }
            }
        }
    }
}
