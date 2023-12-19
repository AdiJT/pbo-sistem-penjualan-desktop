namespace WindowsFormsAppPBO
{
    partial class FormMain
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
            System.Windows.Forms.Label labelJudul;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuData = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konsumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.dateTimePickerTanggalTransaksi = new System.Windows.Forms.DateTimePicker();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelHasilCari = new System.Windows.Forms.Label();
            this.textBoxKodeBarang = new System.Windows.Forms.TextBox();
            this.labelKodeBarang = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.labelDiskon = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.comboBoxSatuan = new System.Windows.Forms.ComboBox();
            this.labelKodeSatuan = new System.Windows.Forms.Label();
            this.textBoxNamaKonsumen = new System.Windows.Forms.TextBox();
            this.labelNamaKonsumen = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            labelJudul = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            labelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            labelJudul.Location = new System.Drawing.Point(0, 24);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new System.Drawing.Size(878, 59);
            labelJudul.TabIndex = 8;
            labelJudul.Text = "Aplikasi Kasir";
            labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataToolStripMenuData
            // 
            this.dataToolStripMenuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem,
            this.kategoriToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.satuanToolStripMenuItem,
            this.konsumenToolStripMenuItem});
            this.dataToolStripMenuData.Name = "dataToolStripMenuData";
            this.dataToolStripMenuData.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuData.Text = "Data";
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.barangToolStripMenuItem.Text = "Barang";
            this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            this.kategoriToolStripMenuItem.Click += new System.EventHandler(this.kategoriToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // satuanToolStripMenuItem
            // 
            this.satuanToolStripMenuItem.Name = "satuanToolStripMenuItem";
            this.satuanToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.satuanToolStripMenuItem.Text = "Satuan";
            this.satuanToolStripMenuItem.Click += new System.EventHandler(this.satuanToolStripMenuItem_Click);
            // 
            // konsumenToolStripMenuItem
            // 
            this.konsumenToolStripMenuItem.Name = "konsumenToolStripMenuItem";
            this.konsumenToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.konsumenToolStripMenuItem.Text = "Konsumen";
            this.konsumenToolStripMenuItem.Click += new System.EventHandler(this.konsumenToolStripMenuItem_Click);
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSubTotal.Location = new System.Drawing.Point(61, 12);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(78, 17);
            this.labelSubTotal.TabIndex = 0;
            this.labelSubTotal.Text = "Sub Total";
            // 
            // dateTimePickerTanggalTransaksi
            // 
            this.dateTimePickerTanggalTransaksi.Location = new System.Drawing.Point(95, 14);
            this.dateTimePickerTanggalTransaksi.Name = "dateTimePickerTanggalTransaksi";
            this.dateTimePickerTanggalTransaksi.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerTanggalTransaksi.TabIndex = 7;
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(5, 18);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(46, 13);
            this.labelTanggal.TabIndex = 6;
            this.labelTanggal.Text = "Tanggal";
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Enabled = false;
            this.textBoxJumlah.Location = new System.Drawing.Point(636, 53);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(201, 20);
            this.textBoxJumlah.TabIndex = 5;
            this.textBoxJumlah.TextChanged += new System.EventHandler(this.textBoxJumlah_TextChanged);
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Location = new System.Drawing.Point(540, 57);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(40, 13);
            this.labelJumlah.TabIndex = 4;
            this.labelJumlah.Text = "Jumlah";
            // 
            // labelHasilCari
            // 
            this.labelHasilCari.AutoSize = true;
            this.labelHasilCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHasilCari.Location = new System.Drawing.Point(3, 78);
            this.labelHasilCari.Name = "labelHasilCari";
            this.labelHasilCari.Size = new System.Drawing.Size(197, 20);
            this.labelHasilCari.TabIndex = 3;
            this.labelHasilCari.Text = "Hasil Pencarian Barang";
            // 
            // textBoxKodeBarang
            // 
            this.textBoxKodeBarang.Location = new System.Drawing.Point(95, 53);
            this.textBoxKodeBarang.Name = "textBoxKodeBarang";
            this.textBoxKodeBarang.Size = new System.Drawing.Size(105, 20);
            this.textBoxKodeBarang.TabIndex = 2;
            this.textBoxKodeBarang.TextChanged += new System.EventHandler(this.textBoxKodeBarang_TextChanged);
            // 
            // labelKodeBarang
            // 
            this.labelKodeBarang.AutoSize = true;
            this.labelKodeBarang.Location = new System.Drawing.Point(5, 57);
            this.labelKodeBarang.Name = "labelKodeBarang";
            this.labelKodeBarang.Size = new System.Drawing.Size(69, 13);
            this.labelKodeBarang.TabIndex = 1;
            this.labelKodeBarang.Text = "Kode Barang";
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotal.ForeColor = System.Drawing.Color.Lime;
            this.labelTotal.Location = new System.Drawing.Point(102, 60);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(188, 25);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Rp0,00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.Location = new System.Drawing.Point(64, 37);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(231, 20);
            this.textBoxDiskon.TabIndex = 4;
            this.textBoxDiskon.TextChanged += new System.EventHandler(this.textBoxDiskon_TextChanged);
            this.textBoxDiskon.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDiskon_Validating);
            // 
            // labelDiskon
            // 
            this.labelDiskon.AutoSize = true;
            this.labelDiskon.Location = new System.Drawing.Point(5, 40);
            this.labelDiskon.Name = "labelDiskon";
            this.labelDiskon.Size = new System.Drawing.Size(40, 13);
            this.labelDiskon.TabIndex = 3;
            this.labelDiskon.Text = "Diskon";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.labelTotal);
            this.panel2.Controls.Add(this.textBoxDiskon);
            this.panel2.Controls.Add(this.labelDiskon);
            this.panel2.Controls.Add(this.labelSubTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(555, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 94);
            this.panel2.TabIndex = 4;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Enabled = false;
            this.buttonTambah.Location = new System.Drawing.Point(418, 48);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(105, 30);
            this.buttonTambah.TabIndex = 0;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonClear);
            this.panel3.Controls.Add(this.buttonHapus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(95, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 94);
            this.panel3.TabIndex = 5;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(260, 26);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(128, 41);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Enabled = false;
            this.buttonHapus.Location = new System.Drawing.Point(80, 27);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(128, 41);
            this.buttonHapus.TabIndex = 0;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Visible = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 94);
            this.panel1.TabIndex = 10;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSimpan.Location = new System.Drawing.Point(0, 0);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(95, 94);
            this.buttonSimpan.TabIndex = 3;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAtas.Controls.Add(this.comboBoxSatuan);
            this.panelAtas.Controls.Add(this.labelKodeSatuan);
            this.panelAtas.Controls.Add(this.textBoxNamaKonsumen);
            this.panelAtas.Controls.Add(this.labelNamaKonsumen);
            this.panelAtas.Controls.Add(this.dateTimePickerTanggalTransaksi);
            this.panelAtas.Controls.Add(this.labelTanggal);
            this.panelAtas.Controls.Add(this.textBoxJumlah);
            this.panelAtas.Controls.Add(this.labelJumlah);
            this.panelAtas.Controls.Add(this.labelHasilCari);
            this.panelAtas.Controls.Add(this.textBoxKodeBarang);
            this.panelAtas.Controls.Add(this.labelKodeBarang);
            this.panelAtas.Controls.Add(this.buttonTambah);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 83);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(878, 106);
            this.panelAtas.TabIndex = 9;
            // 
            // comboBoxSatuan
            // 
            this.comboBoxSatuan.FormattingEnabled = true;
            this.comboBoxSatuan.Location = new System.Drawing.Point(285, 53);
            this.comboBoxSatuan.Name = "comboBoxSatuan";
            this.comboBoxSatuan.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSatuan.TabIndex = 11;
            this.comboBoxSatuan.SelectedIndexChanged += new System.EventHandler(this.comboBoxSatuan_SelectedIndexChanged);
            // 
            // labelKodeSatuan
            // 
            this.labelKodeSatuan.AutoSize = true;
            this.labelKodeSatuan.Location = new System.Drawing.Point(210, 57);
            this.labelKodeSatuan.Name = "labelKodeSatuan";
            this.labelKodeSatuan.Size = new System.Drawing.Size(69, 13);
            this.labelKodeSatuan.TabIndex = 10;
            this.labelKodeSatuan.Text = "Kode Satuan";
            // 
            // textBoxNamaKonsumen
            // 
            this.textBoxNamaKonsumen.Location = new System.Drawing.Point(636, 14);
            this.textBoxNamaKonsumen.Name = "textBoxNamaKonsumen";
            this.textBoxNamaKonsumen.Size = new System.Drawing.Size(201, 20);
            this.textBoxNamaKonsumen.TabIndex = 9;
            this.textBoxNamaKonsumen.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNamaKonsumen_Validating);
            // 
            // labelNamaKonsumen
            // 
            this.labelNamaKonsumen.AutoSize = true;
            this.labelNamaKonsumen.Location = new System.Drawing.Point(540, 18);
            this.labelNamaKonsumen.Name = "labelNamaKonsumen";
            this.labelNamaKonsumen.Size = new System.Drawing.Size(88, 13);
            this.labelNamaKonsumen.TabIndex = 8;
            this.labelNamaKonsumen.Text = "Nama Konsumen";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 189);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(878, 171);
            this.dataGridViewData.TabIndex = 11;
            this.dataGridViewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellClick);
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(878, 454);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(labelJudul);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuData;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konsumenToolStripMenuItem;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalTransaksi;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelHasilCari;
        private System.Windows.Forms.TextBox textBoxKodeBarang;
        private System.Windows.Forms.Label labelKodeBarang;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.Label labelDiskon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.TextBox textBoxNamaKonsumen;
        private System.Windows.Forms.Label labelNamaKonsumen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelKodeSatuan;
        private System.Windows.Forms.ComboBox comboBoxSatuan;
        private System.Windows.Forms.Button buttonClear;
    }
}

