using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AplikasiKasir.Konfigurasi
{
    internal class koneksiClass : konfigurasiClass
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        string link = "server=localhost;port=3306;database=kasir;uid=root;pwd=";

        public koneksiClass()
        {
            con = new MySqlConnection(link);
            cmd = new MySqlCommand();
            adapter = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {

            }
        }

        void tutupKoneksi()
        {
            con.Close();

        }
        public override int eksekusiNonQuery(string query)
        {
            int result = -1;
            try
            {
                bukaKoneksi();
                cmd.Connection = con;
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();

            }
            catch (System.Exception ex) { }
            finally { tutupKoneksi(); }
            return result;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable result = new DataTable();
            try
            {
                bukaKoneksi();
                cmd.Connection = con;
                cmd.CommandText = query;
                adapter.SelectCommand = cmd;
                adapter.Fill(result);

            }
            catch (System.Exception ex) { }
            finally { tutupKoneksi(); }
            return result;
        }
    }
}
