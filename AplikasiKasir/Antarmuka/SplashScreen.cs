using AplikasiKasir.Antarmuka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir
{
    public partial class SplashScreen : Form
    {
        //DEKLARASI COUNT
        byte waktu = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Lama_muncul_Tick(object sender, EventArgs e)
        {
            waktu++;
            if (waktu == 2)
            {
                Lama_muncul.Enabled = false;
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}
