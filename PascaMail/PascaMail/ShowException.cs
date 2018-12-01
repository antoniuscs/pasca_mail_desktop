using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PascaMail
{
    class ShowException
    {
        public ShowException()
        {
        }

        public void ShowMessage(string message, string kategori)
        {
            string[] temp = message.Split((char)13);
            MessageBox.Show(temp[0], kategori);
        }
    }
}
