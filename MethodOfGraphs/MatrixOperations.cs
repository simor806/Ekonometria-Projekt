using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace MethodOfGraphs {
    public class MatrixOperations {

        public DataReader d;
        public Application eA;

        public MatrixOperations() {
            this.eA = new Application();
        }

        public double[,] Transponation(double[,] what) {
            double[,] pom = what;
            int col = what.GetLength(0);
            int row = what.GetLength(1);
            double[,] T = new double[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    T[i, j] = pom[j, i];
            return T;
        }

        public double[,] MulMatrix(double[,] A, double[,] B) {
            int row = A.GetLength(0);
            int col = B.GetLength(1);
            double[,] AB = new double[row, col];
            var c = eA.WorksheetFunction.MMult(A, B);
            for (int i = 0, m = 1; i < col & m < col + 1; i++, m++)
                for (int j = 0, n = 1; j < row & n < row + 1; j++, n++)
                    AB[i, j] = c[m, n];
            return AB;
        }

        public double[,] MatrixInversation(double[,] a) {
            int len = a.GetLength(0);
            double[,] inA = new double[len, len];
            var tmp= eA.WorksheetFunction.MInverse(a);
            for (int i = 0, m = 1; i < len & m < len+1 + 1; i++, m++)
                for (int j = 0, n = 1; j < len & n < len + 1; j++, n++)
                    inA[i, j] = tmp[m, n];
            return inA;
        }

        public double MatrixDeterm(double[,] a) {
            var determA = eA.WorksheetFunction.MDeterm(a);
            return determA;
        }

        public double[,] AddMatrix(double[,] a1, double[,] a2) {
            int m = a1.GetLength(0);
            int n = a1.GetLength(1);
            double[,] re = new double[m, n];
            for(int i=0; i<m; i++)
                for (int j = 0; j < n; j++) 
                    re[i, j] = a1[i, j] + a2[i, j];
            return re;
                
        }

        public double[,] SubMatrix(double[,] a1, double[,] a2) {
            int m = a1.GetLength(0);
            int n = a1.GetLength(1);
            double[,] re = new double[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    re[i, j] = a1[i, j] - a2[i, j];
            return re;
        }


        public double[,] ScalMul(double[,] a, double p) {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            double[,] re = new double[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    re[i, j] = a[i, j]*p;
            return re;
        }

        public double[] MulMatrix(double[,] a, double[] b) {
            int col = a.GetLength(1);
            int row = a.GetLength(0);
            double[] ab = new double[col];

            for (int i = 0; i < col; i++) 
                for (int j = 0; j < row; j++) 
                    ab[i] += b[j] * a[j, i];
                
                return ab;

        }
    }
}
