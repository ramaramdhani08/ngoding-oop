using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIS13
{
    class Program
    {
        static void Main(string[] args)
        {
            //pendaftaran anggota perpus
            Console.Write("NPM : "); string _npm = Console.ReadLine();
            Console.Write("NAMA : "); string _nama = Console.ReadLine();
            Console.Write("ALAMAT : "); string _alamat = Console.ReadLine();
            Console.Write("URL FOTO : "); string _urlfoto = Console.ReadLine();
            Console.Write("KODE : "); string _kode = Console.ReadLine();
        
            // BUAT OBJEK ANGGOTA PERPUS
            AnggotaPerpus anggota1 = new AnggotaPerpus(_npm, _nama, _alamat, _urlfoto, _kode);

            //TAMPILKAN INFORMASI
            anggota1.TampilkanDataAnggota();
            
            //anggota perpus melakuka login
            Console.Write("MASUKKAN KODE : "); string _KodeMasukan = Console.ReadLine();
            
            // penegcekan login
            bool hasillogin = anggota1.Login(_KodeMasukan);
            
            if(hasillogin == true )
            {
                Console.WriteLine("SELAMAT DATANG");
            }
            else
            {
                Console.WriteLine("KODE SALAH");
            }

            #region peminjaman buku
            //masukan judul buku yang dipinjam
            Console.Write("MASUKKAN KODE ANDA : "); string _kodeuntukPinjam = Console.ReadLine();
            
            //akses fungsi peminjaman
            if(anggota1.PinjamBuku(_kodeuntukPinjam) == true)
            {
                //input judul buku
                Console.Write("Masukkan Judul Buku yang Dipinjam : "); string _judul = Console.ReadLine();
                anggota1.Judul = _judul;

            }
            else
            {
                // gagal pinjam
                Console.WriteLine("KODE ANDA SALAH, ANDA TIDAK DAPAT MEMINJAM BUKU!!!!");

            }

            #endregion
            
            //tampilkan data buku pinjaman
            anggota1.TampilkanDataPinjaman();

            Console.ReadKey();
        }
    }
}
