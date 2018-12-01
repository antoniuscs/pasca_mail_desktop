using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascaMail.Entity
{
    class Staff
    {
        string namaStaff;

        public Staff(string namaStaff)
        {
            this.namaStaff = namaStaff;
        }

        public string NamaStaff
        {
            get { return namaStaff; }
            set { namaStaff = value; }
        }

    }
}
