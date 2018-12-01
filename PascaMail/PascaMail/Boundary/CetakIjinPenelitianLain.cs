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
    public partial class CetakIjinPenelitianLain : Form
    {
        public CetakIjinPenelitianLain()
        {
            InitializeComponent();
        }

        string idsurat;
        private SuratTableAdapter S = new SuratTableAdapter();


        public void setID(string ID)
        {
            this.idsurat = ID;
        }

        private void CetakIjinPenelitianLain_Load(object sender, EventArgs e)
        {
            IjinPenelitianLain IP = new IjinPenelitianLain();
            DataTable DT = new DataTable();
            DT = S.GetSurat(idsurat);
            IP.SetDataSource(DT);

            crystalReportViewer1.ReportSource = IP;
            crystalReportViewer1.Show();
        }
    }
}
