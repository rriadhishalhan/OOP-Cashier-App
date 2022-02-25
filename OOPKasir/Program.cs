using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OOPKasir
{
    class Program
    {
        static void etalase(List<Orders> daftarPesanan)
        {
            if (!daftarPesanan.Any())
            {
                Console.Clear();
                Console.WriteLine("=============== MENU ===============");
                Console.WriteLine("1 . Minuman");
                Console.WriteLine("2 . Makanan");
                Console.WriteLine("0 . EXIT");
                Console.WriteLine("====================================");
                Console.Write("Pilih opsi : ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("=============== MENU ===============");
                Console.WriteLine("1 . Minuman");
                Console.WriteLine("2 . Makanan");
                Console.WriteLine("3 . Lanjut Pembayaran");
                Console.WriteLine("====================================");
                Console.Write("Pilih opsi : ");
            }

        }
        static void subMenu(int opsi, List<Orders> daftarPesanan)
        {
            switch (opsi)
            {
                case 1:
                    menuMinuman(daftarPesanan);
                    break;
                case 2:
                    menuMakanan(daftarPesanan);
                    break;
                default:
                    if (!daftarPesanan.Any())
                    {
                        Console.WriteLine("TERIMA KASIH!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("_____________Berikut pesanan anda______________");
                        break;
                    }



            }
        }
        static int TotalMenuMinuman(int opsi, int qty)
        {
            if (opsi == 1)
            {
                return 5000 * qty;
            }
            else if (opsi == 2)
            {
                return 8000 * qty;
            }
            else if (opsi == 3)
            {
                return 2000 * qty;
            }
            else
            {
                return 0;
            }
        }
        static void menuMinuman(List<Orders> daftarPesanan)
        {
            Console.Clear();
            Console.WriteLine("=========== MENU MINUMAN ===========");
            Console.WriteLine("1. ES SODA   - Rp.5000");
            Console.WriteLine("2. ES JERUK  - Rp.8000");
            Console.WriteLine("3. ES TEH    - Rp.2000");
            Console.WriteLine("====================================");
            Console.Write("Pilih opsi : ");
            int opsi = Convert.ToInt32(Console.ReadLine());
            if (opsi > 3)
            {
                Console.WriteLine("Barang Tidak ada");
            }
            else
            {
                Console.Write("Berapa Banyak : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                int harga = TotalMenuMinuman(opsi, qty);

                daftarPesanan.Add(new Orders(findNamaMinuman(opsi), harga, qty));

            }


        }
        static int TotalMenuMakanan(int opsi, int qty)
        {
            if (opsi == 1)
            {
                return 10000 * qty;
            }
            else if (opsi == 2)
            {
                return 15000 * qty;
            }
            else if (opsi == 3)
            {
                return 12000 * qty;
            }
            else
            {
                return 0;
            }
        }
        static void menuMakanan(List<Orders> daftarPesanan)
        {
            Console.Clear();
            Console.WriteLine("=========== MENU MAKANAN ===========");
            Console.WriteLine("1. NASI GORENG  - Rp.10.000");
            Console.WriteLine("2. MIE AYAM     - Rp.15.000");
            Console.WriteLine("3. SOTO KUDUS   - Rp.12.000");
            Console.WriteLine("====================================");
            Console.Write("Pilih opsi : ");
            int opsi = Convert.ToInt32(Console.ReadLine());
            if (opsi > 3)
            {
                Console.WriteLine("Barang Tidak ada");
            }
            else
            {
                Console.Write("Berapa Banyak : ");
                int qty = Convert.ToInt32(Console.ReadLine());
                int harga = TotalMenuMakanan(opsi, qty);

                daftarPesanan.Add(new Orders(findNamaMakanan(opsi), harga, qty));

            }
        }

        static string findNamaMinuman(int opsi)
        {
            switch (opsi)
            {
                case 1:
                    return "Es Soda";
                case 2:
                    return "Es Jeruk";
                case 3:
                    return "Es Teh";
                default:
                    return "Tidak ditemukan";
            }
        }

        static string findNamaMakanan(int opsi)
        {
            switch (opsi)
            {
                case 1:
                    return "Nasi Goreng";
                case 2:
                    return "Mie Ayam";
                case 3:
                    return "Soto Kudus";
                default:
                    return "Tidak ditemukan";
            }
        }

        static void MenuAdmin()
        {
            Console.Clear();
            Console.WriteLine("=============== ADMIN ===============");
            Console.WriteLine("1 . Minuman");
            Console.WriteLine("2 . Makanan");
            Console.WriteLine("0 . EXIT");
            Console.WriteLine("====================================");
        }

        static void subMenuAdmin(int opsi, List<Minuman> daftarMinuman, List<Makanan> daftarMakanan)
        {
            switch (opsi)
            {
                case 1:
                    SubMenuMinumanAdmin(daftarMinuman);
                    break;
                case 2:
                    SubMenuMakananAdmin(daftarMakanan);
                    break;
                default:
                    Console.WriteLine("TERIMA KASIH!");
                    break;



            }
        }

        /// MINUMAN
        static void SubMenuMinumanAdmin(List<Minuman> daftarMinuman)
        {
            Console.Clear();
            Console.WriteLine("=============== ADMIN ===============");
            Console.WriteLine("1. Lihat Minuman");
            Console.WriteLine("2. Tambah Minuman");
            Console.WriteLine("3. Ubah Ketersediaan Minuman");
            Console.WriteLine("4. Hapus Minuman");
            Console.WriteLine("5. Kembali");
            Console.WriteLine("====================================");
            Console.Write("Pilih opsi : ");
            int opsi = Convert.ToInt32(Console.ReadLine());
            OpsiSubMenuAdminMinuman(opsi, daftarMinuman);
        }
        static void OpsiSubMenuAdminMinuman(int opsi, List<Minuman> daftarMinuman)
        {
            switch (opsi)
            {
                case 0:
                    SubMenuMinumanAdmin(daftarMinuman);
                    break;
                case 1:
                    showMinuman(daftarMinuman);
                    break;
                case 2:
                    AddMinuman(daftarMinuman);
                    break;
                case 3:
                    EditQtyMinuman(daftarMinuman);
                    break;
                case 4:
                    deleteMinuman(daftarMinuman);
                    break;
                default:
                    break;
            }

        }


        static void showMinuman(List<Minuman> daftarMinuman)
        {
            int num;
            string jawaban = "n";

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MINUMAN ============");
                for (int i = 0; i < daftarMinuman.Count; i++)
                {
                    Console.WriteLine(num + ". " + daftarMinuman[i].namaMinuman + ", Harga Rp." + daftarMinuman[i].hargaMinuman + ", Stok " + daftarMinuman[i].stokMinuman);
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();

                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMinuman(opsi, daftarMinuman);
                }
                else
                {
                    jawaban = "n";
                }

            }

        }
        static void AddMinuman(List<Minuman> daftarMinuman)
        {
            string jawaban = "n";

            while (jawaban == "n")
            {
                Console.Clear();
                Console.WriteLine("========== TAMBAH MINUMAN ============");
                Console.Write("Nama Minuman        :"); string nama = Console.ReadLine();
                Console.Write("Harga Minuman       :"); int harga = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kuantitas Minuman   :"); int stok = Convert.ToInt32(Console.ReadLine());
                daftarMinuman.Add(new Minuman(nama, harga, stok));
                Console.WriteLine("======================================");

                Console.WriteLine("\n Item telah berhasil ditambah");
                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();

                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMinuman(opsi, daftarMinuman);
                }
                else
                {
                    jawaban = "n";
                }
            }


        }
        static void EditQtyMinuman(List<Minuman> daftarMinuman)
        {
            string jawaban = "n";
            int num;

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MINUMAN ============");
                for (int i = 0; i < daftarMinuman.Count; i++)
                {
                    Console.WriteLine(num + ". " + daftarMinuman[i].namaMinuman + ", Harga Rp." + daftarMinuman[i].hargaMinuman + ", Stok " + daftarMinuman[i].stokMinuman);
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Nomor item yang ingin diubah? : ");
                int noItem = Convert.ToInt32(Console.ReadLine());
                if (noItem != 0)
                {
                    Console.Write("Jumlah Ketersidaan baru : ");
                    int newQtyMinuman = Convert.ToInt32(Console.ReadLine());
                    daftarMinuman[noItem - 1].stokMinuman = newQtyMinuman;
                    Console.WriteLine("Ketersidaan berhasil diubah");
                }
                else
                {
                    Console.WriteLine("Data tidak ditemukan");
                }

                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();
                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMinuman(opsi, daftarMinuman);
                }
                else
                {
                    jawaban = "n";
                }
            }
        }
        static void deleteMinuman(List<Minuman> daftarMinuman)
        {
            string jawaban = "n";
            int num;

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MINUMAN ============");
                for (int i = 0; i < daftarMinuman.Count; i++)
                {
                    Console.WriteLine(num + ". " + daftarMinuman[i].namaMinuman + ", Harga Rp." + daftarMinuman[i].hargaMinuman + ", Stok " + daftarMinuman[i].hargaMinuman);
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Nomor item yang ingin dihapus? : ");
                int noItem = Convert.ToInt32(Console.ReadLine());
                if (noItem != 0)
                {                   
                    daftarMinuman.RemoveAt(noItem - 1);
                    Console.WriteLine("Item berhasil dihapus");
                }
                else
                {
                    Console.WriteLine("Data tidak ditemukan");
                }

                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();
                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMinuman(opsi, daftarMinuman);
                }
                else
                {
                    jawaban = "n";
                }
            }

        }


        ///MAKANAN//

        static void SubMenuMakananAdmin(List<Makanan> daftarMakanan)
        {
            Console.Clear();
            Console.WriteLine("=============== ADMIN ===============");
            Console.WriteLine("1. Lihat Makanan");
            Console.WriteLine("2. Tambah Makanan");
            Console.WriteLine("3. Ubah Ketersediaan Makanan");
            Console.WriteLine("4. Hapus Makanan");
            Console.WriteLine("5. Kembali");
            Console.WriteLine("====================================");
            Console.Write("Pilih opsi : ");
            int opsi = Convert.ToInt32(Console.ReadLine());
            OpsiSubMenuAdminMakanan(opsi, daftarMakanan);
        }
        static void OpsiSubMenuAdminMakanan(int opsi, List<Makanan> daftarMakanan)
        {
            switch (opsi)
            {
                case 0:
                    SubMenuMakananAdmin(daftarMakanan);
                    break;
                case 1:
                    showMakanan(daftarMakanan);
                    break;
                case 2:
                    AddMakanan(daftarMakanan);
                    break;
                case 3:
                    EditQtyMakanan(daftarMakanan);
                    break;
                case 4:
                    deleteMakanan(daftarMakanan);
                    break;
                default:
                    break;
            }

        }

        static void showMakanan(List<Makanan> daftarMakanan)
        {
            int num;
            string jawaban = "n";

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MAKANAN ============");
                for (int i = 0; i < daftarMakanan.Count; i++)
                {
                    Console.WriteLine($"{num}. {daftarMakanan[i].namaMakanan} Harga Rp. {daftarMakanan[i].hargaMakanan} Stok {daftarMakanan[i].stokMakanan}");
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();

                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMakanan(opsi, daftarMakanan);
                }
                else
                {
                    jawaban = "n";
                }

            }

        }
        static void AddMakanan(List<Makanan> daftarMakanan)
        {
            string jawaban = "n";

            while (jawaban == "n")
            {
                Console.Clear();
                Console.WriteLine("========== TAMBAH MAKANAN ============");
                Console.Write("Nama Makanan        :"); string nama = Console.ReadLine();
                Console.Write("Harga Makanan       :"); int harga = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kuantitas Makanan   :"); int stok = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("======================================");

                daftarMakanan.Add(new Makanan(nama, harga, stok));
                Console.WriteLine("\n Item telah berhasil ditambah");
                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();

                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMakanan(opsi, daftarMakanan);
                }
                else
                {
                    jawaban = "n";
                }
            }


        }
        static void EditQtyMakanan(List<Makanan> daftarMakanan)
        {
            string jawaban = "n";
            int num;

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MAKANAN ============");
                for (int i = 0; i < daftarMakanan.Count; i++)
                {
                    Console.WriteLine($"{num}. {daftarMakanan[i].namaMakanan} Harga Rp. {daftarMakanan[i].hargaMakanan} Stok {daftarMakanan[i].stokMakanan}");
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Nomor item yang ingin diubah? : ");
                int noItem = Convert.ToInt32(Console.ReadLine());
                if (noItem != 0)
                {
                    Console.Write("Jumlah Ketersidaan baru : ");
                    int newQtyMakanan = Convert.ToInt32(Console.ReadLine());
                    daftarMakanan[noItem - 1].stokMakanan = newQtyMakanan;
                    Console.WriteLine("Ketersidaan berhasil diubah");
                }
                else
                {
                    Console.WriteLine("Data tidak ditemukan");
                }

                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();
                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMakanan(opsi, daftarMakanan);
                }
                else
                {
                    jawaban = "n";
                }
            }
        }
        static void deleteMakanan(List<Makanan> daftarMakanan)
        {
            string jawaban = "n";
            int num;

            while (jawaban == "n")
            {
                Console.Clear();
                num = 1;
                Console.WriteLine("========== DAFTAR MAKANAN ============");
                for (int i = 0; i < daftarMakanan.Count; i++)
                {
                    Console.WriteLine($"{num}. {daftarMakanan[i].namaMakanan} Harga Rp. {daftarMakanan[i].hargaMakanan} Stok {daftarMakanan[i].stokMakanan}");
                    num += 1;
                }

                Console.WriteLine("======================================");
                Console.Write("Nomor item yang ingin dihapus? : ");
                int noItem = Convert.ToInt32(Console.ReadLine());
                if (noItem != 0)
                {
                    daftarMakanan.RemoveAt(noItem - 1);
                    Console.WriteLine("Item berhasil dihapus");
                }
                else
                {
                    Console.WriteLine("Data tidak ditemukan");
                }

                Console.Write("Kembali kehalaman sebelumnya? (y/n) : ");
                jawaban = Console.ReadLine();
                if (jawaban == "y")
                {
                    int opsi = 0;
                    OpsiSubMenuAdminMakanan(opsi, daftarMakanan);
                }
                else
                {
                    jawaban = "n";
                }
            }

        }

        static void Main(string[] args)
        {
            List<Minuman> daftarMinuman = new List<Minuman>();
            daftarMinuman.Add(new Minuman("Es Soda", 7000, 50));
            daftarMinuman.Add(new Minuman("Es Teh", 2000, 30));
            daftarMinuman.Add(new Minuman("Es Jeruk", 8000, 20));
            daftarMinuman.Add(new Minuman("Es Mangga", 9000, 40));

            List<Makanan> daftarMakanan = new List<Makanan>();
            daftarMakanan.Add(new Makanan("Nasi Goreng", 7000, 50));
            daftarMakanan.Add(new Makanan("Nasi Uduk", 2000, 30));
            daftarMakanan.Add(new Makanan("Mie Ayam", 8000, 20));
            daftarMakanan.Add(new Makanan("Mie Yamin", 9000, 40));


            string userAdmin = "admin";
            string passAdmin = "123";

            List<Orders> daftarPesanan = new List<Orders>();


           

            Console.Write("Masukan Username: "); string username = Console.ReadLine();
            Console.Write("Masukan Password: "); string passwword = Console.ReadLine();

            if (username == userAdmin && passwword == passAdmin)
            {
                int opsi = 1;
                while (opsi >= 1 && opsi <= 2)
                {
                    MenuAdmin();
                    opsi = Convert.ToInt32(Console.ReadLine());
                    subMenuAdmin(opsi, daftarMinuman, daftarMakanan);
                }
            }
            else
            {
                int opsi = 1;
                while (opsi >= 1 && opsi <= 2)
                {
                    etalase(daftarPesanan);

                    opsi = Convert.ToInt32(Console.ReadLine());

                    subMenu(opsi, daftarPesanan);

                    if (!daftarPesanan.Any())
                    {

                        Console.WriteLine("");

                    }
                    else
                    {
                        Console.WriteLine("================= INVOICE =====================");
                        int j = 1;
                        int total = 0;

                        for (int i = 0; i < daftarPesanan.Count; i++)
                        {
                            Console.WriteLine($"{j}. {daftarPesanan[i].namaBarang} Rp.{daftarPesanan[i].hargaBarang} x {daftarPesanan[i].jumlahBarang} = Rp.{daftarPesanan[i].hargaOrder}");
                            total = total + daftarPesanan[i].hargaOrder;
                            j += 1;
                        }
                        Console.WriteLine("===============================================");
                        Console.WriteLine("Jumlah yang harus dibayar adalah Rp." + total);
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");
                    }


                }
            }






        }
    }
}
