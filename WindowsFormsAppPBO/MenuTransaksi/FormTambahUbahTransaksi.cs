using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPBO.Entitas;

namespace WindowsFormsAppPBO.MenuTransaksi
{
    public partial class FormTambahUbahTransaksi : Form
    {
        private List<DetailTransaksi> DetailTransaksis { get; set; } = new List<DetailTransaksi>();
        private DetailBarang currentBarang;
        private DetailTransaksi SelectedDetail = null;
        private readonly AppDbContext db;

        public FormTambahUbahTransaksi(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }
    }
}
