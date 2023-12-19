namespace WindowsFormsAppPBO.MenuSatuan
{
    partial class FormTambahUbahSatuan
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
            this.labelKodeSatuan = new System.Windows.Forms.Label();
            this.textBoxKodeSatuan = new System.Windows.Forms.TextBox();
            this.textBoxNamaSatuan = new System.Windows.Forms.TextBox();
            this.labelNamaSatuan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelJudul.Location = new System.Drawing.Point(0, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(501, 40);
            this.labelJudul.TabIndex = 1;
            this.labelJudul.Text = "Tambah Satuan";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKodeSatuan
            // 
            this.labelKodeSatuan.AutoSize = true;
            this.labelKodeSatuan.Location = new System.Drawing.Point(116, 83);
            this.labelKodeSatuan.Name = "labelKodeSatuan";
            this.labelKodeSatuan.Size = new System.Drawing.Size(69, 13);
            this.labelKodeSatuan.TabIndex = 2;
            this.labelKodeSatuan.Text = "Kode Satuan";
            // 
            // textBoxKodeSatuan
            // 
            this.textBoxKodeSatuan.Location = new System.Drawing.Point(192, 79);
            this.textBoxKodeSatuan.Name = "textBoxKodeSatuan";
            this.textBoxKodeSatuan.Size = new System.Drawing.Size(173, 20);
            this.textBoxKodeSatuan.TabIndex = 3;
            this.textBoxKodeSatuan.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKodeSatuan_Validating);
            // 
            // textBoxNamaSatuan
            // 
            this.textBoxNamaSatuan.Location = new System.Drawing.Point(192, 117);
            this.textBoxNamaSatuan.Name = "textBoxNamaSatuan";
            this.textBoxNamaSatuan.Size = new System.Drawing.Size(173, 20);
            this.textBoxNamaSatuan.TabIndex = 5;
            this.textBoxNamaSatuan.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNamaSatuan_Validating);
            // 
            // labelNamaSatuan
            // 
            this.labelNamaSatuan.AutoSize = true;
            this.labelNamaSatuan.Location = new System.Drawing.Point(116, 121);
            this.labelNamaSatuan.Name = "labelNamaSatuan";
            this.labelNamaSatuan.Size = new System.Drawing.Size(72, 13);
            this.labelNamaSatuan.TabIndex = 4;
            this.labelNamaSatuan.Text = "Nama Satuan";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.buttonSimpan);
            this.panel2.Controls.Add(this.buttonKembali);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(501, 46);
            this.panel2.TabIndex = 6;
            // 
            // buttonKembali
            // 
            this.buttonKembali.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonKembali.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonKembali.Location = new System.Drawing.Point(393, 7);
            this.buttonKembali.Margin = new System.Windows.Forms.Padding(8);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(101, 32);
            this.buttonKembali.TabIndex = 0;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormTambahUbahSatuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(501, 224);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxNamaSatuan);
            this.Controls.Add(this.labelNamaSatuan);
            this.Controls.Add(this.textBoxKodeSatuan);
            this.Controls.Add(this.labelKodeSatuan);
            this.Controls.Add(this.labelJudul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTambahUbahSatuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahUbahSatuan";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FormTambahUbahSatuan_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelKodeSatuan;
        private System.Windows.Forms.TextBox textBoxKodeSatuan;
        private System.Windows.Forms.TextBox textBoxNamaSatuan;
        private System.Windows.Forms.Label labelNamaSatuan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}