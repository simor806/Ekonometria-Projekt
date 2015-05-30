using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodOfGraphs;

namespace Ekonometria.Test {
    [TestClass]
    public class DataReaderTest {
        private DataReader dr;
        [TestInitialize]
        public void CreateDataReader() {
            dr = new DataReader(@"C:\Users\ula\Dropbox\projekt-ekonometria\test.txt");
        }

        [TestCleanup]
        public void DisposeDataReader() {
            dr.Dispose();
        }

        [TestMethod]
        public void ReadOneLine() {
            Assert.AreEqual("12	100	5	8", dr.ReadLine());
        }

        [TestMethod]
        public void ReadSomeLines() {
            Assert.AreEqual("12	100	5	8", dr.ReadLine());
            Assert.AreEqual("14	100	6	7", dr.ReadLine());
            Assert.AreEqual("17	300	6	6", dr.ReadLine());
        }

        [TestMethod]
        public void ReadLastLine() {
            string lastLine = "";
            while (dr.hasNextLine())
                lastLine = dr.ReadLine();
            Assert.AreEqual("36	600	9	5	", lastLine);
        }

        [TestMethod]
        public void CountLines() {
            Assert.AreEqual(7, dr.CountLines());
        }

        [TestMethod]
        public void YMatrix() {
            double[] yMatrix = { 12.0,14.0,17.0,20.0,25.0,30.0,36.0};
            double[] testMatrix = dr.CreationOfYMatrix();
            for (int i = 0; i < 7; ++i) {
                Assert.AreEqual(yMatrix[i], testMatrix[i]);
            }
        }

        [TestMethod]
        public void X1X2X3Matrix() {
            double[,] tmp = { 
                             {100.0, 100.0,300.0,200.0,400.0,400.0,600.0 },
                             {5.0,6.0,6.0,8.0,6.0,9.0,9.0},
                             {8.0,7.0,6.0,5.0,6.0,5.0,5.0}
                            };
            double[,] testXMatrix = dr.CreationOfXMatrixForCorrelationBetweenX1X2X3();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 7; j++) {
                    Assert.AreEqual(tmp[i, j], testXMatrix[i, j]);
                }
            }
        }

        [TestMethod]
        public void XMatrix() {
            double[,] tmp ={ {1,1,1,1,1,1,1},
                             {100.0, 100.0,300.0,200.0,400.0,400.0,600.0 },
                             {5.0,6.0,6.0,8.0,6.0,9.0,9.0},
                             {8.0,7.0,6.0,5.0,6.0,5.0,5.0}
                            };
            double[,] X=dr.CreationXMatrix();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 7; j++)
                    Assert.AreEqual(tmp[i, j], X[i, j]);
        }


    }
}
