namespace WindowsFormsAppPBO.MenuBarang
{
    partial class FormBarang
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDetail = new System.Windows.Forms.Label();
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            labelJudul = new System.Windows.Forms.Label();
            this.panelAtas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            labelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            labelJudul.Location = new System.Drawing.Point(0, 0);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new System.Drawing.Size(800, 59);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Barang";
            labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAtas
            // 
            this.panelAtas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAtas.Controls.Add(this.buttonDetail);
            this.panelAtas.Controls.Add(this.buttonRefresh);
            this.panelAtas.Controls.Add(this.buttonHapus);
            this.panelAtas.Controls.Add(this.buttonUbah);
            this.panelAtas.Controls.Add(this.buttonTambah);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(0, 59);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(800, 62);
            this.panelAtas.TabIndex = 1;
            // 
            // buttonDetail
            // 
            this.buttonDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDetail.Location = new System.Drawing.Point(376, 0);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(95, 62);
            this.buttonDetail.TabIndex = 4;
            this.buttonDetail.Text = "Detail";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRefresh.Location = new System.Drawing.Point(281, 0);
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
            this.buttonHapus.Location = new System.Drawing.Point(186, 0);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(95, 62);
            this.buttonHapus.TabIndex = 2;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonUbah.Location = new System.Drawing.Point(91, 0);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(95, 62);
            this.buttonUbah.TabIndex = 1;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTambah.Location = new System.Drawing.Point(0, 0);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(91, 62);
            this.buttonTambah.TabIndex = 0;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonKembali);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 2;
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
            // dataGridViewData
            // 
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 121);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(800, 267);
            this.dataGridViewData.TabIndex = 3;
            this.dataGridViewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewDetail);
            this.panel2.Controls.Add(this.labelDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 162);
            this.panel2.TabIndex = 4;
            // 
            // labelDetail
            // 
            this.labelDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDetail.Location = new System.Drawing.Point(0, 0);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(800, 32);
            this.labelDetail.TabIndex = 3;
            this.labelDetail.Text = "Detail Barang : ";
            this.labelDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.Size = new System.Drawing.Size(800, 130);
            this.dataGridViewDetail.TabIndex = 4;
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(labelJudul);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBarang_FormClosed);
            this.Shown += new System.EventHandler(this.FormBarang_Shown);
            this.panelAtas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAtas;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
    }
}