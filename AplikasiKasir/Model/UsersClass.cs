using AplikasiKasir.Konfigurasi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiKasir.Model
{
    internal class UsersClass
    {
        // ATRIBUT 
        private string id_users;
        private string nama_users;
        private string email_users;
        private string username;
        private string password;
        private string jenis_kelamin;
        private string no_hp;
        private string role;
        private string alamat;

        koneksiClass koneksi;
        DataTable temp;
        string Query;

        // KONSTRUKTOR
        public UsersClass()
        {
            id_users = "";
            nama_users = "";
            email_users = "";
            username = "";
            password = "";
            jenis_kelamin = "";
            no_hp = "";
            role = "";
            alamat = "";
            koneksi = new koneksiClass();
            temp = new DataTable();
            Query = "";
        }

        // PROPERTI
        public string Id_users
        {
            set { id_users = value; }
            get { return id_users; }
        }
        public string Nama_users
        {
            set { nama_users = value; }
            get { return nama_users; }
        }
        public string Email_users
        {
            set { email_users = value; }
            get { return email_users; }
        }
        public string Username
        {
            set { username = value; }
            get { return username; }
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public string Jenis_kelamin
        {
            set { jenis_kelamin = value; }
            get { return jenis_kelamin; }
        }
        public string No_hp
        {
            set { no_hp = value; }
            get { return no_hp; }
        }
        public string Role
        {
            set { role = value; }
            get { return role; }
        }
        public string Alamat
        {
            set { alamat = value; }
            get { return alamat; }
        }

        // METHOD

        // MENCARI ID USER 
        public bool ApakahAda(string kode)
        {
            bool cek = false;
            Query = "SELECT * FROM users WHERE id_user = '" + kode + "'";

            temp = koneksi.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        // MENAMPILKAN SEMUA DATA 
        public DataTable TampilkanSemua()
        {
            Query = "SELECT id_user, nama, username, password, role, email, jenis_kelamin, no_hp, alamat FROM users;";
            return koneksi.eksekusiQuery(Query);
        }

        // KETIKA SEARCH NAMA KOSONG
        public DataTable SearchKosong()
        {
            Query = "SELECT nama, username, password, role, email, jenis_kelamin, no_hp, alamat FROM users;";
            return koneksi.eksekusiQuery(Query);
        }

        // MENCARI NAMA
        public DataTable cariDgNama(string nama)
        {
            Query = "SELECT nama, username, password, role, email, jenis_kelamin, no_hp, alamat FROM users WHERE nama LIKE '%" + nama + "%'";
            return koneksi.eksekusiQuery(Query);
        }

        // MENAMBAH DATA USERS 
        public int SimpanData()
        {
            int result = -1;
             Query = "INSERT INTO users (username, password, nama, role, alamat, jenis_kelamin, no_hp, email)" +
                     " VALUES('" + username + "','" + password + "','" + nama_users + "','" + role + "','" + alamat + "','" + jenis_kelamin + "','" + no_hp + "','" + email_users + "')";


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

        // MENGUPDATE DATA USERS
        public int UbahData(string kode)
        {
            int result = -1;
            Query = "UPDATE users SET nama='" + nama_users + "'," +
                " email='" + email_users + "'," +
                " role='" + role + "'," +
                " jenis_kelamin='" + jenis_kelamin + "'," +
                " alamat='" + alamat + "'," +
                " no_hp='" + no_hp + "'" +
                " WHERE id_user = '" + kode + "'";

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


        // MENGHAPUS DATA 
        public int hapusData(string kode)
        {
            int result = -1;

            Query = "DELETE FROM users WHERE id_user = '" + kode + "'";
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


        public double TotalUser()
        {
            string query = "SELECT COUNT(id_user) FROM users";
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
