using System;
using System.Collections.Generic;
using System.Text;

namespace OOPKasir
{
    public class Minuman
    {
        public string namaMinuman { get; set; }
        public int hargaMinuman { get; set; }
        public int stokMinuman { get; set; }

        public Minuman(string namaMinuman, int hargaMinuman, int stokMinuman)
        {
            this.namaMinuman = namaMinuman;
            this.hargaMinuman = hargaMinuman;
            this.stokMinuman = stokMinuman;
        }

    }
}
