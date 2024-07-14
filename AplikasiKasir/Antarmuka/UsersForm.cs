using AplikasiKasir.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace AplikasiKasir.Antarmuka
{
    public partial class UsersForm : Form
    {
        UsersClass users = new UsersClass();

        public UsersForm()
        {
            InitializeComponent();
            tampilGrid();
            munculJK();
            munculRole();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            // Kosongkan jika tidak ada yang perlu ditambahkan
        }

        void tampilGrid()
        {
            if (search_txt.Text == "")
            {
                // Ambil semua data dari database
                DataTable dataTable = users.TampilkanSemua();

                // Tambahkan kolom "No" jika belum ada
                if (!dataTable.Columns.Contains("No"))
                {
                    dataTable.Columns.Add("No", typeof(int));
                }

                // Isi kolom "No" dengan nomor urut
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["No"] = i + 1;
                }

                // Set DataSource dari DataGridView
                database_users.DataSource = dataTable;

                // Sembunyikan kolom "id_user"
                if (database_users.Columns.Contains("id_user"))
                {
                    database_users.Columns["id_user"].Visible = false;
                }

            }
            else
            {
                // Ambil semua data dari database
                DataTable dataTable = users.cariDgNama(search_txt.Text);

                // Tambahkan kolom "No" jika belum ada
                if (!dataTable.Columns.Contains("No"))
                {
                    dataTable.Columns.Add("No", typeof(int));
                }

                // Isi kolom "No" dengan nomor urut
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i]["No"] = i + 1;
                }
                // Ambil data berdasarkan pencarian
                database_users.DataSource = dataTable;
            }
        }

        private void tambahusers_btn_Click(object sender, EventArgs e)
        {
            TambahUsersForm FormTambah = new TambahUsersForm();

            FormTambah.ShowDialog();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void database_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.database_users.Rows[e.RowIndex];
                idUsers_lbl.Text = baris.Cells[0].Value.ToString();
                nama_txt.Text = baris.Cells[1].Value.ToString();
                email_txt.Text = baris.Cells[5].Value.ToString();
                noHp_txt.Text = baris.Cells[7].Value.ToString();
                alamat_rtb.Text = baris.Cells[8].Value.ToString();
                role_cmb.Text = baris.Cells[4].Value.ToString();
                jenis_cmb.Text = baris.Cells[6].Value.ToString();

                nama_txt.SelectAll();
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            users.Id_users = idUsers_lbl.Text;
            users.Nama_users = nama_txt.Text;
            users.Email_users = email_txt.Text;
            users.Role = role_cmb.Text;
            users.Jenis_kelamin = jenis_cmb.Text;
            users.No_hp = noHp_txt.Text;
            users.Alamat = alamat_rtb.Text;

            if (users.ApakahAda(idUsers_lbl.Text))
            {
                if (users.UbahData(idUsers_lbl.Text) >= 0)
                {
                    MessageBox.Show("Data Berhasil diubah",
                        "INFORMASI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    nama_txt.Focus();
                    tampilGrid();
                    bersihkan();
                }
                else
                {
                    MessageBox.Show("Data tidak Valid",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    nama_txt.Focus();
                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (users.ApakahAda(idUsers_lbl.Text))
            {
                if (MessageBox.Show("Apakah yakin dihapus?", "KONFIRMASI",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    users.Id_users= idUsers_lbl.Text;
                    if (users.hapusData(idUsers_lbl.Text) >= 0)
                    {
                        MessageBox.Show("Data Berhasil dihapus",
                            "INFORMASI",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        nama_txt.Focus();
                        tampilGrid();
                        bersihkan();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak Valid",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        nama_txt.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Data Tidak Ada",
                    "INFORMASI",
                    MessageBoxButtons.OK);
            }
        }


        private void reflash_btn_Click(object sender, EventArgs e)
        {
            tampilGrid();
        }

        void bersihkan()
        {
            nama_txt.Clear();
            email_txt.Clear();
            role_cmb.Items.Clear();
            jenis_cmb.Items.Clear();
            noHp_txt.Clear();
            alamat_rtb.Clear();

            munculRole();
            munculJK();
        }

        void munculRole()
        {
            role_cmb.Items.Add("Admin");
            role_cmb.Items.Add("Kasir");
            role_cmb.Items.Add("Pegawai");
        }

        void munculJK()
        {
            jenis_cmb.Items.Add("Laki-laki");
            jenis_cmb.Items.Add("Perempuan");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bersihkan();
        }
    }
}
