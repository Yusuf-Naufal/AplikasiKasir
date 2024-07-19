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
    public partial class TambahBarangForm : Form
    {
        BarangClass barang = new BarangClass();
        public TambahBarangForm()
        {
            InitializeComponent();
        }

        private void TambahBarangForm_Load(object sender, EventArgs e)
        {
            munculKategori();
            bersihkan();
        }

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

        private void kodebrg_txt_KeyDown(object sender, KeyEventArgs e)
        {
            // DENGAN MENEKAN TOMBOL ENTER
            if (e.KeyCode == Keys.Enter)
            {
                if (barang.apakahAda(kodebrg_txt.Text))
                {
                    barang.Jumlah_barang = jumlah_txt.Text;
                    string kode = kodebrg_txt.Text;
                    DataTable dt = barang.BarangSudahAda(kode);

                    if (dt.Rows.Count > 0)
                    {
                        string namaBarang = dt.Rows[0]["nama_barang"].ToString();
                        string hargaJual = dt.Rows[0]["harga_jual"].ToString();
                        string hargaBeli = dt.Rows[0]["harga_beli"].ToString();
                        string Satuan = dt.Rows[0]["satuan"].ToString();
                        string Kategori = dt.Rows[0]["nama_kategori"].ToString();


                        namabrg_txt.Text = namaBarang;
                        hrgjual_txt.Text = hargaJual;
                        hrgbeli_txt.Text = hargaBeli;
                        satuan_txt.Text = Satuan;
                        katbrg_cmb.Text = Kategori;
                        jumlah_txt.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Barang Tidak Ada", "INFORMASI",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Barang Tidak Ada", "INFORMASI",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {

            // Pengecekan apakah semua field telah diisi
            if (string.IsNullOrWhiteSpace(kodebrg_txt.Text) ||
                string.IsNullOrWhiteSpace(namabrg_txt.Text) ||
                string.IsNullOrWhiteSpace(jumlah_txt.Text) ||
                string.IsNullOrWhiteSpace(katbrg_cmb.Text) ||
                string.IsNullOrWhiteSpace(hrgbeli_txt.Text) ||
                string.IsNullOrWhiteSpace(hrgjual_txt.Text) ||
                string.IsNullOrWhiteSpace(satuan_txt.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (barang.apakahAda(kodebrg_txt.Text))
            {
                double jumlahTambah = Convert.ToDouble(jumlah_txt.Text);

                int result = barang.tambahJumlahBarang(kodebrg_txt.Text, jumlahTambah);
                if (result > 0)
                {
                    MessageBox.Show("Jumlah barang berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan jumlah barang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                barang.Kode_barang = kodebrg_txt.Text;
                barang.Nama_barang = namabrg_txt.Text;
                barang.Jumlah_barang = jumlah_txt.Text;
                barang.Id_kategori = ((KeyValuePair<string, string>)katbrg_cmb.SelectedItem).Key;
                barang.Harga_jual = hrgjual_txt.Text;
                barang.Harga_beli = hrgbeli_txt.Text;
                barang.Satuan_barang = satuan_txt.Text;

                if (barang.SimpanBarang())
                {
                    MessageBox.Show("Barang baru berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan barang baru.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void bersihkan()
        {
            kodebrg_txt.Clear();
            namabrg_txt.Clear();
            hrgbeli_txt.Clear();
            hrgjual_txt.Clear();
            jumlah_txt.Clear();
            kodebrg_txt.Focus();
            katbrg_cmb.Items.Clear();
            munculKategori();
        }

        private void bersih_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }
    }
}
