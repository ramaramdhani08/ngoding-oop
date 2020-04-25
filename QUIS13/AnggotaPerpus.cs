using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIS13
{
    class AnggotaPerpus : Mahasiswa
    {
        #region atribute
        private string kode;
        private string judulbukuyangdipinjam;
        #endregion

        #region properties
        public string Kode
        {
            get
            {
                return this.kode;
            }
            set
            {
                this.kode = value;
            }
        }

        public string Judul
        {
            get
            {
                return this.judulbukuyangdipinjam;
            }
            set
            {
                this.judulbukuyangdipinjam = value;
            }
        }
        #endregion

        #region constructor
        public AnggotaPerpus(string _npm, string _nama, string _alamat, string _urlfoto, string _kode)
        {
            //informasi yang dimasukkan untuk class anggota perpus
            this.NPM = _npm;
            this.Nama = _nama;
            this.Alamat = _alamat;
            this.URLFoto = _urlfoto;

            //informasi yang dimasukkan untuk class anggota perpus
            this.Kode = _kode;
        }
        #endregion

        #region fungsi
        public bool Login(string KodeMasukan)
        {
            bool balikan = false;
            if (KodeMasukan == this.kode) balikan = true;
            return balikan;
        }

        public void TampilkanDataAnggota()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("INFORMASI ANGGOTA PERPUS");
            Console.WriteLine("NPM : " + this.NPM);
            Console.WriteLine("NAMA : " + this.Nama);
            Console.WriteLine("ALAMAT : " + this.Alamat);
            Console.WriteLine("URL FOTO : " + this.URLFoto);
            Console.WriteLine("KODE : " + this.Kode);
            Console.WriteLine("");
        }

        public bool PinjamBuku(string _KodeMasukkan)
        {
            bool result = false;
            if( Login(_KodeMasukkan))
            {
                result = true;
            }
            return result;
        }
        
        public void TampilkanDataPinjaman()
        {
            TampilkanDataAnggota();
            Console.WriteLine("BUKU YANG DIPINJAM : " + this.Judul);
        }

        #endregion

    }
}


