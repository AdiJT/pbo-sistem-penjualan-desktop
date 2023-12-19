namespace WindowsFormsAppPBO.MenuTransaksi
{
    partial class FormTambahUbahTransaksi
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
            System.Windows.Forms.Label labelJudul;
            this.panelAtas = new System.Windows.Forms.Panel();
            this.dateTimePickerTanggalTransaksi = new System.Windows.Forms.DateTimePicker();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelHasilCari = new System.Windows.Forms.Label();
            this.textBoxKodeBarang = new System.Windows.Forms.TextBox();
            this.labelKodeBarang = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.labelDiskon = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            labelJudul = new System.Windows.Forms.Label();
            this.panelAtas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            labelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            labelJudul.Location = new System.Drawing.Point(0, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new System.Drawing.Size(800, 59);
            labelJudul.TabIndex = 4;
            labelJudul.Text = "Transaksi";
            labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAtas.Controls.Add(this.dateTimePickerTanggalTransaksi);
            this.panelAtas.Controls.Add(this.labelTanggal);
            this.panelAtas.Controls.Add(this.textBoxJumlah);
            this.panelAtas.Controls.Add(this.labelJumlah);
            this.panelAtas.Controls.Add(this.labelHasilCari);
            this.panelAtas.Controls.Add(this.textBoxKodeBarang);
            this.panelAtas.Controls.Add(this.labelKodeBarang);
            this.panelAtas.Controls.Add(this.buttonTambah);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 59);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(800, 101);
            this.panelAtas.TabIndex = 5;
            // 
            // dateTimePickerTanggalTransaksi
            // 
            this.dateTimePickerTanggalTransaksi.Location = new System.Drawing.Point(81, 12);
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
            this.textBoxJumlah.Location = new System.Drawing.Point(511, 48);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(231, 20);
            this.textBoxJumlah.TabIndex = 5;
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Location = new System.Drawing.Point(465, 52);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(40, 13);
            this.labelJumlah.TabIndex = 4;
            this.labelJumlah.Text = "Jumlah";
            // 
            // labelHasilCari
            // 
            this.labelHasilCari.AutoSize = true;
            this.labelHasilCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHasilCari.Location = new System.Drawing.Point(3, 71);
            this.labelHasilCari.Name = "labelHasilCari";
            this.labelHasilCari.Size = new System.Drawing.Size(197, 20);
            this.labelHasilCari.TabIndex = 3;
            this.labelHasilCari.Text = "Hasil Pencarian Barang";
            // 
            // textBoxKodeBarang
            // 
            this.textBoxKodeBarang.Location = new System.Drawing.Point(81, 48);
            this.textBoxKodeBarang.Name = "textBoxKodeBarang";
            this.textBoxKodeBarang.Size = new System.Drawing.Size(231, 20);
            this.textBoxKodeBarang.TabIndex = 2;
            // 
            // labelKodeBarang
            // 
            this.labelKodeBarang.AutoSize = true;
            this.labelKodeBarang.Location = new System.Drawing.Point(5, 52);
            this.labelKodeBarang.Name = "labelKodeBarang";
            this.labelKodeBarang.Size = new System.Drawing.Size(69, 13);
            this.labelKodeBarang.TabIndex = 1;
            this.labelKodeBarang.Text = "Kode Barang";
            // 
            // buttonTambah
            // 
            this.buttonTambah.Enabled = false;
            this.buttonTambah.Location = new System.Drawing.Point(318, 43);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(105, 30);
            this.buttonTambah.TabIndex = 0;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 94);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonHapus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(95, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 94);
            this.panel3.TabIndex = 5;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Enabled = false;
            this.buttonHapus.Location = new System.Drawing.Point(118, 27);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(128, 41);
            this.buttonHapus.TabIndex = 0;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.labelTotal);
            this.panel2.Controls.Add(this.textBoxDiskon);
            this.panel2.Controls.Add(this.labelDiskon);
            this.panel2.Controls.Add(this.labelSubTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(477, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 94);
            this.panel2.TabIndex = 4;
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotal.ForeColor = System.Drawing.Color.Lime;
            this.labelTotal.Location = new System.Drawing.Point(123, 60);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(188, 25);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Rp0,00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.Location = new System.Drawing.Point(85, 37);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(231, 20);
            this.textBoxDiskon.TabIndex = 4;
            // 
            // labelDiskon
            // 
            this.labelDiskon.AutoSize = true;
            this.labelDiskon.Location = new System.Drawing.Point(26, 40);
            this.labelDiskon.Name = "labelDiskon";
            this.labelDiskon.Size = new System.Drawing.Size(40, 13);
            this.labelDiskon.TabIndex = 3;
            this.labelDiskon.Text = "Diskon";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSubTotal.Location = new System.Drawing.Point(82, 12);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(78, 17);
            this.labelSubTotal.TabIndex = 0;
            this.labelSubTotal.Text = "Sub Total";
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
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 160);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(800, 196);
            this.dataGridViewData.TabIndex = 7;
            // 
            // FormTambahUbahTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(labelJudul);
            this.Controls.Add(this.panel1);
            this.Name = "FormTambahUbahTransaksi";
            this.Text = "FormTambahUbahTransaksi";
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Label labelKodeBarang;
        private System.Windows.Forms.TextBox textBoxKodeBarang;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggalTransaksi;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelHasilCari;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.Label labelDiskon;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonHapus;
    }
}