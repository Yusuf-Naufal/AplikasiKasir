using AplikasiKasir.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir.Antarmuka
{
    public partial class HomeForm : Form
    {
        BarangClass barang = new BarangClass();
        UsersClass users = new UsersClass();
        TransaksiClass transaksi = new TransaksiClass();    
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            double pendapatan = transaksi.Pendapatan();
            pendapatan_txt.Text = pendapatan.ToString("N0");

            double stok = barang.TotalStok();
            total_barang.Text = stok.ToString();

            double karyawan = users.TotalUser();
            total_user.Text = karyawan.ToString();

            double pembarayan = transaksi.TotalTransaksi();
            total_transaksi.Text = pembarayan.ToString();

        }

        
    }
}
