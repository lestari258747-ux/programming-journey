using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilihan;

            do
            {
                // Tampilkan menu
                Console.WriteLine("\n=== Menu Aplikasi ===");
                Console.WriteLine("1. Lihat Data");
                Console.WriteLine("1. Tambah Data");
                Console.WriteLine("1. keluar");
                Console.Write("Masukkan pilihan Anda (1-3): ");

                // Baca input pengguna
                if (!int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("Pilihan tidak valid. Harap masukkan angka 1, 2, atau 3.");
                    // Tetapkan nilai selain 3 agar loop berlanjut
                    pilihan = 0;
                    continue;
                }

                // Proses pilihan 
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Anda memilih: Lihat Data.");
                        break;
                    case 2:
                        Console.WriteLine("Anda memilih: Tambah Data.");
                        break;
                    case 3:
                        Console.WriteLine("Program akan berhenti...");
                        break;
                    default: // Keluar dari switch
                        Console.WriteLine("Pilihan di luar jangkauan. Harap masukkan 1, 2, atau 3.");
                        break;
                }
                // Kondisi loop: lanjutkan selama pilihn BUKAN 3.
            } while (pilihan != 3);
            Console.WriteLine("Terima kasih telah menggunakan aplikasi.");
            }
    }
}
