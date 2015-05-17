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
                        if (j == 0)//wektorY
                             try
                            {
                                tabY[i] = float.Parse(number);
                            }
                            catch
                            {
                                tabY[i] = 0;
                            }
                        else//macierzX
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
            //
            korelacjaXY(tabX, tabY, rowsCount);
            korelacjaXX(tabX, rowsCount);
        }
        private float korelacjaXY(float[,] tabX, float[] tabY, int rowsCount)
        {
            //srednie X i Y
            float[] sredniaX = new float[rowsCount];
            float sredniaY = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < rowsCount; j++)
                {
                    sredniaX[i] += tabX[j, i];
                }
                sredniaX[i] /= rowsCount;
                Console.WriteLine("srednia" + i + " " + sredniaX[i]);
            }

            for (int i = 0; i < rowsCount; i++)
                sredniaY += tabY[i];
            sredniaY /= rowsCount;
            Console.WriteLine("sredniaY " + sredniaY);

            //korelacja Rxy
            float[] Rxy = new float[rowsCount];
            float[] kowariancja = new float[rowsCount];
            float[] odchylenieX = new float[rowsCount];
            float[] odchylenieY = new float[rowsCount];
             
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < rowsCount; j++)
                {
                    kowariancja[i] += (tabX[j, i] * tabY[j] - sredniaX[i] * sredniaY);
                    odchylenieX[i] += ((tabX[j, i] - sredniaX[i]) * (tabX[j, i] - sredniaX[i]));
                    odchylenieY[i] += ((tabY[j] - sredniaY) * (tabY[j] - sredniaY));
                }
                    
                kowariancja[i] /= rowsCount;
                Console.WriteLine("kowariancja" + i + " " + kowariancja[i]);
                odchylenieX[i] /= rowsCount;
                odchylenieX[i] = (float)Math.Sqrt(odchylenieX[i]);
                Console.WriteLine("odchylenieX" + i + " " + odchylenieX[i]);
                odchylenieY[i] /= rowsCount;
                odchylenieY[i] = (float)Math.Sqrt(odchylenieY[i]);
                Console.WriteLine("odchylenieY" + i + " " + odchylenieY[i]);
                Rxy[i] = kowariancja[i] / (odchylenieX[i] * odchylenieY[i]);
                
                Console.WriteLine("rxy" + i + " " + Rxy[i]);
                dataGridView2.Rows[i].Cells[0].Value = Rxy[i];
            }
            return 0;
        }

        private float korelacjaXX(float[,] tabX, int rowsCount)
        {
            float[] sredniaX = new float[rowsCount];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < rowsCount; j++)
                {
                    sredniaX[i] += tabX[j, i];
                }
                sredniaX[i] /= rowsCount;
                Console.WriteLine("srednia" + i + " " + sredniaX[i]);
            }
            
            for (int k = 0; k < 3; k++)
            {
                //korelacja Rxx
                float[] Rxx = new float[rowsCount];
                float[] kowariancja = new float[rowsCount];
                float[] odchylenieXi = new float[rowsCount];
                float[] odchylenieXk = new float[rowsCount];

                for (int i = 0; i <= k; i++)
                {
                    for (int j = 0; j < rowsCount; j++)
                    {
                        kowariancja[i] += (tabX[j, i] * tabX[j, k] - sredniaX[i] * sredniaX[k]);
                        odchylenieXi[i] += ((tabX[j, i] - sredniaX[i]) * (tabX[j, i] - sredniaX[i]));
                        odchylenieXk[i] += ((tabX[j, k] - sredniaX[k]) * (tabX[j, k] - sredniaX[k]));
                    }

                    kowariancja[i] /= rowsCount;
                    Console.WriteLine("kowariancja" + i + " " + kowariancja[i]);
                    odchylenieXi[i] /= rowsCount;
                    odchylenieXi[i] = (float)Math.Sqrt(odchylenieXi[i]);
                    Console.WriteLine("odchylenieXi" + i + " " + odchylenieXi[i]);
                    odchylenieXk[i] /= rowsCount;
                    odchylenieXk[i] = (float)Math.Sqrt(odchylenieXk[i]);
                    Console.WriteLine("odchylenieXk" + k + " " + odchylenieXk[i]);
                    Rxx[i] = kowariancja[i] / (odchylenieXi[i] * odchylenieXk[i]);

                    Console.WriteLine("rxx" + i + k + " " + Rxx[i]);
                    dataGridView3.Rows[k].Cells[i].Value = Rxx[i];
                }
            }
                return 0;
        }



        private void testMethod()
        {
            
            
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //korelacja()
        }
    }
}
