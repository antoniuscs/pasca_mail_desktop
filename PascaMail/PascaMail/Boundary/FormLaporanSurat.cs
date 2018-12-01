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
    public partial class FormLaporanSurat : Form
    {
        public FormLaporanSurat()
        {
            InitializeComponent();
        }

        private SuratTableAdapter S = new SuratTableAdapter();

        private void FormLaporanSurat_Load(object sender, EventArgs e)
        {
            LaporanSurat LP = new LaporanSurat();
            DataTable DT = new DataTable();
            DT = S.GetDataBy();
            LP.SetDataSource(DT);

            crystalReportViewer1.ReportSource = LP;
            crystalReportViewer1.Show();
        }
    }
}
