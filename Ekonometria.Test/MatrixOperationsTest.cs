using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodOfGraphs;

namespace Ekonometria.Test {
    [TestClass]
    public class MatrixOperationsTest {

        private MatrixOperations mo;

        [TestInitialize]
        public void CreatingMatrixOperations() {
            mo = new MatrixOperations();
        }

        [TestMethod]
        public void TransponationOfMatrix() {

            double[,] what ={
                               {1,4},
                               {2,5},
                               {3,6}
                           };
            double[,] pom ={
                            {1,2,3},
                            {4,5,6}
                           };

            double[,] T = mo.Transponation(what);
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
            double[,] res ={
                              {1.2,4},
                              {3.6,8.8}
                          };

            double[,] AB = mo.MulMatrix(A, B);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Assert.AreEqual(res[i, j], AB[i, j], 0.00001);
        }

        [TestMethod]
        public void Invesation() {
            double[,] a ={ 
                            {2,3},
                            {4,2}
                        };
            double[,] pom ={
                                {-0.25,0.375},
                                {0.5,-0.25}
                            };
            double[,] ia = mo.MatrixInversation(a);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Assert.AreEqual(pom[i, j], ia[i, j],0.00001);
        }

        [TestMethod]
        public void Determ() {
            double[,] a ={ 
                            {2,3},
                            {4,2}
                        };
            double pom = -8;
            var r = mo.MatrixDeterm(a);
            Assert.AreEqual(pom, r);
        }

        [TestMethod]
        public void AddingMatrix() {
            double[,] a ={ 
                           {2,3},
                           {4,2}
                        };
            double[,] pom ={
                                {4,6},
                                {8,4}
                            };
            double[,] r = mo.AddMatrix(a, a);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Assert.AreEqual(pom[i, j], r[i, j]);

        }

        [TestMethod]
        public void SubMatrix() {
            double[,] a ={ 
                           {2,3},
                           {4,2}
                        };
            double[,] pom ={
                                {0,0},
                                {0,0}
                            };
            double[,] r = mo.SubMatrix(a, a);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Assert.AreEqual(pom[i, j], r[i, j]);

        }

        [TestMethod]
        public void ScalMulMatrix() {
            double[,] a ={ 
                           {2,3},
                           {4,2}
                        };
            double[,] pom ={
                                {4,6},
                                {8,4}
                            };
            double[,] r = mo.ScalMul(a, 2);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Assert.AreEqual(pom[i, j], r[i, j]);            
        }

        [TestMethod]
        public void MulVectorAndMatrix() {
            double[,] a ={ 
                           {2,3},
                           {4,2}
                        };
            double[] b = { 2, 3 };
            double[] r = mo.MulMatrix(a, b);
            double[] pom = { 16, 12 } ;
            for (int i = 0; i < 2; i++)
                Assert.AreEqual(pom[i], r[i],0.000001);
        }
    }
}
