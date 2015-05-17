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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colX3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colR0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.colRX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRX3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.colS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKomb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIntegrH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 0;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(12, 12);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(134, 24);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Wczytaj dane i oblicz";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colY,
            this.colX1,
            this.colX2,
            this.colX3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(403, 493);
            this.dataGridView1.TabIndex = 2;
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
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(929, 14);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "testButton";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colR0});
            this.dataGridView2.Location = new System.Drawing.Point(449, 12);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.Size = new System.Drawing.Size(152, 90);
            this.dataGridView2.TabIndex = 4;
            // 
            // colR0
            // 
            this.colR0.HeaderText = "R0";
            this.colR0.Name = "colR0";
            this.colR0.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRX1,
            this.colRX2,
            this.colRX3});
            this.dataGridView3.Location = new System.Drawing.Point(615, 12);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(303, 90);
            this.dataGridView3.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(565, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Poziom istotności α";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(669, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Statystyka t-Studenta";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(669, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(669, 189);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wartość krytyczna współczynnika korelacji";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colS,
            this.colKomb,
            this.colIndH,
            this.colIntegrH});
            this.dataGridView4.Location = new System.Drawing.Point(449, 239);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(469, 150);
            this.dataGridView4.TabIndex = 12;
            // 
            // colS
            // 
            this.colS.HeaderText = "Nr kombinacji S";
            this.colS.Name = "colS";
            this.colS.ReadOnly = true;
            // 
            // colKomb
            // 
            this.colKomb.HeaderText = "Kombinacja";
            this.colKomb.Name = "colKomb";
            this.colKomb.ReadOnly = true;
            // 
            // colIndH
            // 
            this.colIndH.HeaderText = "Indywidualna pojemność nośników informacji h";
            this.colIndH.Name = "colIndH";
            this.colIndH.ReadOnly = true;
            // 
            // colIntegrH
            // 
            this.colIntegrH.HeaderText = "Integralna pojemność nośników informacji H";
            this.colIntegrH.Name = "colIntegrH";
            this.colIntegrH.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 562);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Ekonometria - projekt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colR0;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRX3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKomb;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntegrH;

        //klasy z Excela
        //private static Excel.Workbook MyBook = null;
        //private static Excel.Application MyApp = null;
        //private static Excel.Worksheet MySheet = null;


    }
}

