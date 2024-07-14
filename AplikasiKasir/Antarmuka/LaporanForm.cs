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
    public partial class LaporanForm : Form
    {
        TransaksiClass transaksi = new TransaksiClass();
        public LaporanForm()
        {
            InitializeComponent();
        }

        private void LaporanForm_Load(object sender, EventArgs e)
        {
            tampilGrid();
        }

        void tampilGrid()
        {
            if (search_txt.Text == "")
            {
                // Ambil semua data dari database
                DataTable dataTable = transaksi.DataLaporan();

                // Tambahkan kolom "No" jika belum ada
                if (!dataTable.Columns.Contains("No"))
                {
                    dataTable.Columns.Add("No", typeof(int));
                }

                // Isi kolom "No" dengan nomor urut
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["No"] = i + 1;
                }

                // Set DataSource dari DataGridView
                database_laporan.DataSource = dataTable;

            }
            else
            {
                // Ambil semua data dari database
                DataTable dataTable = transaksi.CariLaporan(search_txt.Text);

                // Tambahkan kolom "No" jika belum ada
                if (!dataTable.Columns.Contains("No"))
                {
                    dataTable.Columns.Add("No", typeof(int));
                }

                // Isi kolom "No" dengan nomor urut
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["No"] = i + 1;
                }
                // Ambil data berdasarkan pencarian
                database_laporan.DataSource = dataTable;
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }
    }
}
