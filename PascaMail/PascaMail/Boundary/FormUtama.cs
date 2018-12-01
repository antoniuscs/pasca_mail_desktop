using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PascaMail.Boundary
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void pengelolaanMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPengelola fp = new FormPengelola();
            FormStatusSuratStaf fstats = new FormStatusSuratStaf();
            fp.MdiParent = this;
            fstats.MdiParent = this;
            fp.Show();
            fstats.Close();
        }

        private void pengelolaanStatusSuratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPengelola fp = new FormPengelola();
            FormStatusSuratStaf fstats = new FormStatusSuratStaf();
            fstats.MdiParent = this;
            fp.MdiParent = this;
            fstats.Show();
            fp.Close();
        }

        private void pengelolaanStatusSuratToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormStatusSuratStaf fstats1 = new FormStatusSuratStaf();
            fstats1.MdiParent = this;
            fstats1.Show();
        }

        private void pengelolaanStudentStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentStaff fss = new FormStudentStaff();
            fss.MdiParent = this;
            fss.Show();
        }

        private void inputKepalaProgramStudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKaprodi fk = new FormKaprodi();
            fk.MdiParent = this;
            fk.Show();
        }

        private void inputMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMahasiswa fm = new FormMahasiswa();
            fm.MdiParent = this;
            fm.Show();
        }

        private void inputProgramStudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdi fprod = new FormProdi();
            fprod.MdiParent = this;
            fprod.Show();
        }

        public void setToolStripUser(string text)
        {
            this.toolStripUser.Text = text;
        }

        public void setVisibleMenuAdmin(bool Set)
        {
            this.adminToolStripMenuItem.Visible = Set;
        }

        public void setVisibleMenuStaff(bool Set)
        {
            this.staffToolStripMenuItem.Visible = Set;
        }

        public void setVisibleMenuStudentStaff(bool Set)
        {
            this.studentStaffToolStripMenuItem.Visible = Set;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
