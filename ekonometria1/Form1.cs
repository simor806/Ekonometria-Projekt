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

namespace ekonometria1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView2.RowCount = 3;
            dataGridView2.Rows[0].HeaderCell.Value = "X1";
            dataGridView2.Rows[1].HeaderCell.Value = "X2";
            dataGridView2.Rows[2].HeaderCell.Value = "X3";

            dataGridView3.RowCount = 3;
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
                textBox1.Text = openFileDialog1.FileName;
                readDataFromFile(openFileDialog1.FileName);
                testMethod();
            }

            

        }

        private void readDataFromFile(string fileName)
        {
            //liczba wierszy
            int rowsCount = 0;
            using (StreamReader reader = File.OpenText(fileName))
            {
                string s = "";
                while ((s = reader.ReadLine()) != null)
                {
                    rowsCount++;
                }
            }
            dataGridView1.RowCount = rowsCount;

            //deklaracja macierzy 
            float[] tabY = new float[rowsCount];
            float[,] tabX = new float[rowsCount, 3]; 

            //wczytanie danych z pliku
            using (StreamReader reader2 = File.OpenText(fileName))
            {
                int i = 0, j = 0;
                string s = "";
                while ((s = reader2.ReadLine()) != null)
                {
                    string[] numbers = s.Split('\t');
                    foreach (string number in numbers)
                    {
                        //do tabeli GUI
                        try
                        {
                            dataGridView1.Rows[i].Cells[j].Value = float.Parse(number);
                        }
                        catch
                        {
                            dataGridView1.Rows[i].Cells[j].Value = 0;
                        } 
                        
                        //do tablic macierzy
                        if (j == 0)
                             try
                            {
                                tabY[i] = float.Parse(number);
                            }
                            catch
                            {
                                tabY[i] = 0;
                            }
                        else
                            try
                            {
                                tabX[i, j - 1] = float.Parse(number);
                            }
                            catch
                            {
                                tabX[i, j - 1] = 0;
                            }
                            
                        j++;
                    }
                    i++;
                    j = 0;
                }
            }
        }
        private void testMethod()
        {
            
            
        }
    }
}
