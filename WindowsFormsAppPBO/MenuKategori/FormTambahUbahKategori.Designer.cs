namespace WindowsFormsAppPBO.MenuKategori
{
    partial class FormTambahUbahKategori
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.textBoxNamaKategori = new System.Windows.Forms.TextBox();
            this.labelNamaKategori = new System.Windows.Forms.Label();
            this.textBoxKodeKategori = new System.Windows.Forms.TextBox();
            this.labelKodeKategori = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonSimpan);
            this.panel1.Controls.Add(this.buttonKembali);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 62);
            this.panel1.TabIndex = 21;
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
            this.buttonKembali.Location = new System.Drawing.Point(342, 0);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(95, 62);
            this.buttonKembali.TabIndex = 3;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // textBoxNamaKategori
            // 
            this.textBoxNamaKategori.Location = new System.Drawing.Point(133, 123);
            this.textBoxNamaKategori.Name = "textBoxNamaKategori";
            this.textBoxNamaKategori.Size = new System.Drawing.Size(281, 20);
            this.textBoxNamaKategori.TabIndex = 16;
            this.textBoxNamaKategori.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNamaKategori_Validating);
            // 
            // labelNamaKategori
            // 
            this.labelNamaKategori.AutoSize = true;
            this.labelNamaKategori.Location = new System.Drawing.Point(40, 126);
            this.labelNamaKategori.Name = "labelNamaKategori";
            this.labelNamaKategori.Size = new System.Drawing.Size(77, 13);
            this.labelNamaKategori.TabIndex = 15;
            this.labelNamaKategori.Text = "Nama Kategori";
            // 
            // textBoxKodeKategori
            // 
            this.textBoxKodeKategori.Location = new System.Drawing.Point(133, 94);
            this.textBoxKodeKategori.Name = "textBoxKodeKategori";
            this.textBoxKodeKategori.Size = new System.Drawing.Size(281, 20);
            this.textBoxKodeKategori.TabIndex = 14;
            this.textBoxKodeKategori.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKodeKategori_Validating);
            // 
            // labelKodeKategori
            // 
            this.labelKodeKategori.AutoSize = true;
            this.labelKodeKategori.Location = new System.Drawing.Point(41, 97);
            this.labelKodeKategori.Name = "labelKodeKategori";
            this.labelKodeKategori.Size = new System.Drawing.Size(74, 13);
            this.labelKodeKategori.TabIndex = 13;
            this.labelKodeKategori.Text = "Kode Kategori";
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelJudul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelJudul.Location = new System.Drawing.Point(0, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(437, 45);
            this.labelJudul.TabIndex = 12;
            this.labelJudul.Text = "Kategori";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormTambahUbahKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(437, 286);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxNamaKategori);
            this.Controls.Add(this.labelNamaKategori);
            this.Controls.Add(this.textBoxKodeKategori);
            this.Controls.Add(this.labelKodeKategori);
            this.Controls.Add(this.labelJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTambahUbahKategori";
            this.Text = "FormTambahUbahKategori";
            this.Shown += new System.EventHandler(this.FormTambahUbahKategori_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.TextBox textBoxNamaKategori;
        private System.Windows.Forms.Label labelNamaKategori;
        private System.Windows.Forms.TextBox textBoxKodeKategori;
        private System.Windows.Forms.Label labelKodeKategori;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}