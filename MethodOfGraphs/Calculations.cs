using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms.DataVisualization.Charting;


namespace MethodOfGraphs {
    public class Calculations {
        public DataReader d;
        public double alfa;
        private MatrixOperations m;

        public Calculations(string fileName) {
            this.d = new DataReader(fileName);
            this.m = new MatrixOperations();
        }

        public double[,] W = new double[4, 4];
        public double[,] R = new double[3, 3];

        public double[,] CorrelationMatrix() {

            double[] y = d.CreationOfYMatrix();
            double[,] xMatrix = d.CreationOfXMatrixForCorrelationBetweenX1X2X3();
            int length = d.CountLines();
            double[] x1 = new double[length];
            double[] x2 = new double[length];
            double[] x3 = new double[length];
            
            for (int j = 0; j < length; j++) {
                x1[j] = xMatrix[0, j];
                x2[j] = xMatrix[1, j];
                x3[j] = xMatrix[2, j];
            }
            var excelApplication = new Application();
            W[0, 0] = excelApplication.WorksheetFunction.Pearson(y, y);
            W[0, 1] = excelApplication.WorksheetFunction.Pearson(y, x1);
            W[0, 2] = excelApplication.WorksheetFunction.Pearson(y, x2);
            W[0, 3] = excelApplication.WorksheetFunction.Pearson(y, x3);

            W[1, 0] = excelApplication.WorksheetFunction.Pearson(y, x1);
            W[1, 1] = excelApplication.WorksheetFunction.Pearson(x1, x1);
            W[1, 2] = excelApplication.WorksheetFunction.Pearson(x1, x2);
            W[1, 3] = excelApplication.WorksheetFunction.Pearson(x1, x3);

            W[2, 0] = W[0, 2];
            W[2, 1] = W[1, 2];
            W[2, 2] = excelApplication.WorksheetFunction.Pearson(x2, x2);
            W[2, 3] = excelApplication.WorksheetFunction.Pearson(x2, x3);

            W[3, 0] = W[0, 3];
            W[3, 1] = W[1, 3];
            W[3, 2] = W[2, 3];
            W[3, 3] = excelApplication.WorksheetFunction.Pearson(x3, x3);

            return W;
        }

        public double[] CreationR0Matrix() {

            double[] R0 = new double[3];
            double[,] source = CorrelationMatrix();
            for (int i = 0; i < R0.Length; i++)
                R0[i] = source[0, i+1];
            return R0;
        }

        public double[,] CreationRMatrix() {
            double[,] pom= CorrelationMatrix();
            for (int j = 0; j < 3; j++) {
                R[0, j] = pom[1, j+1];
                R[1, j] = pom[2, j+1];
                R[2, j] = pom[3, j+1];
            }
            return R;
        }

        public double CriticalValue(double alfa) {
            int n = d.CountLines();
            var chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            double tAlfa;
            tAlfa = chart.DataManipulator.Statistics.InverseTDistribution(alfa, n-2);
            double rAlfa = Math.Sqrt((tAlfa * tAlfa)/(n-2+tAlfa*tAlfa));
            return rAlfa;
        }

        public double[,] VerificationOfTheHypothesis(double alfa) {
            double[,] R = CreationRMatrix();
            double RAlfa= CriticalValue(alfa);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (Math.Abs(R[i, j]) <= RAlfa)
                        R[i, j] = 0;
           return R;
        }

        public double[] CreateAMatrix(double[,] X, double[] Y) {
            var XT = m.Transponation(X);
            var XTX = m.MulMatrix(X, XT);
            var XTXOd = m.MatrixInversation(XTX);
            var XTY = m.MulMatrix(XT,Y);
            double[] a = m.MulMatrix(XTXOd, XTY);
            return a; 
        }

        public double DetermRstar() {
            double Rstar = m.MatrixDeterm(CorrelationMatrix());
            return Rstar;
        }

        public double DetermRMatrix() {
            double dR = m.MatrixDeterm(CreationRMatrix());
            return dR;
        }

        public double[] TheoreticalValue() {
            int len= d.CountLines();
            double[] tY = new double[len];
            double[,] X= d.CreationXMatrix();
            double[] a = CreateAMatrix(X,d.CreationOfYMatrix());
            for (int i = 0; i < len; i++) 
                tY[i] = a[0] + a[1] * X[1, i] + a[2] * X[2, i] + a[3] * X[3, i];
            return tY;
        }

        public double[] CreationEMatrix() {
            double[] yThe = TheoreticalValue();
            double[] y = d.CreationOfYMatrix();
            double[] e = new double[y.Length];
            int len= y.Length;
            for (int i = 0; i < len; i++)
                e[i] = y[i] - yThe[i];
            return e;
        }

        public double CalcStandardDeviation2(int n) {
            int k = 4;
            double[] e = CreationEMatrix();
            double [,] eT= new double[1,e.Length];
            double S2;
            for (int i = 0; i < e.Length; i++)
                eT[0, i] = e[i];
            double[] pom = m.MulMatrix(eT, e);
            S2 = (pom[0]) / (n - k);
            return S2;
        }

        public double[] CorvarianceMatrix(int n) {
            double S2 = CalcStandardDeviation2(n);
            double[,] X = d.CreationXMatrix();
            double[,] XT = m.Transponation(X);
            double[,] XTX = m.MulMatrix(XT, X);
            double[,] D = new double[4, 4];
            double [] Dre= new double[4];
            XTX = m.MatrixInversation(XTX);
            for(int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++) 
                    D[i, j] = S2 * XTX[i, j];
            for (int i = 0, j = 0; i < 4; i++, j++)
                Dre[i] = D[i, j];
                return Dre; 
        }
    }
}
