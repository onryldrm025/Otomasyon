namespace EmayOto
{
    partial class Yenirandevu
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
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.cbxsalon = new System.Windows.Forms.ComboBox();
            this.cbxnitelik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxmissay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dttarıh = new System.Windows.Forms.DateTimePicker();
            this.dttontarıh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Location = new System.Drawing.Point(192, 28);
            this.txtAdsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(148, 24);
            this.txtAdsoyad.TabIndex = 0;
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
            this.cbxsalon.Location = new System.Drawing.Point(192, 115);
            this.cbxsalon.Margin = new System.Windows.Forms.Padding(4);
            this.cbxsalon.Name = "cbxsalon";
            this.cbxsalon.Size = new System.Drawing.Size(180, 26);
            this.cbxsalon.TabIndex = 2;
            this.cbxsalon.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxnitelik
            // 
            this.cbxnitelik.FormattingEnabled = true;
            this.cbxnitelik.Items.AddRange(new object[] {
            "DÜĞÜN",
            "KINA",
            "SÜNNET"});
            this.cbxnitelik.Location = new System.Drawing.Point(192, 167);
            this.cbxnitelik.Margin = new System.Windows.Forms.Padding(4);
            this.cbxnitelik.Name = "cbxnitelik";
            this.cbxnitelik.Size = new System.Drawing.Size(180, 26);
            this.cbxnitelik.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jokerman", 10F);
            this.label1.Location = new System.Drawing.Point(93, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı Soyadı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Jokerman", 10F);
            this.label2.Location = new System.Drawing.Point(114, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Jokerman", 10F);
            this.label3.Location = new System.Drawing.Point(128, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Jokerman", 10F);
            this.label4.Location = new System.Drawing.Point(120, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Niteliği :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Jokerman", 10F);
            this.label5.Location = new System.Drawing.Point(130, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tarih :";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(192, 70);
            this.mskTel.Margin = new System.Windows.Forms.Padding(4);
            this.mskTel.Mask = "(000) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(148, 24);
            this.mskTel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Jokerman", 10F);
            this.label6.Location = new System.Drawing.Point(34, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ön Görüşme Tarihi :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Jokerman", 11F);
            this.button1.Location = new System.Drawing.Point(237, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            "10"});
            this.cbxmissay.Location = new System.Drawing.Point(192, 297);
            this.cbxmissay.Margin = new System.Windows.Forms.Padding(4);
            this.cbxmissay.Name = "cbxmissay";
            this.cbxmissay.Size = new System.Drawing.Size(180, 26);
            this.cbxmissay.TabIndex = 6;
            this.cbxmissay.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Jokerman", 10F);
            this.label7.Location = new System.Drawing.Point(71, 305);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Misafir Sayısı :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dttarıh
            // 
            this.dttarıh.CustomFormat = "dd.MM.yyyy";
            this.dttarıh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttarıh.Location = new System.Drawing.Point(192, 218);
            this.dttarıh.Name = "dttarıh";
            this.dttarıh.Size = new System.Drawing.Size(180, 24);
            this.dttarıh.TabIndex = 9;
            this.dttarıh.ValueChanged += new System.EventHandler(this.dttarıh_ValueChanged);
            // 
            // dttontarıh
            // 
            this.dttontarıh.CustomFormat = "dd.MM.yyy";
            this.dttontarıh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttontarıh.Location = new System.Drawing.Point(192, 258);
            this.dttontarıh.Name = "dttontarıh";
            this.dttontarıh.Size = new System.Drawing.Size(180, 24);
            this.dttontarıh.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Jokerman", 11F);
            this.label8.Location = new System.Drawing.Point(2, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Randevu Ekle";
            // 
            // Yenirandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::EmayOto.Properties.Resources.arkaplan2;
            this.ClientSize = new System.Drawing.Size(558, 381);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dttontarıh);
            this.Controls.Add(this.dttarıh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxnitelik);
            this.Controls.Add(this.cbxmissay);
            this.Controls.Add(this.cbxsalon);
            this.Controls.Add(this.txtAdsoyad);
            this.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Yenirandevu";
            this.Text = "Yenirandevu";
            this.Load += new System.EventHandler(this.Yenirandevu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.ComboBox cbxsalon;
        private System.Windows.Forms.ComboBox cbxnitelik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxmissay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dttarıh;
        private System.Windows.Forms.DateTimePicker dttontarıh;
        private System.Windows.Forms.Label label8;
    }
}