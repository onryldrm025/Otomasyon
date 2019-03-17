namespace EmayOto
{
    partial class Gider
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.giderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gidertarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nedeniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emayDataDataSet16 = new EmayOto.EmayDataDataSet16();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tutar = new System.Windows.Forms.Label();
            this.rcneden = new System.Windows.Forms.RichTextBox();
            this.msktutar = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.giderTableAdapter = new EmayOto.EmayDataDataSet16TableAdapters.GiderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emayDataDataSet16)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.giderDataGridViewTextBoxColumn,
            this.gidertarihDataGridViewTextBoxColumn,
            this.nedeniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // giderDataGridViewTextBoxColumn
            // 
            this.giderDataGridViewTextBoxColumn.DataPropertyName = "Gider";
            this.giderDataGridViewTextBoxColumn.HeaderText = "Gider";
            this.giderDataGridViewTextBoxColumn.Name = "giderDataGridViewTextBoxColumn";
            // 
            // gidertarihDataGridViewTextBoxColumn
            // 
            this.gidertarihDataGridViewTextBoxColumn.DataPropertyName = "Gidertarih";
            this.gidertarihDataGridViewTextBoxColumn.HeaderText = "Gidertarih";
            this.gidertarihDataGridViewTextBoxColumn.Name = "gidertarihDataGridViewTextBoxColumn";
            // 
            // nedeniDataGridViewTextBoxColumn
            // 
            this.nedeniDataGridViewTextBoxColumn.DataPropertyName = "Nedeni";
            this.nedeniDataGridViewTextBoxColumn.HeaderText = "Nedeni";
            this.nedeniDataGridViewTextBoxColumn.Name = "nedeniDataGridViewTextBoxColumn";
            this.nedeniDataGridViewTextBoxColumn.Width = 200;
            // 
            // giderBindingSource
            // 
            this.giderBindingSource.DataMember = "Gider";
            this.giderBindingSource.DataSource = this.emayDataDataSet16;
            // 
            // emayDataDataSet16
            // 
            this.emayDataDataSet16.DataSetName = "EmayDataDataSet16";
            this.emayDataDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(274, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Jokerman", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(79, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gider Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Tutar);
            this.groupBox3.Controls.Add(this.rcneden);
            this.groupBox3.Controls.Add(this.msktutar);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 189);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gider Ekleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 10.75F);
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nedeni";
            // 
            // Tutar
            // 
            this.Tutar.AutoSize = true;
            this.Tutar.Font = new System.Drawing.Font("Jokerman", 10.75F);
            this.Tutar.Location = new System.Drawing.Point(43, 35);
            this.Tutar.Name = "Tutar";
            this.Tutar.Size = new System.Drawing.Size(51, 22);
            this.Tutar.TabIndex = 7;
            this.Tutar.Text = "Tutar";
            // 
            // rcneden
            // 
            this.rcneden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rcneden.Location = new System.Drawing.Point(110, 61);
            this.rcneden.Name = "rcneden";
            this.rcneden.Size = new System.Drawing.Size(100, 54);
            this.rcneden.TabIndex = 6;
            this.rcneden.Text = "";
            // 
            // msktutar
            // 
            this.msktutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.msktutar.Location = new System.Drawing.Point(110, 35);
            this.msktutar.Mask = "0000";
            this.msktutar.Name = "msktutar";
            this.msktutar.Size = new System.Drawing.Size(100, 20);
            this.msktutar.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // giderTableAdapter
            // 
            this.giderTableAdapter.ClearBeforeFill = true;
            // 
            // Gider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmayOto.Properties.Resources.arkaplan2;
            this.ClientSize = new System.Drawing.Size(725, 373);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Gider";
            this.Text = "Gider";
            this.Load += new System.EventHandler(this.Gider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emayDataDataSet16)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tutar;
        private System.Windows.Forms.RichTextBox rcneden;
        private System.Windows.Forms.MaskedTextBox msktutar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private EmayDataDataSet16 emayDataDataSet16;
        private System.Windows.Forms.BindingSource giderBindingSource;
        private EmayDataDataSet16TableAdapters.GiderTableAdapter giderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn giderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gidertarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nedeniDataGridViewTextBoxColumn;
    }
}