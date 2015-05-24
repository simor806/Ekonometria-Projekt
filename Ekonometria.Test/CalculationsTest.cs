using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodOfGraphs;

namespace Ekonometria.Test {
    [TestClass]
    public class CalculationsTest{
        private Calculations c;

        [TestInitialize]
        public void CreateCalculations() {
            c = new Calculations();
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
                    Assert.AreEqual(correlationMatrix[i, j] , testedMatrix[i, j],0.0000001);
                }
            }
        }

        [TestMethod]
        public void R0Matrix() {
            double[] testMatrix={1,1,0.301593795227882,0.631761642524286};
            double[] R0= c.CreationR0Matrix();
            for(int i=0; i<4;++i){
                Assert.AreEqual(testMatrix[i], R0[i],0.00001);
            }
        }

        [TestMethod]
        public void RMatrix() {
            double[,] Rtest ={
                                {1,1,0.301593795227882,0.631761642524286},
                                {0.301593795227882,0.301593795227882,1,-0.541379575882234},
                                {0.631761642524286, 0.631761642524286,-0.541379575882234,1}
                             };
            double[,] R = c.CreationRMatrix();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    Assert.AreEqual(Rtest[i, j], R[i, j], 0.000001);
        }

        [TestMethod]
        public void CriticalValueOfTheCorrelationCoefficient() {
            double Ralfa=c.CriticalValue();
            Assert.AreEqual(0.432853514,Ralfa , 0.0001);
        }

        [TestMethod]
        public void CheckingNewRMatrix() {
            double[,] Rtest ={
                                {1,1,0,0.631761642524286},
                                {0,0,1,-0.541379575882234},
                                {0.631761642524286, 0.631761642524286,-0.541379575882234,1}
                             };
            double[,] NewR = c.VerificationOfTheHypothesis();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    Assert.AreEqual(Rtest[i, j], NewR[i, j], 0.00001);
        }
    }
}
