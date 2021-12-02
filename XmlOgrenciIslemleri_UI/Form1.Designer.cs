
namespace Ornek3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDTarihi = new System.Windows.Forms.Label();
            this.lblSinifSecimi = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dateTimePickerDTarihi = new System.Windows.Forms.DateTimePicker();
            this.listBoxASinifi = new System.Windows.Forms.ListBox();
            this.listBoxBSinifi = new System.Windows.Forms.ListBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.cmbBoxSinifSecimi = new System.Windows.Forms.ComboBox();
            this.btnSagaGonder = new System.Windows.Forms.Button();
            this.btnHepsiniSagaGonder = new System.Windows.Forms.Button();
            this.btnSolaGonder = new System.Windows.Forms.Button();
            this.btnHepsiniSolaGonder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLIleDisaiıAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLIleIceriVeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cıkısToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxOgrenciBilgileri = new System.Windows.Forms.GroupBox();
            this.checkBoxSecmeliDers = new System.Windows.Forms.CheckBox();
            this.groupBoxSecmeliDersler = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBoxOgrenciBilgileri.SuspendLayout();
            this.groupBoxSecmeliDersler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(6, 27);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 20);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(6, 53);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(53, 20);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblDTarihi
            // 
            this.lblDTarihi.AutoSize = true;
            this.lblDTarihi.Location = new System.Drawing.Point(0, 90);
            this.lblDTarihi.Name = "lblDTarihi";
            this.lblDTarihi.Size = new System.Drawing.Size(101, 20);
            this.lblDTarihi.TabIndex = 2;
            this.lblDTarihi.Text = "Doğum Tarihi:";
            // 
            // lblSinifSecimi
            // 
            this.lblSinifSecimi.AutoSize = true;
            this.lblSinifSecimi.Location = new System.Drawing.Point(6, 139);
            this.lblSinifSecimi.Name = "lblSinifSecimi";
            this.lblSinifSecimi.Size = new System.Drawing.Size(89, 20);
            this.lblSinifSecimi.TabIndex = 3;
            this.lblSinifSecimi.Text = "Sınıf Seçimi:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(107, 50);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(250, 27);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(107, 20);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(250, 27);
            this.txtAd.TabIndex = 0;
            // 
            // dateTimePickerDTarihi
            // 
            this.dateTimePickerDTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDTarihi.Location = new System.Drawing.Point(107, 85);
            this.dateTimePickerDTarihi.Name = "dateTimePickerDTarihi";
            this.dateTimePickerDTarihi.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerDTarihi.TabIndex = 3;
            // 
            // listBoxASinifi
            // 
            this.listBoxASinifi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxASinifi.FormattingEnabled = true;
            this.listBoxASinifi.ItemHeight = 20;
            this.listBoxASinifi.Location = new System.Drawing.Point(66, 274);
            this.listBoxASinifi.Name = "listBoxASinifi";
            this.listBoxASinifi.Size = new System.Drawing.Size(326, 164);
            this.listBoxASinifi.TabIndex = 8;
            // 
            // listBoxBSinifi
            // 
            this.listBoxBSinifi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxBSinifi.FormattingEnabled = true;
            this.listBoxBSinifi.ItemHeight = 20;
            this.listBoxBSinifi.Location = new System.Drawing.Point(523, 274);
            this.listBoxBSinifi.Name = "listBoxBSinifi";
            this.listBoxBSinifi.Size = new System.Drawing.Size(349, 164);
            this.listBoxBSinifi.TabIndex = 9;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnOgrenciEkle.Location = new System.Drawing.Point(368, 20);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(129, 144);
            this.btnOgrenciEkle.TabIndex = 10;
            this.btnOgrenciEkle.Text = "Ogrenci Ekle:";
            this.btnOgrenciEkle.UseVisualStyleBackColor = false;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // cmbBoxSinifSecimi
            // 
            this.cmbBoxSinifSecimi.FormattingEnabled = true;
            this.cmbBoxSinifSecimi.Location = new System.Drawing.Point(101, 136);
            this.cmbBoxSinifSecimi.Name = "cmbBoxSinifSecimi";
            this.cmbBoxSinifSecimi.Size = new System.Drawing.Size(250, 28);
            this.cmbBoxSinifSecimi.TabIndex = 11;
            this.cmbBoxSinifSecimi.Text = "Sınıfınızı Seçiniz:";
            // 
            // btnSagaGonder
            // 
            this.btnSagaGonder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSagaGonder.Location = new System.Drawing.Point(412, 281);
            this.btnSagaGonder.Name = "btnSagaGonder";
            this.btnSagaGonder.Size = new System.Drawing.Size(94, 29);
            this.btnSagaGonder.TabIndex = 12;
            this.btnSagaGonder.Text = ">";
            this.btnSagaGonder.UseVisualStyleBackColor = false;
            this.btnSagaGonder.Click += new System.EventHandler(this.btnSagaGonder_Click);
            // 
            // btnHepsiniSagaGonder
            // 
            this.btnHepsiniSagaGonder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHepsiniSagaGonder.Location = new System.Drawing.Point(412, 316);
            this.btnHepsiniSagaGonder.Name = "btnHepsiniSagaGonder";
            this.btnHepsiniSagaGonder.Size = new System.Drawing.Size(94, 29);
            this.btnHepsiniSagaGonder.TabIndex = 13;
            this.btnHepsiniSagaGonder.Text = ">>";
            this.btnHepsiniSagaGonder.UseVisualStyleBackColor = false;
            this.btnHepsiniSagaGonder.Click += new System.EventHandler(this.btnHepsiniSagaGonder_Click);
            // 
            // btnSolaGonder
            // 
            this.btnSolaGonder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSolaGonder.Location = new System.Drawing.Point(412, 351);
            this.btnSolaGonder.Name = "btnSolaGonder";
            this.btnSolaGonder.Size = new System.Drawing.Size(94, 29);
            this.btnSolaGonder.TabIndex = 14;
            this.btnSolaGonder.Text = "<";
            this.btnSolaGonder.UseVisualStyleBackColor = false;
            this.btnSolaGonder.Click += new System.EventHandler(this.btnSolaGonder_Click);
            // 
            // btnHepsiniSolaGonder
            // 
            this.btnHepsiniSolaGonder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHepsiniSolaGonder.Location = new System.Drawing.Point(412, 397);
            this.btnHepsiniSolaGonder.Name = "btnHepsiniSolaGonder";
            this.btnHepsiniSolaGonder.Size = new System.Drawing.Size(94, 29);
            this.btnHepsiniSolaGonder.TabIndex = 15;
            this.btnHepsiniSolaGonder.Text = "<<";
            this.btnHepsiniSolaGonder.UseVisualStyleBackColor = false;
            this.btnHepsiniSolaGonder.Click += new System.EventHandler(this.btnHepsiniSolaGonder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemlerToolStripMenuItem,
            this.cıkısToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XMLToolStripMenuItem});
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.islemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // XMLToolStripMenuItem
            // 
            this.XMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XMLIleDisaiıAktarToolStripMenuItem,
            this.XMLIleIceriVeriAlToolStripMenuItem});
            this.XMLToolStripMenuItem.Name = "XMLToolStripMenuItem";
            this.XMLToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.XMLToolStripMenuItem.Text = "XML";
            // 
            // XMLIleDisaiıAktarToolStripMenuItem
            // 
            this.XMLIleDisaiıAktarToolStripMenuItem.Name = "XMLIleDisaiıAktarToolStripMenuItem";
            this.XMLIleDisaiıAktarToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.XMLIleDisaiıAktarToolStripMenuItem.Text = "XML ile dışarı aktar";
            this.XMLIleDisaiıAktarToolStripMenuItem.Click += new System.EventHandler(this.XMLIleDisaiıAktarToolStripMenuItem_Click);
            // 
            // XMLIleIceriVeriAlToolStripMenuItem
            // 
            this.XMLIleIceriVeriAlToolStripMenuItem.Name = "XMLIleIceriVeriAlToolStripMenuItem";
            this.XMLIleIceriVeriAlToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.XMLIleIceriVeriAlToolStripMenuItem.Text = "XML ile içeri veri al";
            this.XMLIleIceriVeriAlToolStripMenuItem.Click += new System.EventHandler(this.XMLIleIceriVeriAlToolStripMenuItem_Click);
            // 
            // cıkısToolStripMenuItem
            // 
            this.cıkısToolStripMenuItem.Name = "cıkısToolStripMenuItem";
            this.cıkısToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.cıkısToolStripMenuItem.Text = "Çıkış";
            this.cıkısToolStripMenuItem.Click += new System.EventHandler(this.cıkısToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxOgrenciBilgileri
            // 
            this.groupBoxOgrenciBilgileri.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxOgrenciBilgileri.Controls.Add(this.lblAd);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.checkBoxSecmeliDers);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.txtAd);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.lblSoyad);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.txtSoyad);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.lblDTarihi);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.dateTimePickerDTarihi);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.btnOgrenciEkle);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.cmbBoxSinifSecimi);
            this.groupBoxOgrenciBilgileri.Controls.Add(this.lblSinifSecimi);
            this.groupBoxOgrenciBilgileri.Location = new System.Drawing.Point(66, 37);
            this.groupBoxOgrenciBilgileri.Name = "groupBoxOgrenciBilgileri";
            this.groupBoxOgrenciBilgileri.Size = new System.Drawing.Size(519, 212);
            this.groupBoxOgrenciBilgileri.TabIndex = 17;
            this.groupBoxOgrenciBilgileri.TabStop = false;
            this.groupBoxOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // checkBoxSecmeliDers
            // 
            this.checkBoxSecmeliDers.AutoSize = true;
            this.checkBoxSecmeliDers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkBoxSecmeliDers.Location = new System.Drawing.Point(6, 182);
            this.checkBoxSecmeliDers.Name = "checkBoxSecmeliDers";
            this.checkBoxSecmeliDers.Size = new System.Drawing.Size(272, 24);
            this.checkBoxSecmeliDers.TabIndex = 0;
            this.checkBoxSecmeliDers.Text = "Seçmeli ders almak istiyor musunuz?";
            this.checkBoxSecmeliDers.UseVisualStyleBackColor = false;
            this.checkBoxSecmeliDers.CheckedChanged += new System.EventHandler(this.checkBoxSecmeliDers_CheckedChanged);
            // 
            // groupBoxSecmeliDersler
            // 
            this.groupBoxSecmeliDersler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxSecmeliDersler.Controls.Add(this.checkedListBox1);
            this.groupBoxSecmeliDersler.Location = new System.Drawing.Point(622, 45);
            this.groupBoxSecmeliDersler.Name = "groupBoxSecmeliDersler";
            this.groupBoxSecmeliDersler.Size = new System.Drawing.Size(250, 204);
            this.groupBoxSecmeliDersler.TabIndex = 12;
            this.groupBoxSecmeliDersler.TabStop = false;
            this.groupBoxSecmeliDersler.Text = "Seçmeli Dersler";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "İnsan Kaynakları",
            "Toplum Hizmeti",
            "Halk Sağlığı",
            "Evrim Teorisi"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 42);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(214, 114);
            this.checkedListBox1.TabIndex = 18;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 491);
            this.Controls.Add(this.groupBoxSecmeliDersler);
            this.Controls.Add(this.groupBoxOgrenciBilgileri);
            this.Controls.Add(this.btnHepsiniSolaGonder);
            this.Controls.Add(this.btnSolaGonder);
            this.Controls.Add(this.btnHepsiniSagaGonder);
            this.Controls.Add(this.btnSagaGonder);
            this.Controls.Add(this.listBoxBSinifi);
            this.Controls.Add(this.listBoxASinifi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxOgrenciBilgileri.ResumeLayout(false);
            this.groupBoxOgrenciBilgileri.PerformLayout();
            this.groupBoxSecmeliDersler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDTarihi;
        private System.Windows.Forms.Label lblSinifSecimi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDTarihi;
        private System.Windows.Forms.ListBox listBoxASinifi;
        private System.Windows.Forms.ListBox listBoxBSinifi;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.ComboBox cmbBoxSinifSecimi;
        private System.Windows.Forms.Button btnSagaGonder;
        private System.Windows.Forms.Button btnHepsiniSagaGonder;
        private System.Windows.Forms.Button btnSolaGonder;
        private System.Windows.Forms.Button btnHepsiniSolaGonder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem islemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cıkısToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxOgrenciBilgileri;
        private System.Windows.Forms.CheckBox checkBoxSecmeliDers;
        private System.Windows.Forms.GroupBox groupBoxSecmeliDersler;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripMenuItem XMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLIleDisaiıAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLIleIceriVeriAlToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

