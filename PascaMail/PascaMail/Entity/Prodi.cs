using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascaMail.Entity
{
    class Prodi
    {
        string namaProdi;

        public Prodi(string namaProdi)
        {
            this.namaProdi = namaProdi;
        }

        public string NamaProdi
        {
            get { return namaProdi; }
            set { namaProdi = value; }
        }
    }
}
