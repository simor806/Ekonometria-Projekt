using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodOfGraphs;


namespace Ekonometria.Test {
    [TestClass]
    public class CalculationsTest {
        private Calculations c;
        private string fileName = @"C:\Users\ula\Dropbox\projekt-ekonometria\Dane_testowe2.txt";
        private DataReader d;


        [TestInitialize]
        public void CreateCalculations() {
            c = new Calculations(fileName);
            this.d = new DataReader(fileName);
        }

        [TestMethod]
        public void CorrelationCoefficient() {
            double[,] correlationMatrix = {
                                            {1,1,0.301593795227882,0.631761642524286},
                                            {1,1,0.301593795227882,0.631761642524286},
                                            {0.301593795227882,0.301593795227882,1,-0.541379575882234},
                                            {0.631761642524286,0.631761642524286,-0.541379575882234,1}
                                          };
            double[,] testedMatrix = c.CorrelationMatrix();
            for (int i = 0; i < 4; ++i) {
                for (int j = 0; j < 4; j++) {
                    Assert.AreEqual(correlationMatrix[i, j], testedMatrix[i, j], 0.0000001);
                }
            }
        }

        [TestMethod]
        public void R0Matrix() {
            double[] testMatrix = { 1, 0.301593795227882, 0.631761642524286 };
            double[] R0 = c.CreationR0Matrix();
            for (int i = 0; i < 3; ++i) {
                Assert.AreEqual(testMatrix[i], R0[i], 0.00001);
            }
        }

        [TestMethod]
        public void RMatrix() {
            double[,] Rtest ={
                                {1,0.301593795227882,0.631761642524286},
                                {0.301593795227882,1,-0.541379575882234},
                                {0.631761642524286,-0.541379575882234,1}
                             };
            double[,] R = c.CreationRMatrix();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Assert.AreEqual(Rtest[i, j], R[i, j], 0.000001);
        }

        [TestMethod]
        public void CriticalValueOfTheCorrelationCoefficient() {
            double Ralfa = c.CriticalValue(0.05);
            Assert.AreEqual(0.432853514, Ralfa, 0.0001);
        }

        [TestMethod]
        public void CheckingNewRMatrix() {
            double[,] Rtest ={
                                {1,0,0.631761642524286},
                                {0,1,-0.541379575882234},
                                {0.631761642524286,-0.541379575882234,1}
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
            double[] pom = { -44, 1, -5.7e-14, 1.71e-13 };
            double[] res = c.CreateAMatrix(X, Y);
            for (int i = 0; i < pom.Length; i++)
                Assert.AreEqual(pom[i], res[i], 0.000001);
        }

        [TestMethod]
        public void DetermRstarMatrix() {
            double Rstar = c.DetermRstar();
            double pom = 2.33649e-18;
            Assert.AreEqual(pom, Rstar, 0.00001);
        }

        [TestMethod]
        public void DetermRMatrix() {
            double Rdeterm = c.DetermRMatrix();
            double pom = 0.010522626;
            Assert.AreEqual(pom, Rdeterm, 0.00001);
        }

        [TestMethod]
        public void TheoreticalValue() {
            double[] pom = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            double[] res = c.TheoreticalValue();
            for (int i = 0; i < 21; i++)
                Assert.AreEqual(pom[i], res[i], 0.1);
        }

        [TestMethod]
        public void CreationEVector() {
            double[] e ={7.71083E-12,7.85616E-12,8.06333E-12,8.02647E-12,8.48477E-12,
                        8.18723E-12,8.75033E-12,8.39417E-12,9.20863E-12,8.55138E-12,
                        9.6243E-12,8.70237E-12,1.00506E-11,8.90843E-12,1.03668E-11,
                        9.05942E-12,1.08322E-11,9.21929E-12,1.12941E-11,9.40759E-12,9.37561E-12};
            double[] eR = c.CreationEMatrix();
            for (int i = 0; i < 21; i++)
                Assert.AreEqual(e[i], eR[i], 0.0001);
        }

        [TestMethod]
        public void StandardDeviation2() {
            double S = 1.02304e-22;
            double Stest = c.CalcStandardDeviation2(21);
            Assert.AreEqual(S, Stest, 0.00001);
        }

        [TestMethod]
        public void CorvarianceMatrix() {
            double[] D2 = c.CorvarianceMatrix(21);
            double[] pom ={1.73e-20,8.93e-24,2.94e-23,3.91343e-23};
                for (int j = 0; j < 4; j++)
                    Assert.AreEqual(pom[j], D2[j], 0.000001);
        }
    }
}
