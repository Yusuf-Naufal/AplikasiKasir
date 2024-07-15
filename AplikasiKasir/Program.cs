using AplikasiKasir.Antarmuka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiKasir
{
    internal static class Program
    {
        //TUGAS UAS PBO KELAS TI - 2B 
        //NAMA KELOMPOK 
        //1. Al-Husna a Nanda Kurnia (220302025)
        //2. Farah Nada Syahidah (220302034)
        //3. Lintang Ayu Kinasih Azzahro (220302039)
        //4. Yusuf Naufal Zuhdi (220302047)
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
