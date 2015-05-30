using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MethodOfGraphs;
using System.Globalization;
using System.Diagnostics;

namespace ekonometria1
{
    public partial class Form1 : Form
    {
        public string fileName;
        public DataReader dr;
        public double alfa;
        public Stopwatch sw = new Stopwatch();

        public Form1()
        {
            InitializeComponent();

            dataGridViewR0.RowCount = 3;
            dataGridViewR0.Rows[0].HeaderCell.Value = "X1";
            dataGridViewR0.Rows[1].HeaderCell.Value = "X2";
            dataGridViewR0.Rows[2].HeaderCell.Value = "X3";
            dataGridViewCorrelation.RowCount = 3;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Otwórz plik tekstowy";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";

            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                textBoxPath.Text=fileName;
                VisualisationData(fileName);
            }

        }

        private void buttonShowGraph_Click(object sender, EventArgs e) {
            GraphicalRepresentation r = new GraphicalRepresentation(fileName);
            alfa = Convert.ToDouble(textBoxAlfa.Text);
            r.DrawingGraph(alfa);
        }

        private void VisualisationData(string fileName) {
            alfa = Convert.ToDouble(textBoxAlfa.Text);    
            dr = new DataReader(fileName);
            string[,] data = dr.UploadingDGVDataFromFile();
            int len = dr.CountLines();
            dataGridViewDataFromFile.RowCount = len;
            dataGridViewDataFromFile.ColumnCount = 4;

            for (int j = 0; j < len; j++) 
                for (int i = 0; i < 4; i++) 
                    dataGridViewDataFromFile.Rows[j].Cells[i].Value = data[i, j];
                       
        }

        private void buttonCalculate_Click(object sender, EventArgs e) {
            alfa = Convert.ToDouble(textBoxAlfa.Text);
            int n = dr.CountLines();
            VisualisationR0(fileName);
            VisualisationR(fileName);
            VisualisationCalculation(fileName, alfa,n);
            VisualisationDa(fileName, n);
            VisualisationHypothesis(fileName, alfa);
        }

        private void VisualisationR0(string fileName) {
            double[] R0 = new double[3];
            R0 = dr.UploadingDGVR0();
            dataGridViewR0.RowCount = 3;
            dataGridViewR0.ColumnCount = 1;

           for (int i = 0; i < 3; i++)
                dataGridViewR0.Rows[i].Cells[0].Value = R0[i].ToString("000.###e+00");
        }

        private void VisualisationR(string fileName) {
            double[,]R=  dr.UploadingDGVCorrelation();
            dataGridViewCorrelation.RowCount = 3;
            dataGridViewCorrelation.ColumnCount = 3;
            for (int j = 0; j < 3; j++)
                for (int i = 0; i < 3; i++)
                    dataGridViewCorrelation.Rows[j].Cells[i].Value = R[i, j].ToString("0.###e+00");
        }

        private void VisualisationHypothesis(string fileName, double alfa) {
            double[,] Ralfa = dr.UploadingDGVR(alfa);
            dataGridViewR.RowCount = 3;
            dataGridViewR.ColumnCount = 3;
            for (int j = 0; j < 3; j++)
                for (int i = 0; i < 3; i++)
                    dataGridViewR.Rows[j].Cells[i].Value = Ralfa[i, j];      
        }

        private void VisualisationCalculation(string fileName, double alfa, int n) {
            string[] res = dr.UploadingCalculationValue(alfa, n);
            textBoxRalfa.Text = res[0];
            label10.Text = res[1];
            label11.Text = res[2];
        }

        private void VisualisationDa(string fileName, int n) {
            Calculations c = new Calculations(fileName);
            double[] D = c.CorvarianceMatrix(n);
            for (int i = 0; i < 4; i++)
                dataGridViewDa.Rows[0].Cells[i].Value = D[i].ToString("0.###e+00");
        }

        

    }
}
