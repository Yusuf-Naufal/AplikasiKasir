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
    public partial class PaymentForm : Form
    {
        TransaksiClass transaksi = new TransaksiClass();
        public string KasirName
        {
            get { return kasir_name_lbl.Text; }
            set { kasir_name_lbl.Text = value; }
        }
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            TotalHargaBelanja();

            tanggal_lbl.Text = DateTime.Now.ToString("yyyy-MM-dd");

            id_transaksi_lbl.Text = transaksi.BuatIdTransaksi();

            TampilkanKodeTransaksi();

            total_bayar_txt.Focus();

        }

        void TotalHargaBelanja()
        {
            //  MENAMPILKAN TOTAL HARGA BELANJAAN 
            double total_belanja = transaksi.SumHarga();
            total_belanja_txt.Text = total_belanja.ToString();
        }

        // MEMBERI TANDA '.' SEPERTI NILAI MATA UANG INDONESIA
        private void total_belanja_txt_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                try
                {
                    // Mengambil nilai dari TextBox dan menghapus tanda titik dan koma
                    double value = Convert.ToDouble(textBox.Text.Replace(".", "").Replace(",", ""));
                    // Menampilkan hasil dalam format mata uang
                    textBox.Text = value.ToString("#,0"); // Format sebagai mata uang dengan titik
                }
                catch (FormatException)
                {
                    MessageBox.Show("Masukkan nilai numerik yang valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Focus(); // Fokus kembali ke TextBox yang error
                }
            }
        }
        private void total_belanja_txt_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string text = textBox.Text.Replace(".", "").Replace(",", "");
                if (double.TryParse(text, out double value))
                {

                    textBox.Text = value.ToString("N0");
                    textBox.SelectionStart = textBox.Text.Length;

                }
            }
        }
        private void total_bayar_txt_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                try
                {
                    // Mengambil nilai dari TextBox dan menghapus tanda titik dan koma
                    double value = Convert.ToDouble(textBox.Text.Replace(".", "").Replace(",", ""));
                    // Menampilkan hasil dalam format mata uang
                    textBox.Text = value.ToString("N0"); // Format sebagai mata uang dengan titik
                }
                catch (FormatException)
                {
                    MessageBox.Show("Masukkan nilai numerik yang valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Focus(); // Fokus kembali ke TextBox yang error
                }
            }
        }
        private void total_bayar_txt_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                string text = textBox.Text.Replace(".", "").Replace(",", "");
                if (double.TryParse(text, out double value))
                {

                    textBox.Text = value.ToString("N0");
                    textBox.SelectionStart = textBox.Text.Length;

                }
            }
        }

        private void TampilkanKodeTransaksi()
        {
            List<string> kodeTransaksiList = transaksi.GetKodeTransaksi();

            if (kodeTransaksiList.Count > 0)
            {
                // Tampilkan kode transaksi pertama dalam daftar (Anda dapat mengubah logika ini sesuai kebutuhan)
                kode_transaksi_lbl.Text = kodeTransaksiList[0];
            }
            else
            {
                kode_transaksi_lbl.Text = "Tidak ada kode transaksi";
            }
        }

        private void total_bayar_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(total_bayar_txt.Text))
                {
                    try
                    {
                        // Mengambil nilai dari TextBox dan menghapus tanda titik
                        double total = Convert.ToDouble(total_belanja_txt.Text);
                        double bayar = Convert.ToDouble(total_bayar_txt.Text);

                        // Memeriksa apakah nilai bayar kurang dari total
                        if (bayar < total)
                        {
                            MessageBox.Show("Nilai bayar tidak boleh kurang dari total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Menghitung kembalian
                            double kembali = bayar - total;

                            // Menampilkan hasil kembalian dalam format mata uang
                            kembalian_txt.Text = kembali.ToString("N0"); // Format sebagai mata uang dengan titik
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Masukkan nilai numerik yang valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Mencegah bunyi beep saat menekan tombol Enter
                    e.SuppressKeyPress = true;
                }
                else
                {
                    // Kosongkan subtotal_txt jika jumlah_txt kosong
                    total_bayar_txt.Clear();
                }
            }
        }

        private void pembayaran_btn_Click(object sender, EventArgs e)
        {
            // MEMASTIKAN TEXTBOXT TERISI SEMUA 
            if (string.IsNullOrWhiteSpace(total_belanja_txt.Text) ||
                string.IsNullOrWhiteSpace(total_bayar_txt.Text) ||
                string.IsNullOrWhiteSpace(kembalian_txt.Text))
            {
                MessageBox.Show("Ada yang Kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            transaksi.Id_transaksi = id_transaksi_lbl.Text;
            transaksi.Nama_kasir = kasir_name_lbl.Text;
            transaksi.Tanggal_transaksi = tanggal_lbl.Text;
            transaksi.Kode_transaksi = kode_transaksi_lbl.Text;
            transaksi.Total_bayar = total_belanja_txt.Text;

            // Menambahkan data ke tabel transaksi jika ID transaksi belum ada
            if (!transaksi.CekIdTransaksi(id_transaksi_lbl.Text))
            {
                int tambahTransaksiResult = transaksi.TambahTransaksi();
                if (tambahTransaksiResult > 0)
                {
                    int pindahDataResult = transaksi.TransferData();
                    if (pindahDataResult > 0)
                    {
                        int hapusKeranjangResult = transaksi.HapusDataKeranjang();
                        if (hapusKeranjangResult > 0)
                        {
                            MessageBox.Show("Transaksi berhasil diproses.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            TransaksiForm transaksiForm = new TransaksiForm();
                            transaksiForm.tampilGrid();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus data dari keranjang.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gagal memindahkan data dari keranjang ke detail transaksi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan data ke tabel transaksi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID Transaksi sudah ada.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
