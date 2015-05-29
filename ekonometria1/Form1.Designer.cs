namespace ekonometria1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.dataGridViewDataFromFile = new System.Windows.Forms.DataGridView();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.dataGridViewR0 = new System.Windows.Forms.DataGridView();
            this.colR0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCorrelation = new System.Windows.Forms.DataGridView();
            this.colRX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRX3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAlfa = new System.Windows.Forms.TextBox();
            this.textBoxRalfa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            this.dataGridViewR = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.D0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataFromFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelation)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Wybierz plik tekstowy";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(85, 12);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(330, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(12, 6);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(67, 36);
            this.buttonLoadData.TabIndex = 1;
            this.buttonLoadData.Text = "Wczytaj dane";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // dataGridViewDataFromFile
            // 
            this.dataGridViewDataFromFile.AllowUserToAddRows = false;
            this.dataGridViewDataFromFile.AllowUserToDeleteRows = false;
            this.dataGridViewDataFromFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataFromFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colY,
            this.colX1,
            this.colX2,
            this.colX3});
            this.dataGridViewDataFromFile.Location = new System.Drawing.Point(12, 51);
            this.dataGridViewDataFromFile.Name = "dataGridViewDataFromFile";
            this.dataGridViewDataFromFile.ReadOnly = true;
            this.dataGridViewDataFromFile.RowHeadersVisible = false;
            this.dataGridViewDataFromFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDataFromFile.Size = new System.Drawing.Size(403, 421);
            this.dataGridViewDataFromFile.TabIndex = 2;
            // 
            // colY
            // 
            this.colY.HeaderText = "Y";
            this.colY.Name = "colY";
            this.colY.ReadOnly = true;
            this.colY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colX1
            // 
            this.colX1.HeaderText = "X1";
            this.colX1.Name = "colX1";
            this.colX1.ReadOnly = true;
            // 
            // colX2
            // 
            this.colX2.HeaderText = "X2";
            this.colX2.Name = "colX2";
            this.colX2.ReadOnly = true;
            // 
            // colX3
            // 
            this.colX3.HeaderText = "X3";
            this.colX3.Name = "colX3";
            this.colX3.ReadOnly = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(234, 40);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Oblicz";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // dataGridViewR0
            // 
            this.dataGridViewR0.AllowUserToAddRows = false;
            this.dataGridViewR0.AllowUserToDeleteRows = false;
            this.dataGridViewR0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewR0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colR0});
            this.dataGridViewR0.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewR0.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewR0.Name = "dataGridViewR0";
            this.dataGridViewR0.ReadOnly = true;
            this.dataGridViewR0.RowHeadersWidth = 50;
            this.dataGridViewR0.Size = new System.Drawing.Size(153, 95);
            this.dataGridViewR0.TabIndex = 4;
            // 
            // colR0
            // 
            this.colR0.HeaderText = "R0";
            this.colR0.Name = "colR0";
            this.colR0.ReadOnly = true;
            // 
            // dataGridViewCorrelation
            // 
            this.dataGridViewCorrelation.AllowUserToAddRows = false;
            this.dataGridViewCorrelation.AllowUserToDeleteRows = false;
            this.dataGridViewCorrelation.AllowUserToResizeRows = false;
            this.dataGridViewCorrelation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCorrelation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRX1,
            this.colRX2,
            this.colRX3});
            this.dataGridViewCorrelation.Location = new System.Drawing.Point(170, 32);
            this.dataGridViewCorrelation.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCorrelation.Name = "dataGridViewCorrelation";
            this.dataGridViewCorrelation.ReadOnly = true;
            this.dataGridViewCorrelation.RowHeadersVisible = false;
            this.dataGridViewCorrelation.Size = new System.Drawing.Size(304, 95);
            this.dataGridViewCorrelation.TabIndex = 5;
            // 
            // colRX1
            // 
            this.colRX1.HeaderText = "X1";
            this.colRX1.Name = "colRX1";
            this.colRX1.ReadOnly = true;
            // 
            // colRX2
            // 
            this.colRX2.HeaderText = "X2";
            this.colRX2.Name = "colRX2";
            this.colRX2.ReadOnly = true;
            // 
            // colRX3
            // 
            this.colRX3.HeaderText = "X3";
            this.colRX3.Name = "colRX3";
            this.colRX3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Poziom istotności α";
            // 
            // textBoxAlfa
            // 
            this.textBoxAlfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAlfa.Location = new System.Drawing.Point(125, 43);
            this.textBoxAlfa.Name = "textBoxAlfa";
            this.textBoxAlfa.Size = new System.Drawing.Size(100, 21);
            this.textBoxAlfa.TabIndex = 7;
            this.textBoxAlfa.Text = "0,05";
            // 
            // textBoxRalfa
            // 
            this.textBoxRalfa.Location = new System.Drawing.Point(220, 11);
            this.textBoxRalfa.Name = "textBoxRalfa";
            this.textBoxRalfa.ReadOnly = true;
            this.textBoxRalfa.Size = new System.Drawing.Size(100, 20);
            this.textBoxRalfa.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wartość krytyczna współczynnika korelacji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Współczynniki korelacji";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.buttonShowGraph);
            this.panel2.Controls.Add(this.dataGridViewR);
            this.panel2.Controls.Add(this.textBoxRalfa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(418, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 246);
            this.panel2.TabIndex = 15;
            // 
            // buttonShowGraph
            // 
            this.buttonShowGraph.Location = new System.Drawing.Point(306, 212);
            this.buttonShowGraph.Name = "buttonShowGraph";
            this.buttonShowGraph.Size = new System.Drawing.Size(112, 23);
            this.buttonShowGraph.TabIndex = 17;
            this.buttonShowGraph.Text = "Wyświetl graf";
            this.buttonShowGraph.UseVisualStyleBackColor = true;
            this.buttonShowGraph.Click += new System.EventHandler(this.buttonShowGraph_Click);
            // 
            // dataGridViewR
            // 
            this.dataGridViewR.AllowUserToAddRows = false;
            this.dataGridViewR.AllowUserToDeleteRows = false;
            this.dataGridViewR.AllowUserToResizeRows = false;
            this.dataGridViewR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewR.Location = new System.Drawing.Point(0, 156);
            this.dataGridViewR.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewR.Name = "dataGridViewR";
            this.dataGridViewR.ReadOnly = true;
            this.dataGridViewR.RowHeadersVisible = false;
            this.dataGridViewR.Size = new System.Drawing.Size(303, 90);
            this.dataGridViewR.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "X2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "X3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(-3, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(452, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Weryfikacja hipotezy o nieistotności współczynników korelacji";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridViewR0);
            this.panel1.Controls.Add(this.dataGridViewCorrelation);
            this.panel1.Location = new System.Drawing.Point(418, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 139);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBoxAlfa);
            this.panel3.Controls.Add(this.buttonCalculate);
            this.panel3.Location = new System.Drawing.Point(418, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 67);
            this.panel3.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dane potrzebne do wykonania obliczeń:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.D0,
            this.D1,
            this.D2,
            this.D3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 42);
            this.dataGridView1.TabIndex = 18;
            // 
            // D0
            // 
            this.D0.HeaderText = "D(a0)";
            this.D0.Name = "D0";
            // 
            // D1
            // 
            this.D1.HeaderText = "D(a1)";
            this.D1.Name = "D1";
            // 
            // D2
            // 
            this.D2.HeaderText = "D(a2)";
            this.D2.Name = "D2";
            // 
            // D3
            // 
            this.D3.HeaderText = "D(a3)";
            this.D3.Name = "D3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Równanie modelu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Przeciętny błąd szacunku parametru";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 473);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewDataFromFile);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.textBoxPath);
            this.Name = "Form1";
            this.Text = "Ekonometria - projekt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataFromFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.DataGridView dataGridViewDataFromFile;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.DataGridView dataGridViewR0;
        private System.Windows.Forms.DataGridViewTextBoxColumn colR0;
        private System.Windows.Forms.DataGridView dataGridViewCorrelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRX3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAlfa;
        private System.Windows.Forms.TextBox textBoxRalfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonShowGraph;
        private System.Windows.Forms.DataGridView dataGridViewR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D0;
        private System.Windows.Forms.DataGridViewTextBoxColumn D1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;

        //klasy z Excela
        //private static Excel.Workbook MyBook = null;
        //private static Excel.Application MyApp = null;
        //private static Excel.Worksheet MySheet = null;


    }
}

