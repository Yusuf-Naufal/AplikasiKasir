using AplikasiKasir.Konfigurasi;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir.Model
{
    internal class BarangClass
    {
        //ATRIBUT
        private string kode_brg;
        private string nama_brg;
        private string id_kate;
        private string hrg_beli;
        private string hrg_jual;
        private string jumlah_brg;
        private string satuan_brg;

        //OBJEK YANG DIBENTUK DARI CLASS KONEKSI
        koneksiClass koneksi; //Tururan abstrak
        DataTable temp; //untuk menampung hasil
        string Query;

        //CONSTRUKTOR
        public BarangClass()
        {
            kode_brg = "";
            nama_brg = "";
            id_kate = "";
            hrg_beli = "";
            hrg_jual = "";
            jumlah_brg = "";
            satuan_brg = "";

            koneksi = new koneksiClass();
            temp = new DataTable();
            Query = "";
        }

        //PROPERTI AKSES PRIVATE
        public string Kode_barang
        {
            set { kode_brg = value; }
            get { return kode_brg; }
        }

        public string Nama_barang
        {
            set { nama_brg = value; }
            get { return nama_brg; }
        }

        public string Id_kategori
        {
            set { id_kate = value; }
            get { return id_kate; }
        }

        public string Harga_beli
        {
            set { hrg_beli = value; }
            get { return hrg_beli; }
        }

        public string Harga_jual
        {
            set { hrg_jual = value; }
            get { return hrg_jual; }
        }

        public string Jumlah_barang
        {
            set { jumlah_brg = value; }
            get { return jumlah_brg; }
        }

        public string Satuan_barang
        {
            set { satuan_brg = value; }
            get { return satuan_brg; }
        }

        //DAFTAR METHOD

        //MENCARI KODE BARANG 
        public bool apakahAda(string kode)
        {
            bool cek = false;
            Query = "SELECT * FROM barang WHERE kode_barang='" + kode + "'";
            temp = koneksi.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        //TAMPIL BARANG, KATEGORI, DETAIL BARANG
        public DataTable tampilkanSemua()
        {
            Query = "SELECT b.kode_barang, b.nama_barang, k.nama_kategori, d.jumlah, d.harga_beli, " +
               "d.harga_jual, b.satuan " +
               "FROM barang b " +
               "JOIN kategori k ON b.id_kategori = k.id_kategori " +
               "JOIN detail_barang d ON b.kode_barang = d.kode_barang";


            return koneksi.eksekusiQuery(Query);
        }

        //TAMPIL BARANG, KATEGORI, DETAIL BARANG
        public DataTable BarangSudahAda(string kode)
        {
            Query = "SELECT b.nama_barang, k.nama_kategori, d.harga_beli, " +
               "d.harga_jual, b.satuan " +
               "FROM barang b " +
               "JOIN kategori k ON b.id_kategori = k.id_kategori " +
               "JOIN detail_barang d ON b.kode_barang = d.kode_barang " +
               "WHERE b.kode_barang = '" + kode + "'";


            return koneksi.eksekusiQuery(Query);
        }

        //MENAMPILKAN KATEGORI PADA COMBOBOX
        public DataTable tampilkanKategori()
        {
            Query = "SELECT id_kategori, nama_kategori FROM KATEGORI";


            return koneksi.eksekusiQuery(Query);
        }

        //SEARCH NAMA BARANG
        public DataTable cariDgNama(string nama)
        {
            Query = "SELECT b.kode_barang, b.nama_barang, k.nama_kategori, d.jumlah, d.harga_beli, " +
               "d.harga_jual, b.satuan " +
               "FROM barang b " +
               "JOIN kategori k ON b.id_kategori = k.id_kategori " +
               "JOIN detail_barang d ON b.kode_barang = d.kode_barang " +
               "WHERE b.nama_barang LIKE '%" + nama + "%'";
            return koneksi.eksekusiQuery(Query);
        }

        //EDIT DATA PADA TABEL BARANG
        public int ubahDataBarang(string kode)
        {
            int result = -1;

            Query = "UPDATE barang SET kode_barang ='" + kode_brg + "'," +
                " nama_barang ='" + nama_brg + "'," +
                " satuan ='" + satuan_brg + "'," +
                " id_kategori ='" + id_kate + "'" +
                " WHERE kode_barang ='" + kode + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Data gagal disimpan");
                }
            }
            catch (Exception ex) { }

            return result;
        }

        // MENGUBAH DATA PADA TABEL DETAIL BARANG
        public int ubahDataDetailBarang(string kode)
        {
            int result = -1;

            Query = "UPDATE detail_barang SET harga_beli ='" + hrg_beli + "'," +
                " harga_jual ='" + hrg_jual + "'," +
                " jumlah ='" + jumlah_brg + "'" +
                " WHERE kode_barang ='" + kode + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Data gagal disimpan");
                }
            }
            catch (Exception ex) { }

            return result;
        }

        //MENGHAPUS DATA 
        public int hapusData(string kode)
        {
            int result = -1;

            // Query untuk menghapus dari detail_barang terlebih dahulu
            string queryDetail = "DELETE FROM detail_barang WHERE kode_barang ='" + kode + "' ";

            // Query untuk menghapus dari barang setelah detail_barang dihapus
            string queryBarang = "DELETE FROM barang WHERE kode_barang ='" + kode + "' ";

            try
            {
                // Eksekusi query untuk menghapus dari detail_barang
                result = koneksi.eksekusiNonQuery(queryDetail);
                if (result < 0)
                {
                    throw new Exception("Data gagal dihapus dari detail_barang");
                }

                // Eksekusi query untuk menghapus dari barang
                result = koneksi.eksekusiNonQuery(queryBarang);
                if (result < 0)
                {
                    throw new Exception("Data gagal dihapus dari barang");
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                // Anda dapat menambahkan log atau tindakan lain jika diperlukan
            }

            return result;
        }

        public int tambahJumlahBarang(string kodeBarang, double jumlahBarang)
        {
            int result = -1;
            string query = "UPDATE detail_barang SET jumlah = jumlah + " + jumlahBarang + " WHERE kode_barang = '" + kodeBarang + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        public bool SimpanBarang()
        {
            try
            {
                string queryBarang = "INSERT INTO barang (kode_barang, nama_barang, satuan, id_kategori) " +
                                     "VALUES ('" + kode_brg + "', '" + nama_brg + "', '" + satuan_brg + "', " + id_kate + ")";

                string queryDetailBarang = "INSERT INTO detail_barang (kode_barang, harga_beli, harga_jual, jumlah) " +
                                           "VALUES ('" + kode_brg + "', " + hrg_beli + ", " + hrg_jual + ", " + jumlah_brg + ")";

                int resultBarang = koneksi.eksekusiNonQuery(queryBarang);
                int resultDetailBarang = koneksi.eksekusiNonQuery(queryDetailBarang);

                return (resultBarang > 0 && resultDetailBarang > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // JUMLAH BARANG YANG DIMILIKI
        public double TotalStok()
        {
            string query = "SELECT SUM(jumlah) FROM detail_barang";
            DataTable resultTable = koneksi.eksekusiQuery(query);

            if (resultTable != null && resultTable.Rows.Count > 0 && resultTable.Rows[0][0] != DBNull.Value)
            {
                return Convert.ToDouble(resultTable.Rows[0][0]);
            }
            else
            {
                // Menangani kasus di mana hasilnya null atau tidak bisa dikonversi ke double
                return 0.0;
            }
        }

    }
}
