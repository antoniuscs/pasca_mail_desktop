using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascaMail.Entity
{
    class Kaprodi
    {
        string namaKaprodi;
        int prodi;

        public Kaprodi(string namaKaprodi, int prodi)
        {
            this.namaKaprodi = namaKaprodi;
            this.prodi = prodi;
        }

        public string NamaKaprodi
        {
            get { return namaKaprodi; }
            set { namaKaprodi = value; }
        }

        public int Prodi
        {
            get { return prodi; }
            set { prodi = value; }
        }

    }
}
