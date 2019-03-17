namespace EmayOto
{
    partial class YoneticiEkran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.randevularBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emayDataDataSet4 = new EmayOto.EmayDataDataSet4();
            this.randevularBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emayDataDataSet = new EmayOto.EmayDataDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRanguncel = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.İstatislik = new System.Windows.Forms.GroupBox();
            this.BtnGelirGra = new System.Windows.Forms.Button();
            this.BtnGelır = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ElemanIzın = new System.Windows.Forms.Button();
            this.btnElemanEkle = new System.Windows.Forms.Button();
            this.randevularTableAdapter = new EmayOto.EmayDataDataSetTableAdapters.RandevularTableAdapter();
            this.emayDataDataSet1 = new EmayOto.EmayDataDataSet1();
            this.denemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denemeTableAdapter = new EmayOto.EmayDataDataSet1TableAdapters.denemeTableAdapter();
            this.randevularTableAdapter1 = new EmayOto.EmayDataDataSet4TableAdapters.RandevularTableAdapter();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbbgider = new System.Windows.Forms.Label();
            this.lbbgelir = new System.Windows.Forms.Label();
            this.lbbeleman = new System.Windows.Forms.Label();
            this.lbbavans = new System.Windows.Forms.Label();
            this.lbbmıssay = new System.Windows.Forms.Label();
            this.lbbongorus = new System.Windows.Forms.Label();
            this.lbbrandevu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntumrand = new System.Windows.Forms.Button();
            this.Btngrafık = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnGider = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emayDataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emayDataDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.İstatislik.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emayDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(254, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dataGridView1.DataSource = this.randevularBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 205);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // randevularBindingSource1
            // 
            this.randevularBindingSource1.DataMember = "Randevular";
            this.randevularBindingSource1.DataSource = this.emayDataDataSet4;
            // 
            // emayDataDataSet4
            // 
            this.emayDataDataSet4.DataSetName = "EmayDataDataSet4";
            this.emayDataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevularBindingSource
            // 
            this.randevularBindingSource.DataMember = "Randevular";
            this.randevularBindingSource.DataSource = this.emayDataDataSet;
            // 
            // emayDataDataSet
            // 
            this.emayDataDataSet.DataSetName = "EmayDataDataSet";
            this.emayDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnRanguncel);
            this.groupBox2.Controls.Add(this.btnYeni);
            this.groupBox2.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(1105, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnRanguncel
            // 
            this.BtnRanguncel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRanguncel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRanguncel.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.BtnRanguncel.Location = new System.Drawing.Point(15, 68);
            this.BtnRanguncel.Name = "BtnRanguncel";
            this.BtnRanguncel.Size = new System.Drawing.Size(117, 23);
            this.BtnRanguncel.TabIndex = 0;
            this.BtnRanguncel.Text = "Randevu Güncelle\r\n";
            this.BtnRanguncel.UseVisualStyleBackColor = true;
            this.BtnRanguncel.Click += new System.EventHandler(this.BtnRanguncel_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeni.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.btnYeni.Location = new System.Drawing.Point(15, 28);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(117, 23);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni Randevu";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // İstatislik
            // 
            this.İstatislik.BackColor = System.Drawing.Color.Transparent;
            this.İstatislik.Controls.Add(this.BtnGelirGra);
            this.İstatislik.Controls.Add(this.BtnGelır);
            this.İstatislik.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold);
            this.İstatislik.Location = new System.Drawing.Point(463, 258);
            this.İstatislik.Name = "İstatislik";
            this.İstatislik.Size = new System.Drawing.Size(200, 144);
            this.İstatislik.TabIndex = 2;
            this.İstatislik.TabStop = false;
            this.İstatislik.Text = "İstatislik";
            // 
            // BtnGelirGra
            // 
            this.BtnGelirGra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGelirGra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGelirGra.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.BtnGelirGra.Location = new System.Drawing.Point(24, 68);
            this.BtnGelirGra.Name = "BtnGelirGra";
            this.BtnGelirGra.Size = new System.Drawing.Size(115, 23);
            this.BtnGelirGra.TabIndex = 1;
            this.BtnGelirGra.Text = "Gelir Grafik";
            this.BtnGelirGra.UseVisualStyleBackColor = true;
            this.BtnGelirGra.Click += new System.EventHandler(this.BtnGelirGra_Click);
            // 
            // BtnGelır
            // 
            this.BtnGelır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGelır.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGelır.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.BtnGelır.Location = new System.Drawing.Point(24, 28);
            this.BtnGelır.Name = "BtnGelır";
            this.BtnGelır.Size = new System.Drawing.Size(115, 23);
            this.BtnGelır.TabIndex = 0;
            this.BtnGelır.Text = "Gelir Islem";
            this.BtnGelır.UseVisualStyleBackColor = true;
            this.BtnGelır.Click += new System.EventHandler(this.BtnGelır_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.ElemanIzın);
            this.groupBox4.Controls.Add(this.btnElemanEkle);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(257, 258);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 144);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eleman";
            // 
            // ElemanIzın
            // 
            this.ElemanIzın.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ElemanIzın.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ElemanIzın.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ElemanIzın.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.ElemanIzın.Location = new System.Drawing.Point(22, 68);
            this.ElemanIzın.Name = "ElemanIzın";
            this.ElemanIzın.Size = new System.Drawing.Size(126, 23);
            this.ElemanIzın.TabIndex = 0;
            this.ElemanIzın.Text = "Eleman İzin-Avans";
            this.ElemanIzın.UseVisualStyleBackColor = true;
            this.ElemanIzın.Click += new System.EventHandler(this.ElemanIzın_Click);
            // 
            // btnElemanEkle
            // 
            this.btnElemanEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnElemanEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElemanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElemanEkle.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElemanEkle.ForeColor = System.Drawing.Color.Black;
            this.btnElemanEkle.ImageKey = "(none)";
            this.btnElemanEkle.Location = new System.Drawing.Point(22, 27);
            this.btnElemanEkle.Name = "btnElemanEkle";
            this.btnElemanEkle.Size = new System.Drawing.Size(126, 24);
            this.btnElemanEkle.TabIndex = 0;
            this.btnElemanEkle.Text = "Eleman Ekle";
            this.btnElemanEkle.UseVisualStyleBackColor = true;
            this.btnElemanEkle.Click += new System.EventHandler(this.btnElemanEkle_Click);
            // 
            // randevularTableAdapter
            // 
            this.randevularTableAdapter.ClearBeforeFill = true;
            // 
            // emayDataDataSet1
            // 
            this.emayDataDataSet1.DataSetName = "EmayDataDataSet1";
            this.emayDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // denemeBindingSource
            // 
            this.denemeBindingSource.DataMember = "deneme";
            this.denemeBindingSource.DataSource = this.emayDataDataSet1;
            // 
            // denemeTableAdapter
            // 
            this.denemeTableAdapter.ClearBeforeFill = true;
            // 
            // randevularTableAdapter1
            // 
            this.randevularTableAdapter1.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.lbbgider);
            this.groupBox5.Controls.Add(this.lbbgelir);
            this.groupBox5.Controls.Add(this.lbbeleman);
            this.groupBox5.Controls.Add(this.lbbavans);
            this.groupBox5.Controls.Add(this.lbbmıssay);
            this.groupBox5.Controls.Add(this.lbbongorus);
            this.groupBox5.Controls.Add(this.lbbrandevu);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox5.Location = new System.Drawing.Point(16, 38);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(221, 364);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gün Rapor";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // lbbgider
            // 
            this.lbbgider.AutoSize = true;
            this.lbbgider.Font = new System.Drawing.Font("Jokerman", 12F);
            this.lbbgider.Location = new System.Drawing.Point(157, 274);
            this.lbbgider.Name = "lbbgider";
            this.lbbgider.Size = new System.Drawing.Size(21, 24);
            this.lbbgider.TabIndex = 1;
            this.lbbgider.Text = "0";
            this.lbbgider.Click += new System.EventHandler(this.lbbgelir_Click);
            // 
            // lbbgelir
            // 
            this.lbbgelir.AutoSize = true;
            this.lbbgelir.Font = new System.Drawing.Font("Jokerman", 12F);
            this.lbbgelir.Location = new System.Drawing.Point(157, 238);
            this.lbbgelir.Name = "lbbgelir";
            this.lbbgelir.Size = new System.Drawing.Size(21, 24);
            this.lbbgelir.TabIndex = 1;
            this.lbbgelir.Text = "0";
            this.lbbgelir.Click += new System.EventHandler(this.lbbgelir_Click);
            // 
            // lbbeleman
            // 
            this.lbbeleman.AutoSize = true;
            this.lbbeleman.Font = new System.Drawing.Font("Jokerman", 12F);
            this.lbbeleman.Location = new System.Drawing.Point(126, 190);
            this.lbbeleman.Name = "lbbeleman";
            this.lbbeleman.Size = new System.Drawing.Size(21, 24);
            this.lbbeleman.TabIndex = 1;
            this.lbbeleman.Text = "0";
            // 
            // lbbavans
            // 
            this.lbbavans.AutoSize = true;
            this.lbbavans.Font = new System.Drawing.Font("Jokerman", 12F);
            this.lbbavans.Location = new System.Drawing.Point(157, 149);
            this.lbbavans.Name = "lbbavans";
            this.lbbavans.Size = new System.Drawing.Size(21, 24);
            this.lbbavans.TabIndex = 1;
            this.lbbavans.Text = "0";
            // 
            // lbbmıssay
            // 
            this.lbbmıssay.AutoSize = true;
            this.lbbmıssay.Font = new System.Drawing.Font("Jokerman", 12F);
            this.lbbmıssay.Location = new System.Drawing.Point(157, 110);
            this.lbbmıssay.Name = "lbbmıssay";
            this.lbbmıssay.Size = new System.Drawing.Size(21, 24);
            this.lbbmıssay.TabIndex = 1;
            this.lbbmıssay.Text = "0";
            // 
            // lbbongorus
            // 
            this.lbbongorus.AutoSize = true;
            this.lbbongorus.Font = new System.Drawing.Font("Jokerman", 12F);
            this.lbbongorus.Location = new System.Drawing.Point(157, 71);
            this.lbbongorus.Name = "lbbongorus";
            this.lbbongorus.Size = new System.Drawing.Size(21, 24);
            this.lbbongorus.TabIndex = 1;
            this.lbbongorus.Text = "0";
            this.lbbongorus.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbbrandevu
            // 
            this.lbbrandevu.AutoSize = true;
            this.lbbrandevu.Font = new System.Drawing.Font("Jokerman", 12F);
            this.lbbrandevu.Location = new System.Drawing.Point(157, 35);
            this.lbbrandevu.Name = "lbbrandevu";
            this.lbbrandevu.Size = new System.Drawing.Size(21, 24);
            this.lbbrandevu.TabIndex = 1;
            this.lbbrandevu.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label7.Location = new System.Drawing.Point(11, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gider";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label6.Location = new System.Drawing.Point(11, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gelir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label5.Location = new System.Drawing.Point(11, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "İzinli Eleman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label4.Location = new System.Drawing.Point(7, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bugün Avans";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Misafir Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ön Görüşme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 12F);
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugun Randevu";
            // 
            // btntumrand
            // 
            this.btntumrand.BackColor = System.Drawing.Color.Transparent;
            this.btntumrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntumrand.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.btntumrand.Location = new System.Drawing.Point(971, 9);
            this.btntumrand.Name = "btntumrand";
            this.btntumrand.Size = new System.Drawing.Size(128, 23);
            this.btntumrand.TabIndex = 6;
            this.btntumrand.Text = "Tüm Randevular";
            this.btntumrand.UseVisualStyleBackColor = false;
            this.btntumrand.Click += new System.EventHandler(this.btntumrand_Click);
            // 
            // Btngrafık
            // 
            this.Btngrafık.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btngrafık.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.Btngrafık.Location = new System.Drawing.Point(18, 27);
            this.Btngrafık.Name = "Btngrafık";
            this.Btngrafık.Size = new System.Drawing.Size(117, 24);
            this.Btngrafık.TabIndex = 7;
            this.Btngrafık.Text = "Grafikler";
            this.Btngrafık.UseVisualStyleBackColor = true;
            this.Btngrafık.Click += new System.EventHandler(this.Btngrafık_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Btngrafık);
            this.groupBox3.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(682, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grafik";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.BtnGider);
            this.groupBox6.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(902, 258);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 144);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gider";
            // 
            // BtnGider
            // 
            this.BtnGider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGider.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.BtnGider.Location = new System.Drawing.Point(6, 27);
            this.BtnGider.Name = "BtnGider";
            this.BtnGider.Size = new System.Drawing.Size(125, 24);
            this.BtnGider.TabIndex = 0;
            this.BtnGider.Text = "Gider Ekle";
            this.BtnGider.UseVisualStyleBackColor = true;
            this.BtnGider.Click += new System.EventHandler(this.BtnGider_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.button1.Location = new System.Drawing.Point(7, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gider Grafik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YoneticiEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = global::EmayOto.Properties.Resources.arkaplan1;
            this.ClientSize = new System.Drawing.Size(1309, 491);
            this.Controls.Add(this.btntumrand);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.İstatislik);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "YoneticiEkran";
            this.Text = "YoneticiEkran";
            this.Load += new System.EventHandler(this.YoneticiEkran_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emayDataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevularBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emayDataDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.İstatislik.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emayDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRanguncel;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.GroupBox İstatislik;
        private System.Windows.Forms.Button BtnGelirGra;
        private System.Windows.Forms.Button BtnGelır;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ElemanIzın;
        private System.Windows.Forms.Button btnElemanEkle;
        private EmayDataDataSet emayDataDataSet;
        private System.Windows.Forms.BindingSource randevularBindingSource;
        private EmayDataDataSetTableAdapters.RandevularTableAdapter randevularTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EmayDataDataSet1 emayDataDataSet1;
        private System.Windows.Forms.BindingSource denemeBindingSource;
        private EmayDataDataSet1TableAdapters.denemeTableAdapter denemeTableAdapter;
        private EmayDataDataSet4 emayDataDataSet4;
        private System.Windows.Forms.BindingSource randevularBindingSource1;
        private EmayDataDataSet4TableAdapters.RandevularTableAdapter randevularTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nıtelıkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarıhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ontarıhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mıssayDataGridViewTextBoxColumn;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbbgelir;
        private System.Windows.Forms.Label lbbeleman;
        private System.Windows.Forms.Label lbbavans;
        private System.Windows.Forms.Label lbbmıssay;
        private System.Windows.Forms.Label lbbongorus;
        private System.Windows.Forms.Label lbbrandevu;
        private System.Windows.Forms.Button btntumrand;
        private System.Windows.Forms.Button Btngrafık;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbbgider;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGider;
    }
}