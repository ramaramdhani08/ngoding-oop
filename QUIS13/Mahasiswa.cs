using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIS13
{
    class Mahasiswa
    {
        #region atribuit
        private string npm;
        private string nama;
        private string alamat;
        private string urlfoto;
        
        #endregion

        #region properties
        public string NPM 
        {
            get
            {
                return this.npm;
            }
            set
            {
                this.npm = value;
            }
        }

        public string Nama
        {
            get
            {
                return this.nama;
            }
            set
            {
                this.nama = value;
            }
        }

        public string Alamat
        {
            get
            {
                return this.alamat;
            }
            set
            {
                this.alamat = value;
            }
        }

        public string URLFoto
        {
            get
            {
                return this.urlfoto;
            }
            set
            {
                this.urlfoto = value;
            }
        }
        #endregion

    }
}
