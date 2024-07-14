using AplikasiKasir.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir.Antarmuka
{
    public partial class TambahUsersForm : Form
    {
        UsersClass users = new UsersClass();
        public TambahUsersForm()
        {
            InitializeComponent();
            
        }

        private void TambahUsersForm_Load(object sender, EventArgs e)
        {
            munculJK();
            munculRole();
            inRole_cmb.SelectedIndex = -1;
            inJenis_cmb.SelectedIndex = -1;
        }

        private void TambahUsers_btn_Click(object sender, EventArgs e)
        {
            // Pengecekan apakah semua field telah diisi
            if (string.IsNullOrWhiteSpace(inName_txt.Text) ||
                string.IsNullOrWhiteSpace(inEmail_txt.Text) ||
                string.IsNullOrWhiteSpace(inUsername_txt.Text) ||
                string.IsNullOrWhiteSpace(inPassword_txt.Text) ||
                string.IsNullOrWhiteSpace(inRole_cmb.Text) ||
                string.IsNullOrWhiteSpace(inJenis_cmb.Text) ||
                string.IsNullOrWhiteSpace(inNomer_txt.Text) ||
                string.IsNullOrWhiteSpace(inAlamat_rtb.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set data ke objek users
            users.Nama_users = inName_txt.Text;
            users.Email_users = inEmail_txt.Text;
            users.Username = inUsername_txt.Text;
            users.Password = inPassword_txt.Text;
            users.Role = inRole_cmb.Text;
            users.Jenis_kelamin = inJenis_cmb.Text;
            users.No_hp = inNomer_txt.Text;
            users.Alamat = inAlamat_rtb.Text;

            // Simpan data
            if (users.SimpanData() >= 0)
            {
                MessageBox.Show("Data berhasil disimpan.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inName_txt.Focus();
                bersihkan();
            }
            else
            {
                MessageBox.Show("Data tidak valid.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inName_txt.Focus();
            }
        }


        void bersihkan()
        {
            inAlamat_rtb.Clear();
            inEmail_txt.Clear();
            inName_txt.Clear();
            inNomer_txt.Clear();
            inPassword_txt.Clear();
            inUsername_txt.Clear();
            inRole_cmb.Items.Clear();
            inJenis_cmb.Items.Clear();

            munculJK();
            munculRole();
        }

        void munculRole()
        {
            inRole_cmb.Items.Add("Admin");
            inRole_cmb.Items.Add("Kasir");
            inRole_cmb.Items.Add("Pegawai");
        }

        void munculJK()
        {
            inJenis_cmb.Items.Add("Laki-laki");
            inJenis_cmb.Items.Add("Perempuan");
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            bersihkan();
        }
    }
}
