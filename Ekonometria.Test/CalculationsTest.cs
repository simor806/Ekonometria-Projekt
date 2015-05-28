using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodOfGraphs;


namespace Ekonometria.Test {
    [TestClass]
    public class CalculationsTest{
        private Calculations c;
        private string fileName = @"C:\Users\ula\Dropbox\projekt-ekonometria\Dane_testowe2.txt";

        [TestInitialize]
        public void CreateCalculations() {
            c = new Calculations(fileName);
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
            double[] testMatrix={1,0.301593795227882,0.631761642524286};
            double[] R0= c.CreationR0Matrix();
            for(int i=0; i<3;++i){
                Assert.AreEqual(testMatrix[i], R0[i],0.00001);
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
            double Ralfa=c.CriticalValue(0.05);
            Assert.AreEqual(0.432853514,Ralfa , 0.0001);
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
        public void TransponationOfXMatrix() {
            double[,] temp = {
                                {1,45,0.76,0.036402626},
                                {1,46,0.471567741,0.088},
                                {1,47,1.76,0.30255951},
                                {1,48,0.465528073,1.088},
                                {1,	49,	2.76,	0.166808574},
                                {1,	50,	0.289902437,	2.088},
                                {1,	51,	3.76,	0.941648856},
                                {1,	52,	0.93968652,	3.088},
                                {1,	53,	4.76,	0.587729753},
                                {1,	54,	0.700087366,	4.088},
                                {1,	55,	5.76,	0.476125115},
                                {1,	56,	0.354166126,	5.088},
                                {1,	57,	6.76,	0.308421578},
                                {1,	58,	0.977263017,	6.088},
                                {1,	59,	7.76,	0.791577457},
                                {1,	60,	0.637337373,	7.088},
                                {1,	61,	8.76,	0.399298348},
                                {1,	62,	0.41246744,	8.088},
                                {1,	63,	9.76,	0.014612991},
                                {1,	64,	0.72422777,	9.088},
                                {1,	65,	0.216860871,	10.088}
                            };
            double[,] XT = c.TransponationXMatrix();
            for (int i = 0; i < 21; i++) {
                for (int j = 0; j < 4; j++)
                    Assert.AreEqual(temp[i, j], XT[i, j]);
            }
        }

        [TestMethod]
        public void TransponationOfMatrix() {

            double[,] what={
                               {1,4},
                               {2,5},
                               {3,6}
                           };
            double[,] pom ={
                            {1,2,3},
                            {4,5,6}
                           };

            double[,] T = c.Transponation(3,2,what);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    Assert.AreEqual(pom[i, j], T[i, j]);
        }

        [TestMethod]
        public void MatrixMultiplication() {
            double[,] A ={
                             {1,2,3},
                             {4,5,6},
                         };
            double[,] B ={
                             {0.5, 0.2},
                             {0.2, 0.4},
                             {0.1, 1}
                         };
            double[,] res={
                              {1.2,4},
                              {3.6,8.8}
                          };

            double[,] AB = c.MultiplayMatrix(A, B);
            for(int i=0;i<2;i++)
                for(int j=0; j<2;j++)
                    Assert.AreEqual(res[i,j],AB[i,j]);
        }


    }
}
