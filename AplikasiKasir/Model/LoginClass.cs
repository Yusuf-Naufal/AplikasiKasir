using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplikasiKasir.Konfigurasi;

namespace AplikasiKasir.Model
{
    internal class LoginClass
    {
        private string id_user;
        private string password;

        koneksiClass koneksi;
        DataTable temp;
        string query;

        public LoginClass()
        {
            id_user = "";
            password = "";
            koneksi = new koneksiClass();
            temp = new DataTable();
            query = "";
        }

        public string Id_user
        {
            set { id_user = value; }
        }

        public string Password
        {
            set { password = value; }
        }

        public bool cekUser(string user, string pass)
        {
            bool cek = false;
            query = "SELECT * FROM users where username='" + user + "' AND password='" + pass + "'";
            temp = koneksi.eksekusiQuery(query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public string ambilNama(string user, string pass)
        {
            string nama = "";
            query = "SELECT nama FROM users WHERE username='" + user + "' AND password='" + pass + "'";
            temp = koneksi.eksekusiQuery(query);

            if (temp.Rows.Count > 0)
            {
                foreach (DataRow row in temp.Rows)
                {
                    nama = row[0].ToString();
                }
            }
            return nama;
        }
    }
}
