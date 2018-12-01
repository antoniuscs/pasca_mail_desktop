using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascaMail.Entity
{
    class MataKuliah
    {
        string namaMakul, namaDosen;
        int prodi;

        public MataKuliah(string namaMakul, string namaDosen, int prodi)
        {
            this.namaMakul = namaMakul;
            this.namaDosen = namaDosen;
            this.prodi = prodi;
        }

        public string NamaMakul
        {
            get { return namaMakul; }
            set { namaMakul = value; }
        }

        public string NamaDosen
        {
            get { return namaDosen; }
            set { namaDosen = value; }
        }

        public int Prodi
        {
            get { return prodi; }
            set { prodi = value; }
        }
    }
}
