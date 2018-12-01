﻿using System;
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
    public partial class CetakAmplopSurat : Form
    {
        public CetakAmplopSurat()
        {
            InitializeComponent();
        }

        string idsurat;
        private SuratTableAdapter S = new SuratTableAdapter();

        private void CetakAmplopSurat_Load(object sender, EventArgs e)
        {
            AmplopSurat AS = new AmplopSurat();
            DataTable DT = new DataTable();
            DT = S.GetSurat(idsurat);
            AS.SetDataSource(DT);

            crystalReportViewer1.ReportSource = AS;
            crystalReportViewer1.Show();
        }

        public void setID(string ID)
        {
            this.idsurat = ID;
        }

    }
}
