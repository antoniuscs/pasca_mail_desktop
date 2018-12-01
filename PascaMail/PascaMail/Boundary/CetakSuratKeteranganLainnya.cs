using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PascaMail.dbPascaMailTableAdapters;

namespace PascaMail.Boundary
{
    public partial class CetakSuratKeteranganLainnya : Form
    {
        public CetakSuratKeteranganLainnya()
        {
            InitializeComponent();
        }
        string idsurat;
        private SuratTableAdapter S = new SuratTableAdapter();

        private void CetakSuratKeteranganLainnya_Load(object sender, EventArgs e)
        {
            SuratKeteranganLainnya SK = new SuratKeteranganLainnya();
            DataTable DT = new DataTable();
            DT = S.GetSurat(idsurat);
            SK.SetDataSource(DT);

            crystalReportViewer1.ReportSource = SK;
            crystalReportViewer1.Show();
        }

        public void setID(string ID)
        {
            this.idsurat = ID;
        }
    }
}
