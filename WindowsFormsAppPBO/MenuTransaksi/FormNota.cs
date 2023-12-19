using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPBO.Entitas;

namespace WindowsFormsAppPBO.MenuTransaksi
{
    public partial class FormNota : Form
    {
        public Transaksi SelectedTransaksi { get; set; }

        public FormNota()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var saveDialog = new FolderBrowserDialog();
            saveDialog.Description = "Folder to Save Nota";
            saveDialog.RootFolder = Environment.SpecialFolder.Desktop;
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPathFile.Text = saveDialog.SelectedPath;
            }
        }

        private void FormNota_Shown(object sender, EventArgs e)
        {
            try
            {
                if (SelectedTransaksi == null)
                    throw new Exception("Transaksi Belum Terpilih");

                richTextBoxNota.Text = Transaksi.BuatNota(SelectedTransaksi);
            }
            catch(Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                var path = textBoxPathFile.Text.Trim();
                if (path.Length == 0)
                    throw new Exception("Pilih folder untuk menyimpan nota terlebih dahulu");
                path += $@"\nota-{SelectedTransaksi.IdTransaksi}-{SelectedTransaksi.Tanggal:D}.txt";
                using (var sw = new StreamWriter(path))
                {
                    sw.WriteLine(richTextBoxNota.Text);
                }
                Utilitas.ShowSuccess("Nota telah tersimpan");
            }
            catch(Exception ex)
            {
                Utilitas.ShowError(ex.Message);
            }
        }

        private void richTextBoxNota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
