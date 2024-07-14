using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AplikasiKasir.Antarmuka
{
    public partial class DashboardForm : Form
    {
        UsersForm users = new UsersForm();
        BarangForm barang = new BarangForm();
        LaporanForm laporan = new LaporanForm();
        HomeForm home = new HomeForm();

        public string UserName
        {
            get { return users_lbl.Text; }
            set { users_lbl.Text = value; }
        }

        public DashboardForm()
        {
            InitializeComponent();
            home.TopLevel = false;
            IsiPanel.Controls.Add(home);
            home.Show();
        }



        private void DashboardForm_Load(object sender, EventArgs e)
        {
            home.TopLevel = false;
            IsiPanel.Controls.Add(home);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Ingin LogOut?", "INFORMASI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            users.TopLevel = false;
            IsiPanel.Controls.Add(users);
            users.Show();
            barang.Hide();
            laporan.Hide();
            home.Hide();
        }

        private void barang_btn_Click(object sender, EventArgs e)
        {
            barang.TopLevel = false;
            IsiPanel.Controls.Add(barang);
            barang.Show();
            users.Hide();
            laporan.Hide();
            home.Hide();
        }

        private void laporan_btn_Click(object sender, EventArgs e)
        {
            laporan.TopLevel = false;
            IsiPanel.Controls.Add(laporan);
            laporan.Show();
            users.Hide();
            barang.Hide();
            home.Hide();
        }

        private void Aplikasi_Click(object sender, EventArgs e)
        {
            home.TopLevel = false;
            IsiPanel.Controls.Add(home);
            home.Show();
            users.Hide();
            barang.Hide();
            laporan.Hide();
        }


        private void transaksi_btn_Click(object sender, EventArgs e)
        {
            TransaksiForm transaksi = new TransaksiForm();
            transaksi.UserName = this.UserName;
            transaksi.Show();
            this.Hide();
        }

    }
        
}
