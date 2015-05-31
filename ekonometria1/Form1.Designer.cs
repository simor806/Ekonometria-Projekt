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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelAlfa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRalfa = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelSa = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDa = new System.Windows.Forms.DataGridView();
            this.D0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            this.dataGridViewR = new System.Windows.Forms.DataGridView();
            this.comboBoxAlfa = new System.Windows.Forms.ComboBox();
            this.groupBoxR = new System.Windows.Forms.GroupBox();
            this.groupBoxDa = new System.Windows.Forms.GroupBox();
            this.groupBoxH = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTY = new System.Windows.Forms.DataGridView();
            this.colTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTY = new System.Windows.Forms.GroupBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataFromFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelation)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).BeginInit();
            this.groupBoxR.SuspendLayout();
            this.groupBoxDa.SuspendLayout();
            this.groupBoxH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTY)).BeginInit();
            this.groupBoxTY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
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
            this.textBoxPath.Location = new System.Drawing.Point(131, 18);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(333, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(12, 16);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(113, 23);
            this.buttonLoadData.TabIndex = 1;
            this.buttonLoadData.Text = "1. Wczytaj dane";
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
            this.dataGridViewDataFromFile.RowHeadersWidth = 50;
            this.dataGridViewDataFromFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDataFromFile.Size = new System.Drawing.Size(452, 423);
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
            this.buttonCalculate.Enabled = false;
            this.buttonCalculate.Location = new System.Drawing.Point(714, 15);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "3. Oblicz";
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
            this.dataGridViewR0.Location = new System.Drawing.Point(15, 22);
            this.dataGridViewR0.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewR0.Name = "dataGridViewR0";
            this.dataGridViewR0.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewR0.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewR0.RowHeadersWidth = 50;
            this.dataGridViewR0.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewR0.Size = new System.Drawing.Size(153, 95);
            this.dataGridViewR0.TabIndex = 4;
            // 
            // colR0
            // 
            this.colR0.HeaderText = "R0";
            this.colR0.Name = "colR0";
            this.colR0.ReadOnly = true;
            this.colR0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.dataGridViewCorrelation.Location = new System.Drawing.Point(178, 22);
            this.dataGridViewCorrelation.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCorrelation.Name = "dataGridViewCorrelation";
            this.dataGridViewCorrelation.ReadOnly = true;
            this.dataGridViewCorrelation.RowHeadersVisible = false;
            this.dataGridViewCorrelation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCorrelation.Size = new System.Drawing.Size(304, 95);
            this.dataGridViewCorrelation.TabIndex = 5;
            // 
            // colRX1
            // 
            this.colRX1.HeaderText = "X1";
            this.colRX1.Name = "colRX1";
            this.colRX1.ReadOnly = true;
            this.colRX1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // labelAlfa
            // 
            this.labelAlfa.AutoSize = true;
            this.labelAlfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlfa.Location = new System.Drawing.Point(480, 19);
            this.labelAlfa.Name = "labelAlfa";
            this.labelAlfa.Size = new System.Drawing.Size(150, 13);
            this.labelAlfa.TabIndex = 6;
            this.labelAlfa.Text = "2. Wybierz poziom istotności α";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "5. Wartość krytyczna współczynnika korelacji";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelRalfa);
            this.panel2.Controls.Add(this.labelResult);
            this.panel2.Controls.Add(this.labelSa);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(483, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 77);
            this.panel2.TabIndex = 15;
            // 
            // labelRalfa
            // 
            this.labelRalfa.AutoSize = true;
            this.labelRalfa.Location = new System.Drawing.Point(232, 10);
            this.labelRalfa.Name = "labelRalfa";
            this.labelRalfa.Size = new System.Drawing.Size(10, 13);
            this.labelRalfa.TabIndex = 25;
            this.labelRalfa.Text = " ";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.Location = new System.Drawing.Point(113, 56);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(11, 13);
            this.labelResult.TabIndex = 24;
            this.labelResult.Text = " ";
            // 
            // labelSa
            // 
            this.labelSa.AutoSize = true;
            this.labelSa.Location = new System.Drawing.Point(201, 33);
            this.labelSa.Name = "labelSa";
            this.labelSa.Size = new System.Drawing.Size(10, 13);
            this.labelSa.TabIndex = 23;
            this.labelSa.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "6. Przeciętny błąd szacunku parametru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "7. Równanie modelu";
            // 
            // dataGridViewDa
            // 
            this.dataGridViewDa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.D0,
            this.D1,
            this.D2,
            this.D3});
            this.dataGridViewDa.Location = new System.Drawing.Point(15, 22);
            this.dataGridViewDa.Name = "dataGridViewDa";
            this.dataGridViewDa.Size = new System.Drawing.Size(443, 42);
            this.dataGridViewDa.TabIndex = 18;
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
            // buttonShowGraph
            // 
            this.buttonShowGraph.Enabled = false;
            this.buttonShowGraph.Location = new System.Drawing.Point(829, 362);
            this.buttonShowGraph.Name = "buttonShowGraph";
            this.buttonShowGraph.Size = new System.Drawing.Size(112, 23);
            this.buttonShowGraph.TabIndex = 17;
            this.buttonShowGraph.Text = "10. Wyświetl graf";
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
            this.dataGridViewR.Location = new System.Drawing.Point(15, 22);
            this.dataGridViewR.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewR.Name = "dataGridViewR";
            this.dataGridViewR.ReadOnly = true;
            this.dataGridViewR.RowHeadersVisible = false;
            this.dataGridViewR.Size = new System.Drawing.Size(303, 90);
            this.dataGridViewR.TabIndex = 16;
            // 
            // comboBoxAlfa
            // 
            this.comboBoxAlfa.FormattingEnabled = true;
            this.comboBoxAlfa.Items.AddRange(new object[] {
            "0,01",
            "0,02",
            "0,03",
            "0,04",
            "0,05",
            "0,06",
            "0,07",
            "0,08",
            "0,09",
            "0,10"});
            this.comboBoxAlfa.Location = new System.Drawing.Point(636, 16);
            this.comboBoxAlfa.Name = "comboBoxAlfa";
            this.comboBoxAlfa.Size = new System.Drawing.Size(51, 21);
            this.comboBoxAlfa.TabIndex = 9;
            this.comboBoxAlfa.Text = "0,05";
            // 
            // groupBoxR
            // 
            this.groupBoxR.Controls.Add(this.dataGridViewR0);
            this.groupBoxR.Controls.Add(this.dataGridViewCorrelation);
            this.groupBoxR.Location = new System.Drawing.Point(483, 51);
            this.groupBoxR.Name = "groupBoxR";
            this.groupBoxR.Size = new System.Drawing.Size(496, 126);
            this.groupBoxR.TabIndex = 26;
            this.groupBoxR.TabStop = false;
            this.groupBoxR.Text = "4. Współczynniki korelacji";
            // 
            // groupBoxDa
            // 
            this.groupBoxDa.Controls.Add(this.dataGridViewDa);
            this.groupBoxDa.Location = new System.Drawing.Point(483, 269);
            this.groupBoxDa.Name = "groupBoxDa";
            this.groupBoxDa.Size = new System.Drawing.Size(473, 75);
            this.groupBoxDa.TabIndex = 27;
            this.groupBoxDa.TabStop = false;
            this.groupBoxDa.Text = "8. Błędy średnie szacunku parametrów";
            // 
            // groupBoxH
            // 
            this.groupBoxH.Controls.Add(this.dataGridViewR);
            this.groupBoxH.Location = new System.Drawing.Point(483, 362);
            this.groupBoxH.Name = "groupBoxH";
            this.groupBoxH.Size = new System.Drawing.Size(334, 117);
            this.groupBoxH.TabIndex = 28;
            this.groupBoxH.TabStop = false;
            this.groupBoxH.Text = "9. Weryfikacja hipotezy o nieistotności współczynników korelacji";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "X1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "X2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "X3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTY
            // 
            this.dataGridViewTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTY});
            this.dataGridViewTY.Location = new System.Drawing.Point(15, 22);
            this.dataGridViewTY.Name = "dataGridViewTY";
            this.dataGridViewTY.RowHeadersWidth = 50;
            this.dataGridViewTY.Size = new System.Drawing.Size(153, 433);
            this.dataGridViewTY.TabIndex = 29;
            // 
            // colTY
            // 
            this.colTY.HeaderText = "Y\'";
            this.colTY.Name = "colTY";
            this.colTY.ReadOnly = true;
            this.colTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBoxTY
            // 
            this.groupBoxTY.Controls.Add(this.dataGridViewTY);
            this.groupBoxTY.Location = new System.Drawing.Point(993, 19);
            this.groupBoxTY.Name = "groupBoxTY";
            this.groupBoxTY.Size = new System.Drawing.Size(183, 460);
            this.groupBoxTY.TabIndex = 30;
            this.groupBoxTY.TabStop = false;
            this.groupBoxTY.Text = "11. Wartości wyliczone";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(ekonometria1.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 487);
            this.Controls.Add(this.groupBoxTY);
            this.Controls.Add(this.groupBoxH);
            this.Controls.Add(this.groupBoxDa);
            this.Controls.Add(this.comboBoxAlfa);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxR);
            this.Controls.Add(this.labelAlfa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewDataFromFile);
            this.Controls.Add(this.buttonShowGraph);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.textBoxPath);
            this.Name = "Form1";
            this.Text = "Ekonometria - projekt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataFromFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCorrelation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).EndInit();
            this.groupBoxR.ResumeLayout(false);
            this.groupBoxDa.ResumeLayout(false);
            this.groupBoxH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTY)).EndInit();
            this.groupBoxTY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewCorrelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX3;
        private System.Windows.Forms.Label labelAlfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonShowGraph;
        private System.Windows.Forms.DataGridView dataGridViewR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn D0;
        private System.Windows.Forms.DataGridViewTextBoxColumn D1;
        private System.Windows.Forms.DataGridViewTextBoxColumn D2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D3;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelSa;
        private System.Windows.Forms.ComboBox comboBoxAlfa;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colR0;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRX3;
        private System.Windows.Forms.Label labelRalfa;
        private System.Windows.Forms.GroupBox groupBoxR;
        private System.Windows.Forms.GroupBox groupBoxDa;
        private System.Windows.Forms.GroupBox groupBoxH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridViewTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTY;
        private System.Windows.Forms.GroupBox groupBoxTY;
    }
}

