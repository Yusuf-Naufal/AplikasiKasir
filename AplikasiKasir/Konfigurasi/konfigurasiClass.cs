using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiKasir.Konfigurasi
{
    abstract class konfigurasiClass
    {
        //Method untuk menangani intruksi INSERT, UPDATE, DELETE 
        public abstract int eksekusiNonQuery(string query);

        //Method untuk menangani instruksi SELECT
        public abstract DataTable eksekusiQuery(string query);
    }
}
