using AplikasiKasir.Konfigurasi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir.Model
{
    internal class TransaksiClass
    {

        // ATRIBUT 
        private string id_ker;
        private string kode_tran;
        private string kode_brg;
        private string nama_brg;
        private string harga_brg;
        private string jumlah_brg;
        private string tanggal_tran;
        private string subtotalharga;

        private string id_transaksi;
        private string nama_kasir;
        private string total_bayar;

        //OBJEK YANG DIBENTUK DARI CLASS KONEKSI
        koneksiClass koneksi; //Tururan abstrak
        DataTable temp; //untuk menampung hasil
        string Query;


        public TransaksiClass()
        {
            id_ker = "";
            kode_tran = "";
            kode_brg = "";
            nama_brg = "";
            harga_brg = "";
            jumlah_brg = "";
            tanggal_tran = "";
            subtotalharga = "";

            id_transaksi = "";
            nama_kasir = "";
            total_bayar = "";

            koneksi = new koneksiClass();
            temp = new DataTable();
            Query = "";
        }

        public string Id_keranjang
        {
            set { id_ker = value; }
            get { return id_ker; }
        }

        public string Kode_transaksi
        {
            set { kode_tran = value; }
            get { return kode_tran; }
        }

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

        public string Harga_barang
        {
            set { harga_brg = value; }
            get { return harga_brg; }
        }

        public string Jumlah_barang
        {
            set { jumlah_brg = value; }
            get { return jumlah_brg; }
        }
        public string Tanggal_transaksi
        {
            set { tanggal_tran = value; }
            get { return tanggal_tran; }
        }

        public string Subtotal
        {
            set { subtotalharga = value; }
            get { return subtotalharga; }
        }

        public string Id_transaksi
        {
            set { id_transaksi = value; }
            get { return id_transaksi; }
        }

        public string Nama_kasir
        {
            set { nama_kasir = value; }
            get { return nama_kasir; }
        }

        public string Total_bayar
        {
            set { total_bayar = value; }
            get { return total_bayar; }
        }

        // MENAMPILKAN SEMUA DATA TABEL KERANJANG
        public DataTable TampilKeranjang()
        {
            Query = "SELECT k.id_keranjang, k.kode_transaksi, d.kode_barang, b.nama_barang, d.harga_jual, k.jumlah_barang, k.subtotal, k.tanggal_transaksi " +
                    "FROM keranjang k " +
                    "JOIN detail_barang d ON k.kode_barang = d.kode_barang " +
                    "JOIN barang b ON b.kode_barang = k.kode_barang";

            return koneksi.eksekusiQuery(Query);
        }


        // MENGECEK ID_KERANJANG  
        public bool CekIdKeranjang(string kode)
        {
            bool cek = false;
            Query = "SELECT * FROM keranjang where id_keranjang = '" + kode + "'";

            temp = koneksi.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        // MENGECEK ID_KERANJANG  
        public bool CekIdTransaksi(string kode)
        {
            bool cek = false;
            Query = "SELECT * FROM transaksi where id_transaksi = '" + kode + "'";

            temp = koneksi.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        // MENAMPILKAN NAMA BARANG DAN HARGA JUAL 
        public DataTable TampilNamaDanHarga(string kode)
        {
            string Query = "SELECT b.nama_barang, d.harga_jual FROM detail_barang d " +
                           "JOIN barang b ON b.kode_barang = d.kode_barang " +
                           "WHERE d.kode_barang = '" + kode + "'";
            return koneksi.eksekusiQuery(Query);
        }


        // MENAMPILKAN TOTAL HARGA BELANJA 
        public double SumHarga()
        {
            string query = "SELECT SUM(subtotal) FROM keranjang";
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

        // MENGURANGI STOK BARANG PADA TABEL DETAIL_BARANG KETIKA DI TAMBAHKAN KE KERANJANG
        public int kurangJumlahBarang(string kode_barang, double jumlahBarang)
        {
            int result = -1;

            // Query untuk mengurangi jumlah_barang pada tabel barang
            string updateQuery = "UPDATE detail_barang SET jumlah = jumlah - " + jumlahBarang + " WHERE kode_barang = '" + kode_barang + "'";

            try
            {
                result = koneksi.eksekusiNonQuery(updateQuery);
                if (result < 0)
                {
                    throw new Exception("Gagal mengurangi jumlah_barang pada tabel barang");
                }
            }
            catch (Exception ex) { }
            return result;
        }

        // MENAMBAH STOK BARANG PADA TABEL DETAIL_BARANG KETIKA BARANG DIHAPUS DARI KERANJANG
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

        // MENGECEK STOK BARANG YANG ADA DI TABEL DETAIL_BARANG 
        public double GetStokBarang(string kode_barang)
        {
            double stok = 0;
            string query = "SELECT jumlah FROM detail_barang WHERE kode_barang = '" + kode_barang + "'";

            DataTable resultTable = koneksi.eksekusiQuery(query);
            if (resultTable != null && resultTable.Rows.Count > 0)
            {
                // Ambil nilai jumlah_barang dari hasil query dan konversi ke tipe data double
                stok = Convert.ToDouble(resultTable.Rows[0]["jumlah"]);
            }

            return stok;
        }

        // MENGECEK STOK BARANG YANG ADA DI TABEL DETAIL KERANJANG 
        public double GetJumlahBarang(string idKeranjang)
        {
            double jumlahBarang = 0;
            string query = "SELECT jumlah_barang FROM keranjang WHERE id_keranjang = '" + idKeranjang + "'";
            DataTable resultTable = koneksi.eksekusiQuery(query);
            if (resultTable != null && resultTable.Rows.Count > 0)
            {
                object jumlahObject = resultTable.Rows[0]["jumlah_barang"];
                if (jumlahObject != DBNull.Value)
                {
                    jumlahBarang = Convert.ToDouble(jumlahObject);
                }
            }
            return jumlahBarang;
        }

        // MENGECEK PERUBAHAN APAKAH BARANG BERTAMBAH / BERKURANG PADA SAAT DIUBAH PADA KERANJANG
        public double CekPerubahanJumlahBarang(string idDetail, double jumlahBaru)
        {
            double jumlahSebelum = GetJumlahBarang(idDetail);
            double perubahan = jumlahSebelum - jumlahBaru;
            return perubahan;
        }

        // MEMBUAT KODE ID_KERANJANG
        public string BuatKodeKeranjang()
        {
            string kode = "";
            int result = -1;
            Query = "SELECT IFNULL(MAX(id_keranjang),0) + 1 AS id FROM keranjang";
            temp = koneksi.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    result = Convert.ToInt32(row[0]);
                }
                if (result > 0 && result < 10)
                {
                    kode = "0" + result.ToString();
                }
                else if (result >= 10 && result < 100)
                {
                    kode = result.ToString();
                }
            }
            return kode;
        }

        // MEMBUAT KODE ID_KERANJANG
        public string BuatIdTransaksi()
        {
            string kode = "";
            int result = -1;
            Query = "SELECT IFNULL(MAX(id_transaksi),0) + 1 AS id FROM transaksi";
            temp = koneksi.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    result = Convert.ToInt32(row[0]);
                }
                if (result > 0 && result < 10)
                {
                    kode = "0" + result.ToString();
                }
                else if (result >= 10 && result < 100)
                {
                    kode = result.ToString();
                }
            }
            return kode;
        }

        // MENAMBAH DATA PADA TABEL KERANJANG
        public int TambahKeranjang()
        {
            int result = -1;
            Query = "INSERT INTO keranjang (id_keranjang, kode_transaksi, kode_barang, jumlah_barang, subtotal, tanggal_transaksi) " +
                "VALUES ('" + id_ker + "', '" + kode_tran + "', '" + kode_brg + "', '" + jumlah_brg + "', '" + subtotalharga + "', '" + tanggal_tran + "')";
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

        // MENGHAPUS DATA YANG ADA PADA TABEL KERANJANG 
        public int HapusKeranjang(string id)
        {
            int result = -1;

            Query = "DELETE FROM keranjang WHERE id_keranjang = '" + id + "'";

            try
            {
                result = koneksi.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Data gagal dihapus");
                }
            }
            catch (Exception ex) { }


            return result;
        }

        // MENGUBAH ISI DATA PADA TABEL KERANJANG
        public int UbahKeranjang(string id)
        {
            int result = -1;
            Query = "UPDATE keranjang SET kode_barang='" + kode_brg + "', jumlah_barang='" + jumlah_brg + "', subtotal='" + subtotalharga + "' WHERE id_keranjang = '" + id + "'";

            try
            {
                result = koneksi.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Data gagal diubah");
                }
            }
            catch (Exception ex) { }
            return result;
        }

        // MENGAMBIL DATA KODE TRANSAKSI PADA TABEL KERANJANG 
        public List<string> GetKodeTransaksi()
        {
            List<string> kodeTransaksiList = new List<string>();
            string Query = "SELECT DISTINCT kode_transaksi FROM keranjang";
            DataTable dt = koneksi.eksekusiQuery(Query);

            foreach (DataRow row in dt.Rows)
            {
                kodeTransaksiList.Add(row["kode_transaksi"].ToString());
            }

            return kodeTransaksiList;
        }

        // TAMBAH TRANSAKSI 
        public int TambahTransaksi()
        {
            int result = -1;
            Query = "INSERT INTO transaksi (id_transaksi, nama_kasir, kode_transaksi, total_belanja, tanggal_transaksi) " +
                "VALUES ('" + id_transaksi + "', '" + nama_kasir + "', '" + kode_tran + "', '" + total_bayar + "', '" + tanggal_tran + "')";
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

        // MEMINDAHKAN DATA PADA TABEL KERANJANG KE TABEL DETAIL_TRANSAKSI
        public int TransferData()
        {
            int result = -1;
            Query = "INSERT INTO detail_transaksi (id_transaksi, kode_barang, jumlah_barang, subtotal) " +
                    "SELECT '" + id_transaksi + "', kode_barang, jumlah_barang, subtotal " +
                    "FROM keranjang WHERE kode_transaksi = '" + kode_tran + "'";
            try
            {
                result = koneksi.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Data gagal dipindahkan ke tabel detail_transaksi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        // MENGHAPUS SEMUA DATA YANG ADA PADA TABEL KERANJANG 
        public int HapusDataKeranjang()
        {
            int result = -1;

            Query = "DELETE FROM keranjang";

            try
            {
                result = koneksi.eksekusiNonQuery(Query);
                if (result < 0)
                {
                    throw new Exception("Data gagal dihapus");
                }
            }
            catch (Exception ex) { }
            return result;
        }

        // MENAMPILKAN SEMUA DATA YANG ADA PADA TABEL TRANSAKSI 
        public DataTable DataLaporan()
        {
            string Query = "SELECT id_transaksi, kode_transaksi, tanggal_transaksi, nama_kasir, total_belanja*1000 AS total_harga FROM transaksi";
            return koneksi.eksekusiQuery(Query);
        }

        // CARI KODE TRANSAKSI
        public DataTable CariLaporan(string cari)
        {
            string query = "SELECT id_transaksi, kode_transaksi, tanggal_transaksi, nama_kasir, total_belanja*1000 AS total_harga FROM transaksi WHERE " +
                           "kode_transaksi LIKE '%" + cari + "%' OR " +
                           "nama_kasir LIKE '%" + cari + "%' OR " +
                           "id_transaksi LIKE '%" + cari + "%' OR " +
                           "tanggal_transaksi LIKE '%" + cari + "%' OR " +
                           "total_belanja LIKE '%" + cari + "%'"; // Tambahkan kolom lain sesuai kebutuhan

            return koneksi.eksekusiQuery(query);
        }

        // TOTAL PENDAPATAN 
        public double Pendapatan()
        {
            string query = "SELECT SUM(total_belanja) * 1000 AS pendapatan FROM transaksi";
            DataTable dt = koneksi.eksekusiQuery(query);

            if (dt.Rows.Count > 0 && dt.Rows[0]["pendapatan"] != DBNull.Value)
            {
                return Convert.ToDouble(dt.Rows[0]["pendapatan"]);
            }
            else
            {
                return 0.0; // Jika tidak ada data atau data NULL, kembalikan nilai default atau sesuaikan dengan kebutuhan Anda
            }
        }

        public double TotalTransaksi()
        {
            string query = "SELECT COUNT(id_transaksi) FROM transaksi";
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

