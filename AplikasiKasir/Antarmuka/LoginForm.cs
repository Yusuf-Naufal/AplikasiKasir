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
    public partial class LoginForm : Form
    {
        LoginClass login = new LoginClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        //CEK LOGIN [APAKAH DATA BENAR / TIDAK]
        private void login_btn_Click(object sender, EventArgs e)
        {
            String user = username_txt.Text;
            String pass = password_txt.Text;

            if (login.cekUser(user, pass))
            {
                string userName = login.ambilNama(user, pass);

                // MENAMPILKAN NAMA PADA DASHBOARD
                DashboardForm dashboard = new DashboardForm();
                dashboard.UserName = userName;
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf Username Atau Password Salah!",
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                password_txt.Clear();
                username_txt.SelectAll();
                username_txt.Focus();
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Ingin Keluar?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
