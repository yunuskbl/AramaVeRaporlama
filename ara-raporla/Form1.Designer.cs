namespace ara_raporla
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEMLEKETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAYITTARIHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilgiler1DataSet = new ara_raporla.bilgiler1DataSet();
            this.tablo1TableAdapter = new ara_raporla.bilgiler1DataSetTableAdapters.Tablo1TableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiler1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adi1,
            this.sadi1,
            this.mEMLEKETDataGridViewTextBoxColumn,
            this.mAASDataGridViewTextBoxColumn,
            this.kAYITTARIHIDataGridViewTextBoxColumn,
            this.aDRESDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablo1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(695, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // adi1
            // 
            this.adi1.DataPropertyName = "ADI";
            this.adi1.HeaderText = "ADI";
            this.adi1.Name = "adi1";
            this.adi1.ReadOnly = true;
            // 
            // sadi1
            // 
            this.sadi1.DataPropertyName = "SOYADI";
            this.sadi1.HeaderText = "SOYADI";
            this.sadi1.Name = "sadi1";
            this.sadi1.ReadOnly = true;
            // 
            // mEMLEKETDataGridViewTextBoxColumn
            // 
            this.mEMLEKETDataGridViewTextBoxColumn.DataPropertyName = "MEMLEKET";
            this.mEMLEKETDataGridViewTextBoxColumn.HeaderText = "MEMLEKET";
            this.mEMLEKETDataGridViewTextBoxColumn.Name = "mEMLEKETDataGridViewTextBoxColumn";
            this.mEMLEKETDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mAASDataGridViewTextBoxColumn
            // 
            this.mAASDataGridViewTextBoxColumn.DataPropertyName = "MAAS";
            this.mAASDataGridViewTextBoxColumn.HeaderText = "MAAS";
            this.mAASDataGridViewTextBoxColumn.Name = "mAASDataGridViewTextBoxColumn";
            this.mAASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kAYITTARIHIDataGridViewTextBoxColumn
            // 
            this.kAYITTARIHIDataGridViewTextBoxColumn.DataPropertyName = "KAYITTARIHI";
            this.kAYITTARIHIDataGridViewTextBoxColumn.HeaderText = "KAYITTARIHI";
            this.kAYITTARIHIDataGridViewTextBoxColumn.Name = "kAYITTARIHIDataGridViewTextBoxColumn";
            this.kAYITTARIHIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDRESDataGridViewTextBoxColumn
            // 
            this.aDRESDataGridViewTextBoxColumn.DataPropertyName = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.Name = "aDRESDataGridViewTextBoxColumn";
            this.aDRESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablo1BindingSource
            // 
            this.tablo1BindingSource.DataMember = "Tablo1";
            this.tablo1BindingSource.DataSource = this.bilgiler1DataSet;
            // 
            // bilgiler1DataSet
            // 
            this.bilgiler1DataSet.DataSetName = "bilgiler1DataSet";
            this.bilgiler1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablo1TableAdapter
            // 
            this.tablo1TableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 229);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 25);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 82);
            this.button1.TabIndex = 2;
            this.button1.Text = "TÜMÜNÜ RAPORLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 82);
            this.button2.TabIndex = 2;
            this.button2.Text = "ARANILAN KAYDI RAPORLA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 82);
            this.button3.TabIndex = 3;
            this.button3.Text = "SEÇİLENİ RAPORLA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "SOYADI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(695, 263);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiler1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bilgiler1DataSet bilgiler1DataSet;
        private System.Windows.Forms.BindingSource tablo1BindingSource;
        private bilgiler1DataSetTableAdapters.Tablo1TableAdapter tablo1TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sadi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEMLEKETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAYITTARIHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

