using System;
using System.Collections.Generic;
using System.Text;

namespace OOPKasir
{
    public class Makanan
    {
        public string namaMakanan { get; set; }
        public int hargaMakanan { get; set; }
        public int stokMakanan { get; set; }

        public Makanan(string namaMakanan, int hargaMakanan, int stokMakanan)
        {
            this.namaMakanan = namaMakanan;
            this.hargaMakanan = hargaMakanan;
            this.stokMakanan = stokMakanan;
        }
    }
}
