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
    public partial class TransaksiForm : Form
    {
        TransaksiClass transaksi = new TransaksiClass();
        public string UserName { get; set; }

        public TransaksiForm()
        {
            InitializeComponent();
        }
        private void TransaksiForm_Load(object sender, EventArgs e)
        {
            //  MENAMPILKAN TANGGAL SEKARANG
            tanggal_lbl.Text = DateTime.Now.ToLongDateString();

            tampilGrid();

            //  MENAMPILKAN TOTAL HARGA BELANJAAN
            TotalHargaBelanja();

            //MEMBUAT KODE ID_KERANJANG
            id_ker_txt.Text = transaksi.BuatKodeKeranjang();
        }

        // MENAMPILKAN WAKTU
        private void Waktu_Tick(object sender, EventArgs e)
        {
            waktu_lbl.Text = DateTime.Now.ToLongTimeString();
        }

        //MENAMPILKAN DATABASE USER
        public void tampilGrid()
        {
            database_keranjang.DataSource = transaksi.TampilKeranjang();
        }

        void bersihkan()
        {
            TotalHargaBelanja();
            id_ker_txt.Text = transaksi.BuatKodeKeranjang();
            kode_txt.Clear();
            nama_barang_txt.Clear();
            harga_txt.Clear();
            jumlah_txt.Clear();
            subtotal_txt.Clear();
            kode_txt.Focus();
        }

        void TotalHargaBelanja()
        {
            //  MENAMPILKAN TOTAL HARGA BELANJAAN 
            double total_belanja = transaksi.SumHarga();
            totalHarga_txt.Text = total_belanja.ToString();
        }

        // MEMUNCULKAN NAMA DAN HARGA BARANG
        private void kode_txt_KeyDown(object sender, KeyEventArgs e)
        {
            // DENGAN MENEKAN TOMBOL ENTER
            if (e.KeyCode == Keys.Enter)
            {
                string kode = kode_txt.Text;
                DataTable dt = transaksi.TampilNamaDanHarga(kode);

                if (dt.Rows.Count > 0)
                {
                    string namaBarang = dt.Rows[0]["nama_barang"].ToString();
                    string hargaJual = dt.Rows[0]["harga_jual"].ToString();

                    nama_barang_txt.Text = namaBarang;
                    harga_txt.Text = hargaJual;
                    jumlah_txt.Clear();
                    subtotal_txt.Clear();
                }
                else
                {
                    nama_barang_txt.Text = "Barang tidak ditemukan";
                    harga_txt.Text = "0";
                }
            }
        }

        // MENAMPILKAN SUBTOTAL KETIKA MENGISI JUMLAH
        private void jumlah_txt_TextChanged(object sender, EventArgs e)
        {
            // Deklarasi variabel untuk jumlah dan harga
            double jumlah = 0;
            double harga = 0;

            // Cek apakah jumlah_txt tidak kosong
            if (!string.IsNullOrWhiteSpace(jumlah_txt.Text))
            {
                // Coba konversi teks dari jumlah_txt dan harga_txt menjadi double
                if (double.TryParse(jumlah_txt.Text, out jumlah) && double.TryParse(harga_txt.Text, out harga))
                {
                    // Hitung subtotal
                    double subtotal = jumlah * harga;

                    // Tampilkan subtotal di TextBox atau Label yang sesuai (misalnya subtotal_txt)
                    subtotal_txt.Text = subtotal.ToString();
                }
                else
                {
                    // Tampilkan pesan kesalahan jika konversi gagal
                    MessageBox.Show("Input tidak valid. Pastikan jumlah dan harga adalah angka.", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    jumlah_txt.Clear(); // Kosongkan jumlah_txt jika input tidak valid
                    subtotal_txt.Clear(); // Kosongkan subtotal_txt jika input tidak valid
                }
            }
            else
            {
                // Kosongkan subtotal_txt jika jumlah_txt kosong
                subtotal_txt.Clear();
            }
        }

        private void database_keranjang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.database_keranjang.Rows[e.RowIndex];
                id_ker_txt.Text = baris.Cells[0].Value.ToString();
                kode_transaksi_txt.Text = baris.Cells[1].Value.ToString();
                kode_txt.Text = baris.Cells[2].Value.ToString();
                nama_barang_txt.Text = baris.Cells[3].Value.ToString();
                harga_txt.Text = baris.Cells[4].Value.ToString();
                jumlah_txt.Text = baris.Cells[5].Value.ToString();
                subtotal_txt.Text = baris.Cells[6].Value.ToString();


                nama_barang_txt.SelectAll();
                kode_txt.Focus();

            }
        }

        // MENGHAPUS DATA PADA TABEL KERANJANG
        private void hapusBelanja_btn_Click(object sender, EventArgs e)
        {
            if (transaksi.CekIdKeranjang(id_ker_txt.Text))
            {
                if (MessageBox.Show("Apakah akan dihapus?", "KONFIRMASI",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Mengambil kode_barang dan jumlah_barang yang akan dihapus
                    double jumlah_barang = transaksi.GetJumlahBarang(id_ker_txt.Text);

                    // Hapus data pada tabel detail_transaksi
                    transaksi.Id_keranjang = id_ker_txt.Text;
                    transaksi.Kode_barang = kode_txt.Text;
                    if (transaksi.HapusKeranjang(id_ker_txt.Text) >= 0)
                    {
                        // Update jumlah_barang pada tabel barang setelah data dihapus
                        if (transaksi.tambahJumlahBarang(kode_txt.Text, jumlah_barang) >= 0) //MENAMBAH JUMLAH BARANG PADA TABEL BARANG
                        {
                            MessageBox.Show("Data Berhasil dihapus",
                                "INFORMASI",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            kode_txt.Focus();
                            tampilGrid();
                            bersihkan();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengembalikan jumlah_barang pada tabel barang",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            kode_txt.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data tidak Valid",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        kode_txt.Focus();
                    }
                }
            }
        }

        // MENAMBAH DAN MERUBAH PADA DATA TABEL KERANJANG
        private void tambahBelanja_btn_Click(object sender, EventArgs e)
        {
            // MEMASTIKAN TEXTBOXT TERISI SEMUA 
            if (string.IsNullOrWhiteSpace(kode_txt.Text) ||
                string.IsNullOrWhiteSpace(kode_transaksi_txt.Text) ||
                string.IsNullOrWhiteSpace(nama_barang_txt.Text) ||
                string.IsNullOrWhiteSpace(harga_txt.Text) ||
                string.IsNullOrWhiteSpace(subtotal_txt.Text) ||
                string.IsNullOrWhiteSpace(jumlah_txt.Text))
                {
                    MessageBox.Show("Ada yang Kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            transaksi.Id_keranjang = id_ker_txt.Text;
            transaksi.Kode_transaksi = kode_transaksi_txt.Text;
            transaksi.Kode_barang = kode_txt.Text;
            transaksi.Jumlah_barang = jumlah_txt.Text;
            transaksi.Subtotal = subtotal_txt.Text;
            transaksi.Tanggal_transaksi = DateTime.Now.ToString("yyyy-MM-dd");


            transaksi.Nama_barang = nama_barang_txt.Text;
            transaksi.Harga_barang = harga_txt.Text;
            


            //  DECLARASI STOK (TABEL DETAIL_BARANG) DAN JUMLAH (TABEL KERANJANG)
            double stok_barang = transaksi.GetStokBarang(kode_txt.Text);
            double jumlah_barang = Convert.ToDouble(jumlah_txt.Text);

            // PENGECEKAN STOK BARANG > JUMLAH YANG INGIN DIBELI 
            if (jumlah_barang > stok_barang)
            {
                MessageBox.Show("Jumlah barang melebihi stok yang tersedia!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                jumlah_txt.Focus();
                return;
            }

            // MENAMBAH DATA KERANJANG 

            // MELAKUKAN PENGECEKAN ID KERANJANG
            if (!transaksi.CekIdKeranjang(id_ker_txt.Text))
            {
                if (transaksi.TambahKeranjang() >= 0)
                {
                    // Kurangi jumlah_barang pada tabel barang
                    if (transaksi.kurangJumlahBarang(kode_txt.Text, jumlah_barang) >= 0)
                    {
                        tampilGrid();
                        bersihkan();
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengurangi stok pada tabel detail_barang!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kode_txt.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    kode_txt.Focus();
                }
            }
            // MENGUBAH DATA KERANJANG
            else
            {
                if (MessageBox.Show("Apakah data akan diubah?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    double jumlah_barang_baru = Convert.ToDouble(jumlah_txt.Text);
                    double perubahan = transaksi.CekPerubahanJumlahBarang(id_ker_txt.Text, jumlah_barang_baru);

                    if (transaksi.UbahKeranjang(id_ker_txt.Text) >= 0)
                    {
                        // Update jumlah_barang pada tabel barang berdasarkan perubahan
                        if (perubahan > 0) //KETIKA JUMLAH BARANG BERKURANG
                        {
                            if (transaksi.tambahJumlahBarang(kode_txt.Text, perubahan) >= 0)
                            {
                                MessageBox.Show("Data berhasil disimpan!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tampilGrid();
                                bersihkan();
                            }
                            else
                            {
                                MessageBox.Show("Gagal menambah jumlah_barang pada tabel barang!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                kode_txt.Focus();
                            }
                        }
                        else if (perubahan < 0) //KETIKA JUMLAH BARANG BERTAMBAH
                        {
                            if (transaksi.kurangJumlahBarang(kode_txt.Text, Math.Abs(perubahan)) >= 0)
                            {
                                MessageBox.Show("Data berhasil disimpan!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tampilGrid();
                                bersihkan();
                            }
                            else
                            {
                                MessageBox.Show("Gagal mengurangi jumlah_barang pada tabel barang!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                kode_txt.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Data tidak berubah!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tampilGrid();
                            bersihkan();
                        }

                        //MessageBox.Show("Data berhasil diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kode_txt.Focus();
                        tampilGrid();
                        bersihkan();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak valid!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kode_txt.Focus();
                    }
                }
            }

            // MEMPERINGATI BATASAN STOK BARANG
            double batas_minimal = 5; // STOK MINIMAL BARANG
            if (stok_barang - jumlah_barang < batas_minimal)
            {
                MessageBox.Show("Stok barang akan menipis, segera tambah stok!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bersih_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
            tampilGrid();
        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            PaymentForm pembayaran = new PaymentForm();
            pembayaran.KasirName = this.UserName;
            pembayaran.Show();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.UserName = this.UserName;
            dashboard.Show();
            this.Hide();
        }
    }
}
