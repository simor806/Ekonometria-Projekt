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
                textBoxPath.Text = fileName;
                VisualisationData(fileName);
            }
        }

        private void buttonShowGraph_Click(object sender, EventArgs e)
        {
            GraphicalRepresentation r = new GraphicalRepresentation(fileName);
            alfa = Convert.ToDouble(comboBoxAlfa.Text);
            r.DrawingGraph(alfa);
        }

        private void VisualisationData(string fileName)
        {
            alfa = Convert.ToDouble(comboBoxAlfa.Text);
            dr = new DataReader(fileName);
            string[,] data = dr.UploadingDGVDataFromFile();
            int len = dr.CountLines();
            dataGridViewDataFromFile.RowCount = len;
            dataGridViewTY.RowCount = len;
            dataGridViewDataFromFile.ColumnCount = 4;

            for (int j = 0; j < len; j++)
            {
                for (int i = 0; i < 4; i++)
                    dataGridViewDataFromFile.Rows[j].Cells[i].Value = data[i, j];
                dataGridViewDataFromFile.Rows[j].HeaderCell.Value = j.ToString();
                dataGridViewTY.Rows[j].HeaderCell.Value = j.ToString();
            }
            buttonCalculate.Enabled = true;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            alfa = Convert.ToDouble(comboBoxAlfa.Text);
            int n = dr.CountLines();
            VisualisationR0(fileName);
            VisualisationR(fileName);
            VisualisationCalculation(fileName, alfa, n);
            VisualisationDa(fileName, n);
            VisualisationHypothesis(fileName, alfa);
            buttonShowGraph.Enabled = true;
            VisualisationTY(fileName, n);
        }

        private void VisualisationR0(string fileName)
        {
            double[] R0 = new double[3];
            R0 = dr.UploadingDGVR0();
            dataGridViewR0.RowCount = 3;
            dataGridViewR0.ColumnCount = 1;

            for (int i = 0; i < 3; i++)
                dataGridViewR0.Rows[i].Cells[0].Value = R0[i].ToString("F3");
        }

        private void VisualisationR(string fileName)
        {
            double[,] R = dr.UploadingDGVCorrelation();
            dataGridViewCorrelation.RowCount = 3;
            dataGridViewCorrelation.ColumnCount = 3;
            for (int j = 0; j < 3; j++)
                for (int i = 0; i <= j; i++)
                    //piwo dla tego, kto mi powie, dlaczego ten IF działa tylko dla pierwszej jedynki...
                    if (R[i, j] == 1)
                        dataGridViewCorrelation.Rows[j].Cells[i].Value = R[i, j].ToString("F0");
                    else
                        dataGridViewCorrelation.Rows[j].Cells[i].Value = R[i, j].ToString("F3");
        }

        private void VisualisationHypothesis(string fileName, double alfa)
        {
            double[,] Ralfa = dr.UploadingDGVR(alfa);
            dataGridViewR.RowCount = 3;
            dataGridViewR.ColumnCount = 3;
            for (int j = 0; j < 3; j++)
                for (int i = 0; i <= j; i++)
                    //piwo dla tego, kto mi powie, dlaczego ten IF działa tylko dla pierwszej jedynki...
                    if (Ralfa[i, j] == 0 || Ralfa[i, j] == 1.0)
                    {
                        Console.WriteLine(Ralfa[i, j]);
                        dataGridViewR.Rows[j].Cells[i].Value = Ralfa[i, j].ToString("F0");
                    }
                    else
                    {
                        Console.WriteLine(Ralfa[i, j]);
                        dataGridViewR.Rows[j].Cells[i].Value = Ralfa[i, j].ToString("F3");
                    }

        }

        private void VisualisationCalculation(string fileName, double alfa, int n)
        {
            string[] res = dr.UploadingCalculationValue(alfa, n);
            labelRalfa.Text = res[0];
            labelSa.Text = res[1];
            labelResult.Text = res[2];
        }

        private void VisualisationDa(string fileName, int n)
        {
            Calculations c = new Calculations(fileName);
            double[] D = c.CorvarianceMatrix(n);
            for (int i = 0; i < 4; i++)
                dataGridViewDa.Rows[0].Cells[i].Value = D[i].ToString("F3");
        }

        private void VisualisationTY(string fileName, int n)
        {
            Calculations c = new Calculations(fileName);
            double[] tY = c.TheoreticalValue();
            for (int i = 0; i < n; i++)
                dataGridViewTY.Rows[i].Cells[0].Value = tY[i].ToString("F3");
        }


    }
}
