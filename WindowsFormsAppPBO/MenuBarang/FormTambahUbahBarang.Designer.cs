namespace WindowsFormsAppPBO.MenuBarang
{
    partial class FormTambahUbahBarang
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
            this.labelJudul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.panelBarang = new System.Windows.Forms.Panel();
            this.labelKategori = new System.Windows.Forms.Label();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.textBoxKodeBarang = new System.Windows.Forms.TextBox();
            this.labelKodeBarang = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.labelStok = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxHargaBarang = new System.Windows.Forms.TextBox();
            this.labelHargaBarang = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelKodeSatuan = new System.Windows.Forms.Label();
            this.comboBoxSatuan = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelBarang.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelJudul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelJudul.Location = new System.Drawing.Point(0, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(800, 45);
            this.labelJudul.TabIndex = 0;
            this.labelJudul.Text = "Barang";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Controls.Add(this.buttonKembali);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 9;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSimpan.Location = new System.Drawing.Point(0, 0);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(95, 62);
            this.buttonSimpan.TabIndex = 4;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonKembali.Location = new System.Drawing.Point(705, 0);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(95, 62);
            this.buttonKembali.TabIndex = 3;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // panelBarang
            // 
            this.panelBarang.Controls.Add(this.labelKategori);
            this.panelBarang.Controls.Add(this.comboBoxKategori);
            this.panelBarang.Controls.Add(this.textBoxNamaBarang);
            this.panelBarang.Controls.Add(this.labelNamaBarang);
            this.panelBarang.Controls.Add(this.textBoxKodeBarang);
            this.panelBarang.Controls.Add(this.labelKodeBarang);
            this.panelBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarang.Location = new System.Drawing.Point(0, 45);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Size = new System.Drawing.Size(800, 120);
            this.panelBarang.TabIndex = 14;
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(215, 82);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(74, 13);
            this.labelKategori.TabIndex = 17;
            this.labelKategori.Text = "Kode Kategori";
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(303, 79);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(281, 21);
            this.comboBoxKategori.TabIndex = 16;
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Location = new System.Drawing.Point(303, 50);
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(281, 20);
            this.textBoxNamaBarang.TabIndex = 15;
            this.textBoxNamaBarang.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNamaBarang_Validating);
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Location = new System.Drawing.Point(215, 53);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(72, 13);
            this.labelNamaBarang.TabIndex = 14;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // textBoxKodeBarang
            // 
            this.textBoxKodeBarang.Location = new System.Drawing.Point(304, 21);
            this.textBoxKodeBarang.Name = "textBoxKodeBarang";
            this.textBoxKodeBarang.Size = new System.Drawing.Size(281, 20);
            this.textBoxKodeBarang.TabIndex = 13;
            this.textBoxKodeBarang.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKodeBarang_Validating);
            // 
            // labelKodeBarang
            // 
            this.labelKodeBarang.AutoSize = true;
            this.labelKodeBarang.Location = new System.Drawing.Point(215, 24);
            this.labelKodeBarang.Name = "labelKodeBarang";
            this.labelKodeBarang.Size = new System.Drawing.Size(69, 13);
            this.labelKodeBarang.TabIndex = 12;
            this.labelKodeBarang.Text = "Kode Barang";
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.buttonTambah);
            this.panelDetail.Controls.Add(this.panel7);
            this.panelDetail.Controls.Add(this.panel6);
            this.panelDetail.Controls.Add(this.panel5);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetail.Location = new System.Drawing.Point(0, 165);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(800, 41);
            this.panelDetail.TabIndex = 15;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTambah.Location = new System.Drawing.Point(723, 0);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(77, 41);
            this.buttonTambah.TabIndex = 21;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBoxStok);
            this.panel7.Controls.Add(this.labelStok);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(493, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(230, 41);
            this.panel7.TabIndex = 20;
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(37, 10);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(153, 20);
            this.textBoxStok.TabIndex = 19;
            this.textBoxStok.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxStok_Validating);
            // 
            // labelStok
            // 
            this.labelStok.AutoSize = true;
            this.labelStok.Location = new System.Drawing.Point(8, 14);
            this.labelStok.Name = "labelStok";
            this.labelStok.Size = new System.Drawing.Size(29, 13);
            this.labelStok.TabIndex = 18;
            this.labelStok.Text = "Stok";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxHargaBarang);
            this.panel6.Controls.Add(this.labelHargaBarang);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(246, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(247, 41);
            this.panel6.TabIndex = 19;
            // 
            // textBoxHargaBarang
            // 
            this.textBoxHargaBarang.Location = new System.Drawing.Point(52, 10);
            this.textBoxHargaBarang.Name = "textBoxHargaBarang";
            this.textBoxHargaBarang.Size = new System.Drawing.Size(153, 20);
            this.textBoxHargaBarang.TabIndex = 17;
            this.textBoxHargaBarang.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHargaBarang_Validating);
            // 
            // labelHargaBarang
            // 
            this.labelHargaBarang.AutoSize = true;
            this.labelHargaBarang.Location = new System.Drawing.Point(13, 14);
            this.labelHargaBarang.Name = "labelHargaBarang";
            this.labelHargaBarang.Size = new System.Drawing.Size(36, 13);
            this.labelHargaBarang.TabIndex = 16;
            this.labelHargaBarang.Text = "Harga";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelKodeSatuan);
            this.panel5.Controls.Add(this.comboBoxSatuan);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 41);
            this.panel5.TabIndex = 18;
            // 
            // labelKodeSatuan
            // 
            this.labelKodeSatuan.AutoSize = true;
            this.labelKodeSatuan.Location = new System.Drawing.Point(9, 14);
            this.labelKodeSatuan.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.labelKodeSatuan.Name = "labelKodeSatuan";
            this.labelKodeSatuan.Size = new System.Drawing.Size(69, 13);
            this.labelKodeSatuan.TabIndex = 21;
            this.labelKodeSatuan.Text = "Kode Satuan";
            // 
            // comboBoxSatuan
            // 
            this.comboBoxSatuan.FormattingEnabled = true;
            this.comboBoxSatuan.Location = new System.Drawing.Point(81, 10);
            this.comboBoxSatuan.Name = "comboBoxSatuan";
            this.comboBoxSatuan.Size = new System.Drawing.Size(114, 21);
            this.comboBoxSatuan.TabIndex = 20;
            this.comboBoxSatuan.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSatuan_Validating);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonHapus);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 346);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(280, 0, 280, 0);
            this.panel4.Size = new System.Drawing.Size(800, 42);
            this.panel4.TabIndex = 16;
            // 
            // buttonHapus
            // 
            this.buttonHapus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHapus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHapus.Enabled = false;
            this.buttonHapus.Location = new System.Drawing.Point(280, 0);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(240, 42);
            this.buttonHapus.TabIndex = 1;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 206);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetail.Size = new System.Drawing.Size(800, 140);
            this.dataGridViewDetail.TabIndex = 17;
            this.dataGridViewDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetail_CellClick);
            this.dataGridViewDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetail_CellClick);
            // 
            // FormTambahUbahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDetail);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelBarang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormTambahUbahBarang";
            this.Text = "FormTambahBarang";
            this.Shown += new System.EventHandler(this.FormTambahUbahBarang_Shown);
            this.panel1.ResumeLayout(false);
            this.panelBarang.ResumeLayout(false);
            this.panelBarang.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Panel panelBarang;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.TextBox textBoxKodeBarang;
        private System.Windows.Forms.Label labelKodeBarang;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelKodeSatuan;
        private System.Windows.Forms.ComboBox comboBoxSatuan;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxHargaBarang;
        private System.Windows.Forms.Label labelHargaBarang;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Label labelStok;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
    }
}