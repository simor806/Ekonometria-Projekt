using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodOfGraphs;


namespace Ekonometria.Test {
    [TestClass]
    public class CalculationsTest {
        private Calculations c;
        private string fileName = @"C:\Users\ula\Dropbox\projekt-ekonometria\test.txt";
        private DataReader d;


        [TestInitialize]
        public void CreateCalculations() {
            c = new Calculations(fileName);
            this.d = new DataReader(fileName);
        }

        [TestMethod]
        public void CorrelationCoefficient() {
            double[,] correlationMatrix = {
                                            {1,0.946685,0.837436,-0.78954},
                                            {0.946685,1,0.67082,-0.71151},
                                            {0.837436,0.67082,1,-0.88388},
                                            {-0.78954,-0.71151,-0.88388,1}
                                          };
            double[,] testedMatrix = c.CorrelationMatrix();
            for (int i = 0; i < 4; ++i) {
                for (int j = 0; j < 4; j++) {
                    Assert.AreEqual(correlationMatrix[i, j], testedMatrix[i, j], 0.0001);
                }
            }
        }

        [TestMethod]
        public void R0Matrix() {
            double[] testMatrix = { 0.946685, 0.837436, -0.78954 };
            double[] R0 = c.CreationR0Matrix();
            for (int i = 0; i < 3; ++i) {
                Assert.AreEqual(testMatrix[i], R0[i], 0.00001);
            }
        }

        [TestMethod]
        public void RMatrix() {
            double[,] Rtest ={
                                {1,0.67082,-0.71151},
                                {0.67082,1,-0.88388},
                                {-0.71151,-0.88388,1}
                             };
            double[,] R = c.CreationRMatrix();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Assert.AreEqual(Rtest[i, j], R[i, j], 0.0001);
        }

        [TestMethod]
        public void CriticalValueOfTheCorrelationCoefficient() {
            double Ralfa = c.CriticalValue(0.05);
            Assert.AreEqual(0.754545, Ralfa, 0.0001);
        }

        [TestMethod]
        public void CheckingNewRMatrix() {
            double[,] Rtest ={
                                {1,0,0},
                                {0,1,-0.88388},
                                {0,-0.88388,1}
                             };
            double[,] NewR = c.VerificationOfTheHypothesis(0.05);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Assert.AreEqual(Rtest[i, j], NewR[i, j], 0.00001);
        }

        [TestMethod]
        public void AMatrixDetermining() {
            double[,] X = d.CreationXMatrix();
            double[] Y = d.CreationOfYMatrix();
            double[] pom = { -15.26, 0.035, 2.67, 1.32 };
            double[] res = c.CreateAMatrix(X, Y);
            for (int i = 0; i < pom.Length; i++)
                Assert.AreEqual(pom[i], res[i], 0.01);
        }

        [TestMethod]
        public void DetermRMatrix() {
            double Rdeterm = c.DetermRMatrix();
            double pom = 0.106251723;
            Assert.AreEqual(pom, Rdeterm, 0.0001);
        }

        [TestMethod]
        public void TheoreticalValue() {
            double[] pom = { 12.22,13.57,19.33,19.80,22.88,29.56,36.65 };
            double[] res = c.TheoreticalValue();
            for (int i = 0; i < 7; i++)
                Assert.AreEqual(pom[i], res[i], 0.01);
        }

        [TestMethod]
        public void CreationEVector() {
            double[] e ={-0.22,0.43,-2.33,0.2,2.12,0.44,-0.65};
            double[] eR = c.CreationEMatrix();
            for (int i = 0; i < 7; i++)
                Assert.AreEqual(e[i], eR[i], 0.01);
        }

        [TestMethod]
        public void StandardDeviation2() {
            double S = 3.613;
            double Stest = c.CalcStandardDeviation2(7);
            Assert.AreEqual(S, Stest, 0.001);
        }

        [TestMethod]
        public void CorvarianceMatrix() {
            double[] D2 = c.CorvarianceMatrix(7);
            double[] pom ={15.8185,0.006099,1.024385,1.528994};
                for (int j = 0; j < 4; j++)
                    Assert.AreEqual(pom[j], D2[j], 0.001);
        }
    }
}
