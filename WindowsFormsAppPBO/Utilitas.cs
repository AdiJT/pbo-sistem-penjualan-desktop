using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPBO.Entitas;
using WindowsFormsAppPBO.Repositori;
using WindowsFormsAppPBO.Repositori.Commons;

namespace WindowsFormsAppPBO
{
    public static class Utilitas
    {
        public static void SetErrorProvider(Form activeForm, Control control, string errorMessage)
        {
            var errorProvider = new ErrorProvider();
            errorProvider.ContainerControl = activeForm;
            errorProvider.SetError(activeForm, errorMessage);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ShowConfirmation(string message)
        {
            var result  = MessageBox.Show(message, "Konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public static string BuatTabel<T>(List<T> listEntitas, List<Kolom> listKolom, bool useNumbering = false)
        {
            if (useNumbering == true)
                listKolom.Insert(0, new Kolom()
                {
                    NamaEntitas = nameof(Int32),
                    NamaProperti = nameof(Int32),
                    NamaKolom = "Nomor",
                    PanjangKolom = 5,
                    FormatString = ""
                });

            var strTabel = "";

            //Mengambil panjang untuk masing2 kolom maksimal dari kolom.PanjangKolom, panjang nama kolom,
            //dan panjang cells terbesar
            List<int> listPanjangKolom = new List<int>();
            foreach (var item in listKolom)
            {
                int panjang = Math.Max(item.NamaKolom.Length + 2, item.PanjangKolom); // + 2 untuk spasi
                if (item.NamaKolom == "Nomor")
                    panjang = Math.Max(panjang, 5);
                else
                {
                    var maxPanjang = 0;
                    if (listEntitas.Count > 0)
                        maxPanjang = (from e in listEntitas
                                      select e.GetType().GetProperty(item.NamaProperti).GetValue(e).ToString().Length).Max();
                    panjang = Math.Max(panjang, maxPanjang + 2);
                }
                listPanjangKolom.Add(panjang);
            }

            //Buat Border
            string border = "";
            foreach (var item in listPanjangKolom)
            {
                border += "+";
                for (int i = 0; i < item + 1; i++)
                    border += "-";
            }
            border += "+\n";

            //Buat Header
            strTabel += border;
            for (int i = 0; i < listKolom.Count; i++)
            {
                strTabel += $"| {listKolom[i].NamaKolom}";
                if (listKolom[i].NamaKolom.Length < listPanjangKolom[i])
                    for (int j = 0; j < listPanjangKolom[i] - listKolom[i].NamaKolom.Length; j++)
                        strTabel += " ";
            }
            strTabel += "|\n";
            strTabel += border;

            //Membuat isi
            for (int k = 0; k < listEntitas.Count(); k++)
            {
                for (int i = 0; i < listKolom.Count; i++)
                {
                    strTabel += "| ";
                    if (i == 0 && useNumbering == true)
                    {
                        var strNomor = (k + 1).ToString();

                        if (strNomor.Length > listPanjangKolom[i])
                            strNomor = strNomor.Remove(listPanjangKolom[i] - 2) + "..";

                        strTabel += strNomor;

                        if (strNomor.Length < listPanjangKolom[i])
                            for (int j = 0; j < listPanjangKolom[i] - strNomor.Length; j++)
                                strTabel += " ";

                        continue;
                    }


                    string strIsi = "";
                    if (listKolom[i].FormatString.Length > 0)
                        strIsi = string.Format(listKolom[i].FormatString, listEntitas[k].GetType().GetProperty(listKolom[i].NamaProperti).GetValue(listEntitas[k]));
                    else
                        strIsi = listEntitas[k].GetType().GetProperty(listKolom[i].NamaProperti).GetValue(listEntitas[k]).ToString();

                    if (strIsi.Length > listPanjangKolom[i])
                        strIsi = strIsi.Remove(listPanjangKolom[i] - 3) + "..";

                    strTabel += strIsi;

                    if (strIsi.Length < listPanjangKolom[i])
                        for (int j = 0; j < listPanjangKolom[i] - strIsi.Length; j++)
                            strTabel += " ";
                }
                strTabel += "|\n";
                strTabel += border;
            }

            return strTabel;
        } 

        public static IBaseRepositori<Barang> GetRepositoriBarang()
        {
            return new RepositoriBarang(AppDbContext.DbContext);
        }

        public static IBaseRepositori<Kategori> GetRepositoriKategori()
        {
            return new RepositoriKategori(AppDbContext.DbContext);
        }

        public static IBaseRepositori<Satuan> GetRepositoriSatuan()
        {
            return new RepositoriSatuan(AppDbContext.DbContext);
        }

        public static IBaseRepositori<Konsumen> GetRepositoriKonsumen()
        {
            return new RepositoriKonsumen(AppDbContext.DbContext);
        }

        public static IBaseRepositori<Transaksi> GetRepositoriTransaksi()
        {
            return new RepositoriTransaksi(AppDbContext.DbContext);
        }
    }

    public class Kolom
    {
        public string NamaEntitas { get; set; }
        public string NamaProperti { get; set; }
        public string NamaKolom { get; set; }
        public int PanjangKolom { get; set; }
        public string FormatString { get; set; }
    }
}
