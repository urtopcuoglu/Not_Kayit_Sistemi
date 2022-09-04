namespace Not_Kayit_Sistemi
{
    partial class OgretmenPaneli
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblGecen = new System.Windows.Forms.Label();
            this.lblSınıfOrtalama = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBNotKayıtDataSet = new Not_Kayit_Sistemi.DBNotKayıtDataSet();
            this.tBLDERSTableAdapter = new Not_Kayit_Sistemi.DBNotKayıtDataSetTableAdapters.TBLDERSTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotKayıtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtNumara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(126, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Öğrenci Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Öğrenci Soyadı :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(126, 109);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(131, 22);
            this.txtSoyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(126, 77);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(131, 22);
            this.txtAd.TabIndex = 2;
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(126, 39);
            this.txtNumara.Mask = "0000";
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 22);
            this.txtNumara.TabIndex = 1;
            this.txtNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numara : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtS1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtS3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtS2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(287, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 206);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci - Sınav Paneli";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(79, 42);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(131, 22);
            this.txtS1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(79, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınav 3 :";
            // 
            // txtS3
            // 
            this.txtS3.Location = new System.Drawing.Point(79, 109);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(131, 22);
            this.txtS3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sınav 2 : ";
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(79, 77);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(131, 22);
            this.txtS2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav 1 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblKalan);
            this.groupBox3.Controls.Add(this.lblGecen);
            this.groupBox3.Controls.Add(this.lblSınıfOrtalama);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(526, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 206);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci - Sınav Paneli";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Location = new System.Drawing.Point(109, 115);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(21, 16);
            this.lblKalan.TabIndex = 8;
            this.lblKalan.Text = "00";
            // 
            // lblGecen
            // 
            this.lblGecen.AutoSize = true;
            this.lblGecen.Location = new System.Drawing.Point(109, 82);
            this.lblGecen.Name = "lblGecen";
            this.lblGecen.Size = new System.Drawing.Size(21, 16);
            this.lblGecen.TabIndex = 7;
            this.lblGecen.Text = "00";
            // 
            // lblSınıfOrtalama
            // 
            this.lblSınıfOrtalama.AutoSize = true;
            this.lblSınıfOrtalama.Location = new System.Drawing.Point(109, 47);
            this.lblSınıfOrtalama.Name = "lblSınıfOrtalama";
            this.lblSınıfOrtalama.Size = new System.Drawing.Size(21, 16);
            this.lblSınıfOrtalama.TabIndex = 6;
            this.lblSınıfOrtalama.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kalan Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Geçen Sayısı : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ortalama :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(13, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(746, 343);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNUMARADataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRS1DataGridViewTextBoxColumn,
            this.oGRS2DataGridViewTextBoxColumn,
            this.oGRS3DataGridViewTextBoxColumn,
            this.oRTALAMDataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLDERSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // oGRIDDataGridViewTextBoxColumn
            // 
            this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGR_ID";
            this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGR_ID";
            this.oGRIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
            this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oGRNUMARADataGridViewTextBoxColumn
            // 
            this.oGRNUMARADataGridViewTextBoxColumn.DataPropertyName = "OGR_NUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.HeaderText = "OGR_NUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRNUMARADataGridViewTextBoxColumn.Name = "oGRNUMARADataGridViewTextBoxColumn";
            // 
            // oGRADDataGridViewTextBoxColumn
            // 
            this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGR_AD";
            this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGR_AD";
            this.oGRADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
            // 
            // oGRSOYADDataGridViewTextBoxColumn
            // 
            this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGR_SOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGR_SOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
            // 
            // oGRS1DataGridViewTextBoxColumn
            // 
            this.oGRS1DataGridViewTextBoxColumn.DataPropertyName = "OGR_S1";
            this.oGRS1DataGridViewTextBoxColumn.HeaderText = "OGR_S1";
            this.oGRS1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRS1DataGridViewTextBoxColumn.Name = "oGRS1DataGridViewTextBoxColumn";
            // 
            // oGRS2DataGridViewTextBoxColumn
            // 
            this.oGRS2DataGridViewTextBoxColumn.DataPropertyName = "OGR_S2";
            this.oGRS2DataGridViewTextBoxColumn.HeaderText = "OGR_S2";
            this.oGRS2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRS2DataGridViewTextBoxColumn.Name = "oGRS2DataGridViewTextBoxColumn";
            // 
            // oGRS3DataGridViewTextBoxColumn
            // 
            this.oGRS3DataGridViewTextBoxColumn.DataPropertyName = "OGR_S3";
            this.oGRS3DataGridViewTextBoxColumn.HeaderText = "OGR_S3";
            this.oGRS3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oGRS3DataGridViewTextBoxColumn.Name = "oGRS3DataGridViewTextBoxColumn";
            // 
            // oRTALAMDataGridViewTextBoxColumn
            // 
            this.oRTALAMDataGridViewTextBoxColumn.DataPropertyName = "ORTALAM";
            this.oRTALAMDataGridViewTextBoxColumn.HeaderText = "ORTALAM";
            this.oRTALAMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oRTALAMDataGridViewTextBoxColumn.Name = "oRTALAMDataGridViewTextBoxColumn";
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            // 
            // tBLDERSBindingSource
            // 
            this.tBLDERSBindingSource.DataMember = "TBLDERS";
            this.tBLDERSBindingSource.DataSource = this.dBNotKayıtDataSet;
            // 
            // dBNotKayıtDataSet
            // 
            this.dBNotKayıtDataSet.DataSetName = "DBNotKayıtDataSet";
            this.dBNotKayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLDERSTableAdapter
            // 
            this.tBLDERSTableAdapter.ClearBeforeFill = true;
            // 
            // OgretmenPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OgretmenPaneli";
            this.Text = "Öğretmen Paneli";
            this.Load += new System.EventHandler(this.OgretmenPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotKayıtDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox txtNumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtS3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblGecen;
        private System.Windows.Forms.Label lblSınıfOrtalama;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBNotKayıtDataSet dBNotKayıtDataSet;
        private System.Windows.Forms.BindingSource tBLDERSBindingSource;
        private DBNotKayıtDataSetTableAdapters.TBLDERSTableAdapter tBLDERSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNUMARADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
    }
}