namespace WindowsFormsAppPBO.MenuTransaksi
{
    partial class FormTransaksi
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
            this.buttonDetail = new System.Windows.Forms.Button();
            this.buttonCetakNota = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.labelDetailTransaksi = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            labelJudul = new System.Windows.Forms.Label();
            this.panelAtas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
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
            this.panelAtas.Controls.Add(this.buttonDetail);
            this.panelAtas.Controls.Add(this.buttonCetakNota);
            this.panelAtas.Controls.Add(this.buttonRefresh);
            this.panelAtas.Controls.Add(this.buttonHapus);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 59);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(800, 62);
            this.panelAtas.TabIndex = 5;
            // 
            // buttonDetail
            // 
            this.buttonDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDetail.Location = new System.Drawing.Point(285, 0);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(95, 62);
            this.buttonDetail.TabIndex = 5;
            this.buttonDetail.Text = "Detail";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // buttonCetakNota
            // 
            this.buttonCetakNota.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCetakNota.Location = new System.Drawing.Point(190, 0);
            this.buttonCetakNota.Name = "buttonCetakNota";
            this.buttonCetakNota.Size = new System.Drawing.Size(95, 62);
            this.buttonCetakNota.TabIndex = 4;
            this.buttonCetakNota.Text = "Cetak Nota";
            this.buttonCetakNota.UseVisualStyleBackColor = true;
            this.buttonCetakNota.Click += new System.EventHandler(this.buttonCetakNota_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRefresh.Location = new System.Drawing.Point(95, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(95, 62);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHapus.Location = new System.Drawing.Point(0, 0);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(95, 62);
            this.buttonHapus.TabIndex = 2;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonKembali);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 6;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewDetail);
            this.panel2.Controls.Add(this.labelDetailTransaksi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 135);
            this.panel2.TabIndex = 8;
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.AllowUserToDeleteRows = false;
            this.dataGridViewDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.ReadOnly = true;
            this.dataGridViewDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetail.Size = new System.Drawing.Size(800, 91);
            this.dataGridViewDetail.TabIndex = 12;
            // 
            // labelDetailTransaksi
            // 
            this.labelDetailTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDetailTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDetailTransaksi.Location = new System.Drawing.Point(0, 0);
            this.labelDetailTransaksi.Name = "labelDetailTransaksi";
            this.labelDetailTransaksi.Size = new System.Drawing.Size(800, 44);
            this.labelDetailTransaksi.TabIndex = 11;
            this.labelDetailTransaksi.Text = "Detail Transaksi : ";
            this.labelDetailTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 121);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(800, 132);
            this.dataGridViewData.TabIndex = 9;
            this.dataGridViewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellClick);
            this.dataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellClick);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(labelJudul);
            this.Controls.Add(this.panel1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTransaksi_FormClosed);
            this.panelAtas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonCetakNota;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDetailTransaksi;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridView dataGridViewData;
    }
}