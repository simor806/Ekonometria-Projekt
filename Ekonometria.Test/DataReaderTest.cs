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
        public void CreateYMatrix() {
            int[] yMatrix = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            int[] testMatrix = dr.CreateYMatrix();
            for (int i = 0; i < 21; ++i) {
                Assert.AreEqual(yMatrix[i], testMatrix[i]);
            }
        }

        [TestMethod]
        public void LineOfXMatrix() {
            double[] tmp = { 1, 45, 0.76, 0.036402626 };
            double[] testXMatrix = dr.LineOfXMatrix();
            for (int i = 0; i < 4; ++i) {
                Assert.AreEqual(tmp[i], testXMatrix[i]);
            }
        }
    }
}
