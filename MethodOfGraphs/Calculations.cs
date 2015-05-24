using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms.DataVisualization.Charting;




namespace MethodOfGraphs {
    public class Calculations {
        DataReader d = new DataReader(@"C:\Users\ula\Dropbox\projekt-ekonometria\Dane_testowe2.txt");
        int n = 21;

        public double[,] W = new double[4, 4];
        public double[,] R = new double[3, 4];

        public double[,] CorrelationMatrix() {

            double[] y = d.TheCreationOfYMatrix();
            double[,] xMatrix = d.TheCreationOfXMatrix();
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

            double[] R0 = new double[4];
            double[,] source = CorrelationMatrix();
            for (int i = 0; i < R0.Length; i++)
                R0[i] = source[0, i];
            return R0;
        }

        public double[,] CreationRMatrix() {
            double[,] pom= CorrelationMatrix();
            for (int j = 0; j < 4; j++) {
                R[0, j] = pom[1, j];
                R[1, j] = pom[2, j];
                R[2, j] = pom[3, j];
            }
            return R;
        }

        public double CriticalValue() {
            var chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            double tAlfa;
            tAlfa = chart.DataManipulator.Statistics.InverseTDistribution(0.05, n-2);
            double rAlfa = Math.Sqrt((tAlfa * tAlfa)/(n-2+tAlfa*tAlfa));
            return rAlfa;
        }

        public double[,] VerificationOfTheHypothesis() {
            double[,] R = CreationRMatrix();
            double RAlfa= CriticalValue();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    if (Math.Abs(R[i, j]) <= RAlfa)
                        R[i, j] = 0;
           return R;
        }
    }
}
