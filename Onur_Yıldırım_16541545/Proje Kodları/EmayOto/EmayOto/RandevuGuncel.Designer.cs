namespace EmayOto
{
    partial class RandevuGuncel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nıtelıkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarıhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ontarıhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mıssayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emayDataDataSet5 = new EmayOto.EmayDataDataSet5();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtara = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            this.btnGuncel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.mskontarih = new System.Windows.Forms.MaskedTextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxnitelik = new System.Windows.Forms.ComboBox();
            this.cbxmissay = new System.Windows.Forms.ComboBox();
            this.cbxsalon = new System.Windows.Forms.ComboBox();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.randevularTableAdapter = new EmayOto.EmayDataDataSet5TableAdapters.RandevularTableAdapter();
            this.btnsil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emayDataDataSet5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevular";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.salonDataGridViewTextBoxColumn,
            this.nıtelıkDataGridViewTextBoxColumn,
            this.tarıhDataGridViewTextBoxColumn,
            this.ontarıhDataGridViewTextBoxColumn,
            this.mıssayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.randevularBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 452);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 50;
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "Adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "Adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // salonDataGridViewTextBoxColumn
            // 
            this.salonDataGridViewTextBoxColumn.DataPropertyName = "Salon";
            this.salonDataGridViewTextBoxColumn.HeaderText = "Salon";
            this.salonDataGridViewTextBoxColumn.Name = "salonDataGridViewTextBoxColumn";
            // 
            // nıtelıkDataGridViewTextBoxColumn
            // 
            this.nıtelıkDataGridViewTextBoxColumn.DataPropertyName = "Nıtelık";
            this.nıtelıkDataGridViewTextBoxColumn.HeaderText = "Nıtelık";
            this.nıtelıkDataGridViewTextBoxColumn.Name = "nıtelıkDataGridViewTextBoxColumn";
            // 
            // tarıhDataGridViewTextBoxColumn
            // 
            this.tarıhDataGridViewTextBoxColumn.DataPropertyName = "Tarıh";
            this.tarıhDataGridViewTextBoxColumn.HeaderText = "Tarıh";
            this.tarıhDataGridViewTextBoxColumn.Name = "tarıhDataGridViewTextBoxColumn";
            // 
            // ontarıhDataGridViewTextBoxColumn
            // 
            this.ontarıhDataGridViewTextBoxColumn.DataPropertyName = "Ontarıh";
            this.ontarıhDataGridViewTextBoxColumn.HeaderText = "Ontarıh";
            this.ontarıhDataGridViewTextBoxColumn.Name = "ontarıhDataGridViewTextBoxColumn";
            // 
            // mıssayDataGridViewTextBoxColumn
            // 
            this.mıssayDataGridViewTextBoxColumn.DataPropertyName = "Mıssay";
            this.mıssayDataGridViewTextBoxColumn.HeaderText = "Mıssay";
            this.mıssayDataGridViewTextBoxColumn.Name = "mıssayDataGridViewTextBoxColumn";
            // 
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "Randevular";
            this.randevularBindingSource.DataSource = this.emayDataDataSet5;
            // 
            // emayDataDataSet5
            // 
            this.emayDataDataSet5.DataSetName = "EmayDataDataSet5";
            this.emayDataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.txtara);
            this.groupBox2.Controls.Add(this.btnara);
            this.groupBox2.Controls.Add(this.btnGuncel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.mskontarih);
            this.groupBox2.Controls.Add(this.msktarih);
            this.groupBox2.Controls.Add(this.mskTel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbxnitelik);
            this.groupBox2.Controls.Add(this.cbxmissay);
            this.groupBox2.Controls.Add(this.cbxsalon);
            this.groupBox2.Controls.Add(this.txtAdsoyad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(809, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 471);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(72, 23);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(100, 20);
            this.txtara.TabIndex = 23;
            this.txtara.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnara
            // 
            this.btnara.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnara.Font = new System.Drawing.Font("Jokerman", 11F);
            this.btnara.Location = new System.Drawing.Point(219, 19);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(58, 33);
            this.btnara.TabIndex = 22;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnGuncel
            // 
            this.btnGuncel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncel.Font = new System.Drawing.Font("Jokerman", 11F);
            this.btnGuncel.Location = new System.Drawing.Point(11, 391);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(100, 38);
            this.btnGuncel.TabIndex = 21;
            this.btnGuncel.Text = "Güncelle";
            this.btnGuncel.UseVisualStyleBackColor = true;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "İd :";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(72, 49);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 19;
            // 
            // mskontarih
            // 
            this.mskontarih.Location = new System.Drawing.Point(72, 304);
            this.mskontarih.Margin = new System.Windows.Forms.Padding(4);
            this.mskontarih.Mask = "00/00/0000";
            this.mskontarih.Name = "mskontarih";
            this.mskontarih.Size = new System.Drawing.Size(141, 20);
            this.mskontarih.TabIndex = 17;
            this.mskontarih.ValidatingType = typeof(System.DateTime);
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(72, 260);
            this.msktarih.Margin = new System.Windows.Forms.Padding(4);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(141, 20);
            this.msktarih.TabIndex = 18;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(72, 118);
            this.mskTel.Margin = new System.Windows.Forms.Padding(4);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(141, 20);
            this.mskTel.TabIndex = 16;
            this.mskTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTel_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 307);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ön Tarihi :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 348);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Misafir Sayısı :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tarih :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Niteliği :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Salon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Telefon :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adı Soyadı :";
            // 
            // cbxnitelik
            // 
            this.cbxnitelik.FormattingEnabled = true;
            this.cbxnitelik.Items.AddRange(new object[] {
            "DÜĞÜN",
            "KINA",
            "SÜNNET"});
            this.cbxnitelik.Location = new System.Drawing.Point(72, 212);
            this.cbxnitelik.Margin = new System.Windows.Forms.Padding(4);
            this.cbxnitelik.Name = "cbxnitelik";
            this.cbxnitelik.Size = new System.Drawing.Size(141, 21);
            this.cbxnitelik.TabIndex = 6;
            // 
            // cbxmissay
            // 
            this.cbxmissay.FormattingEnabled = true;
            this.cbxmissay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "10+"});
            this.cbxmissay.Location = new System.Drawing.Point(72, 345);
            this.cbxmissay.Margin = new System.Windows.Forms.Padding(4);
            this.cbxmissay.Name = "cbxmissay";
            this.cbxmissay.Size = new System.Drawing.Size(141, 21);
            this.cbxmissay.TabIndex = 7;
            // 
            // cbxsalon
            // 
            this.cbxsalon.FormattingEnabled = true;
            this.cbxsalon.Items.AddRange(new object[] {
            "TERAS",
            "VIP",
            "BEYAZ",
            "QUENN",
            "ŞAYAN",
            "HAMRA",
            "HESTİA",
            "LADİES"});
            this.cbxsalon.Location = new System.Drawing.Point(72, 163);
            this.cbxsalon.Margin = new System.Windows.Forms.Padding(4);
            this.cbxsalon.Name = "cbxsalon";
            this.cbxsalon.Size = new System.Drawing.Size(141, 21);
            this.cbxsalon.TabIndex = 8;
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Location = new System.Drawing.Point(72, 76);
            this.txtAdsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(141, 20);
            this.txtAdsoyad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ara :";
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // btnsil
            // 
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsil.Font = new System.Drawing.Font("Jokerman", 11F);
            this.btnsil.Location = new System.Drawing.Point(156, 391);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(96, 38);
            this.btnsil.TabIndex = 24;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // RandevuGuncel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmayOto.Properties.Resources.arkaplan2;
            this.ClientSize = new System.Drawing.Size(1104, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RandevuGuncel";
            this.Text = "Randevu Guncelle";
            this.Load += new System.EventHandler(this.RandevuGuncel_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emayDataDataSet5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskontarih;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxnitelik;
        private System.Windows.Forms.ComboBox cbxmissay;
        private System.Windows.Forms.ComboBox cbxsalon;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmayDataDataSet5 emayDataDataSet5;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private EmayDataDataSet5TableAdapters.RandevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnGuncel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nıtelıkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarıhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ontarıhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mıssayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button btnsil;
    }
}