using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Inisialisasi variabe penghitung (counter)
            int angka = 1;

            Console.WriteLine("Menampilkan angka 1 sampai 20:");

            //2. Blok 'do-while'
            {
                // Tampilkan nilai variabel 'angka' saat ini 
                Console.WriteLine(angka);

                // Tambahkan nilai 'angka' sebanyak 1 (icrement)
                angka++;

                // Uji kondisi: loop berlanjut selama 'angka' kurang dari atau sama dengan 
            } while (angka <= 20) ;

            Console.WriteLine("Selesai.");
        }
    }
}
