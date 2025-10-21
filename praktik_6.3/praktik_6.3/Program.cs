using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi variabel untuk menyimpan input
            string inputUser = "";

            Console.WriteLine("program akan terus berjalan hingga Anda mengetik 'keluar'.");

            //Perulangan selama isi variabel inputUser TIDAK SAMA DENGAN "keluar"
            while (inputUser.ToLower() != "keluar")
            {
                Console.Write("\nKetik sesuatu (atau 'keluar' untuk berhenti): ");
                inputUser = Console.ReadLine(); // Data input dari user

                Console.WriteLine("Anda megetik: " + inputUser);
            }

                Console.WriteLine("\nProgram selessai. Terima Kasih");
        }
    }
}
