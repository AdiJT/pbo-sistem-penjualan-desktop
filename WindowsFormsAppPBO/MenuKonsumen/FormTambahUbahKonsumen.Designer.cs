namespace WindowsFormsAppPBO.MenuKonsumen
{
    partial class FormTambahUbahKonsumen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.textBoxNamaKonsumen = new System.Windows.Forms.TextBox();
            this.labelNamaKonsumen = new System.Windows.Forms.Label();
            this.textBoxIdKonsumen = new System.Windows.Forms.TextBox();
            this.labelIdKonsumen = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxNoHp = new System.Windows.Forms.TextBox();
            this.labelNoHp = new System.Windows.Forms.Label();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.buttonSimpan);
            this.panel2.Controls.Add(this.buttonKembali);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 281);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(517, 46);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSimpan.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSimpan.Location = new System.Drawing.Point(7, 7);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(8);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(101, 32);
            this.buttonSimpan.TabIndex = 1;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonKembali
            // 
            this.buttonKembali.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonKembali.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonKembali.Location = new System.Drawing.Point(409, 7);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(8);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(101, 32);
            this.buttonKembali.TabIndex = 0;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // textBoxNamaKonsumen
            // 
            this.textBoxNamaKonsumen.Location = new System.Drawing.Point(205, 115);
            this.textBoxNamaKonsumen.Name = "textBoxNamaKonsumen";
            this.textBoxNamaKonsumen.Size = new System.Drawing.Size(173, 20);
            this.textBoxNamaKonsumen.TabIndex = 11;
            this.textBoxNamaKonsumen.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNamaKonsumen_Validating);
            // 
            // labelNamaKonsumen
            // 
            this.labelNamaKonsumen.AutoSize = true;
            this.labelNamaKonsumen.Location = new System.Drawing.Point(107, 119);
            this.labelNamaKonsumen.Name = "labelNamaKonsumen";
            this.labelNamaKonsumen.Size = new System.Drawing.Size(88, 13);
            this.labelNamaKonsumen.TabIndex = 10;
            this.labelNamaKonsumen.Text = "Nama Konsumen";
            // 
            // textBoxIdKonsumen
            // 
            this.textBoxIdKonsumen.Location = new System.Drawing.Point(205, 79);
            this.textBoxIdKonsumen.Name = "textBoxIdKonsumen";
            this.textBoxIdKonsumen.Size = new System.Drawing.Size(173, 20);
            this.textBoxIdKonsumen.TabIndex = 9;
            this.textBoxIdKonsumen.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIdKonsumen_Validating);
            // 
            // labelIdKonsumen
            // 
            this.labelIdKonsumen.AutoSize = true;
            this.labelIdKonsumen.Location = new System.Drawing.Point(107, 83);
            this.labelIdKonsumen.Name = "labelIdKonsumen";
            this.labelIdKonsumen.Size = new System.Drawing.Size(71, 13);
            this.labelIdKonsumen.TabIndex = 8;
            this.labelIdKonsumen.Text = "ID Konsumen";
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelJudul.Location = new System.Drawing.Point(0, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(517, 40);
            this.labelJudul.TabIndex = 7;
            this.labelJudul.Text = "Tambah Konsumen";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBoxNoHp
            // 
            this.textBoxNoHp.Location = new System.Drawing.Point(205, 151);
            this.textBoxNoHp.Name = "textBoxNoHp";
            this.textBoxNoHp.Size = new System.Drawing.Size(173, 20);
            this.textBoxNoHp.TabIndex = 14;
            this.textBoxNoHp.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNoHp_Validating);
            // 
            // labelNoHp
            // 
            this.labelNoHp.AutoSize = true;
            this.labelNoHp.Location = new System.Drawing.Point(107, 155);
            this.labelNoHp.Name = "labelNoHp";
            this.labelNoHp.Size = new System.Drawing.Size(56, 13);
            this.labelNoHp.TabIndex = 13;
            this.labelNoHp.Text = "Nomor HP";
            this.labelNoHp.Click += new System.EventHandler(this.labelNoHp_Click);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(205, 187);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(173, 70);
            this.textBoxAlamat.TabIndex = 16;
            this.textBoxAlamat.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAlamat_Validating);
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(107, 191);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(39, 13);
            this.labelAlamat.TabIndex = 15;
            this.labelAlamat.Text = "Alamat";
            // 
            // FormTambahUbahKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(517, 327);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.textBoxNoHp);
            this.Controls.Add(this.labelNoHp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxNamaKonsumen);
            this.Controls.Add(this.labelNamaKonsumen);
            this.Controls.Add(this.textBoxIdKonsumen);
            this.Controls.Add(this.labelIdKonsumen);
            this.Controls.Add(this.labelJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTambahUbahKonsumen";
            this.Text = "FormTambahUbahKonsumen";
            this.Shown += new System.EventHandler(this.FormTambahUbahKonsumen_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.TextBox textBoxNamaKonsumen;
        private System.Windows.Forms.Label labelNamaKonsumen;
        private System.Windows.Forms.TextBox textBoxIdKonsumen;
        private System.Windows.Forms.Label labelIdKonsumen;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.TextBox textBoxNoHp;
        private System.Windows.Forms.Label labelNoHp;
    }
}