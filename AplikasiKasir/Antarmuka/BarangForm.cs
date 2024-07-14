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
    public partial class BarangForm : Form
    {
        //MEMANGGIL BARANGCLASS
        BarangClass barang = new BarangClass();
        public BarangForm()
        {
            InitializeComponent();
        }

        private void BarangFrom_Load(object sender, EventArgs e)
        {
            tampilGrid();
            munculKategori();
        }

        //MENAMPILKAN ISI DATA PADA TABEL BARANG, KATEGORI DAN DETAIL BARANG
        void tampilGrid()
        {
            if (search_txt.Text == "")
            {
                database_barang.DataSource = barang.tampilkanSemua();

            }
            else
            {
                database_barang.DataSource = barang.cariDgNama(search_txt.Text);
            }
        }

        //MENGAMBIL DATA YANG ADA PADA GRID VIEW
        private void database_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.database_barang.Rows[e.RowIndex];
                kodebrg_txt.Text = baris.Cells[0].Value.ToString();
                namabrg_txt.Text = baris.Cells[1].Value.ToString();
                katbrg_cmb.Text = baris.Cells[2].Value.ToString();
                jumlah_txt.Text = baris.Cells[3].Value.ToString();
                hrgbeli_txt.Text = baris.Cells[4].Value.ToString();
                hrgjual_txt.Text = baris.Cells[5].Value.ToString();
                satuan_txt.Text = baris.Cells[6].Value.ToString();
                namabrg_txt.SelectAll();
                namabrg_txt.Focus();
            }
        }

        //MENCARI NAMA BARANG 
        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        //MEMUNCULKAN NAMA BARANG
        void munculKategori()
        {
            Dictionary<string, string> kategori = new Dictionary<string, string>
            {
                {"1", "Makanan"},
                {"2", "Minuman"},
                {"3", "Alat Dapur"},
                {"4", "Obat"},
                {"5", "Pakaian"},
                {"6", "Sembako"}
            };

            // MENGKOSONGKAN PILIHAN
            katbrg_cmb.Items.Clear();

            // MENAMBAH ITEM DARI DICTIONARY
            foreach (var item in kategori)
            {
                katbrg_cmb.Items.Add(new KeyValuePair<string, string>(item.Key, item.Value));
            }

            // MENAMPILKAN nama_kategori
            katbrg_cmb.DisplayMember = "Value";

            // MEMBERIKAN VALUE BERUPA id_kategori
            katbrg_cmb.ValueMember = "Key";
        }

        // TRIGGER BUTTON UBAH
        private void ubah_btn_Click(object sender, EventArgs e)
        {
            barang.Kode_barang = kodebrg_txt.Text;
            barang.Nama_barang = namabrg_txt.Text;
            barang.Id_kategori = ((KeyValuePair<string, string>)katbrg_cmb.SelectedItem).Key;
            barang.Jumlah_barang = jumlah_txt.Text;
            barang.Harga_beli = hrgbeli_txt.Text;
            barang.Harga_jual = hrgjual_txt.Text;
            barang.Satuan_barang = satuan_txt.Text;
            if (MessageBox.Show("Yakin data akan diubah?", "KONFIRMASI",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (barang.ubahDataBarang(kodebrg_txt.Text) >= 0 && barang.ubahDataDetailBarang(kodebrg_txt.Text) >= 0) // Ubah data
                {
                    MessageBox.Show("Data berhasil diubah.", "INFORMASI",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    namabrg_txt.Focus();
                    tampilGrid();
                    bersihkan();
                }
                else
                {
                    MessageBox.Show("Data tidak valid.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    namabrg_txt.Focus();
                }
            }
        }

        // TRIGGER BUTTON HAPUS
        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (barang.apakahAda(kodebrg_txt.Text))
            {
                if (MessageBox.Show("Yakin data akan dihapus?", "KONFIRMASI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    barang.Kode_barang = kodebrg_txt.Text;
                    if (barang.hapusData(kodebrg_txt.Text) >= 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "INFORMASI",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        namabrg_txt.Focus();
                        tampilGrid();
                        bersihkan();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak valid.", "ERROR"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        namabrg_txt.Focus();
                    }
                }
            }
        }

        // MEMBERSIHKAN ISIAN TEXT BOX
        void bersihkan()
        {
            kodebrg_txt.Clear();
            namabrg_txt.Clear();
            hrgbeli_txt.Clear();
            hrgjual_txt.Clear();
            jumlah_txt.Clear();
            namabrg_txt.Focus();
            katbrg_cmb.Items.Clear();
            munculKategori();
        }

        private void bersih_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void reflash_btn_Click(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void tambahbarang_btn_Click(object sender, EventArgs e)
        {
            TambahBarangForm tambah = new TambahBarangForm();
            tambah.ShowDialog();
        }
    }
}
