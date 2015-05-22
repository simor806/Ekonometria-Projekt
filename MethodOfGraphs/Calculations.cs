using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;



namespace MethodOfGraphs {
    public class Calculations {
        DataReader d = new DataReader(@"C:\Users\ula\Dropbox\projekt-ekonometria\Dane_testowe2.txt");
        public double CorrelationBetweenYX1() {

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
            var r = excelApplication.WorksheetFunction.Pearson(y,x1);
            return r;
        }
    }
}
