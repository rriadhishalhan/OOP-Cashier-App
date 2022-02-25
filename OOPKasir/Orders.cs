using System;
using System.Collections.Generic;
using System.Text;

namespace OOPKasir
{
    public class Orders
    {
        public string namaBarang { get; set; }
        public int hargaBarang { get; set; }
        public int jumlahBarang { get; set; }
        public int hargaOrder { get; set; }

        public Orders(string namaBarang, int hargaBarang, int jumlahBarang)
        {
            this.namaBarang = namaBarang;
            this.hargaBarang = hargaBarang;
            this.jumlahBarang = jumlahBarang;
            this.hargaOrder = hargaBarang * jumlahBarang;
        }
    }
}
