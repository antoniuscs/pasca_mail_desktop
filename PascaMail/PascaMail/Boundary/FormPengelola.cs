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
using PascaMail.Control;
using PascaMail.Entity;
using PascaMail.Boundary;

namespace PascaMail
{
    public partial class FormPengelola : Form
    {
        public FormPengelola()
        {
            InitializeComponent();
        }

        PascaControl MC = new PascaControl();

        public void searchDatagridView(DataGridView DG, string keyword)
        {
            DG.DataSource = MC.searchMahasiswa(keyword);

            //Code Data Binding
            DataTable DT = MC.searchMahasiswa(keyword);
            BindingList<DataTable> listTbl = new BindingList<DataTable>();
            if (DT.Rows.Count > 0)
            {
                int counter = 0, subTblIndex = -1;
                foreach (DataRow dr in DT.Rows)
                {
                    if (counter == 0)
                    {
                        listTbl.Add(DT.Clone());
                        subTblIndex++;
                    }
                    listTbl[subTblIndex].Rows.Add(dr.ItemArray);
                    counter++;
                    if (counter == 16)
                        counter = 0;
                }
            }
            bindingSource1.DataSource = listTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            DG.DataSource = (DT.Rows.Count > 0 ? listTbl[bindingSource1.Position] : DT);

            DG.Columns[0].Visible = false;
            DG.Columns[1].HeaderText = "NPM";
            DG.Columns[2].HeaderText = "NAMA MAHASISWA";
            DG.Columns[3].Visible = false;
            DG.Columns[4].Visible = false;
            DG.Columns[5].Visible = false;
            DG.Columns[6].Visible = false;
            DG.Columns[7].Visible = false;
            DG.Columns[8].Visible = false;
            DG.Columns[9].Visible = false;
            DG.Columns[10].HeaderText = "PROGRAM STUDI";
            DG.Columns[11].Visible = false;

            DG.Columns[1].Width = 70;
            DG.Columns[2].Width = 200;
            DG.Columns[10].Width = 200;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            searchDatagridView(dataGridMahasiswa, txtCari.Text);
        }

        private string getKolom(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private string getKolomEdit(DataGridView dg, int i)
        {
            return dg[dg.Columns[0].Index, dg.Rows[i].Index].Value.ToString();
        }

        private string getRow(DataGridView dg)
        {
            return dg.CurrentRow.Index.ToString();
        }

        private void dataGridMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNPM.Text = getKolom(dataGridMahasiswa, 1);
            lblNama.Text = getKolom(dataGridMahasiswa, 2);
            lblProdi.Text = getKolom(dataGridMahasiswa, 10);
            lblKaprodi.Text = getKolom(dataGridMahasiswa, 11);
        }

        private void FormPengelola_Load(object sender, EventArgs e)
        {
            cleartxt();
            uC_IjinPenelitian1.Visible = false;
            uC_SuratKeterangan1.Visible = false;
            uC_IjinPenelitianLain1.Visible = false;
            uC_SuratKeteranganLain1.Visible = false;
        }

        private void cleartxt()
        {
            lblKaprodi.Visible = false;
            lblProdi.Text = "-";
            lblNPM.Text = "-";
            lblNama.Text = "-";
            txtCari.Clear();
            lblHal.Text = "";
        }

        private void disable()
        {
            lblNPM.Enabled = false;
            lblNama.Enabled = false;
            lblProdi.Enabled = false;
            txtCari.Enabled = false;
            btnBatal.Enabled = false;
            btnIjin.Enabled = false;
            btnSKL.Enabled = false;
            dataGridMahasiswa.Enabled = false;
        }

        public void Enable()
        {
            lblNPM.Enabled = true;
            lblNama.Enabled = true;
            lblProdi.Enabled = true;
            txtCari.Enabled = true;
            btnBatal.Enabled = true;
            btnIjin.Enabled = true;
            btnSKL.Enabled = true;
            dataGridMahasiswa.Enabled = true;

            if (dataGridMahasiswa.RowCount > 0)
            {
                dataGridMahasiswa.Rows[0].Selected = true;
            }
        }

        private void btnIjin_Click(object sender, EventArgs e)
        {
            if (lblNPM.Text == "-")
            {
                MessageBox.Show("Silahkan pilih mahasiswa terlebih dahulu..", "Peringatan",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Cetak Permohonan Ijin Penelitian untuk mahasiswa dengan NPM " + lblNPM.Text + " dengan nama " + lblNama.Text + " ? ", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    uC_IjinPenelitian1.setflag(1);
                    string hal = "Permohonan Ijin Penelitian";
                    uC_IjinPenelitian1.isiTextBox(lblNPM.Text, lblNama.Text, lblProdi.Text, lblKaprodi.Text, hal);
                    uC_IjinPenelitian1.Visible = true;
                    disable();
                }
            }
        }

        private void btnSK_Click(object sender, EventArgs e)
        {
            if (lblNPM.Text == "-")
            {
                MessageBox.Show("Silahkan pilih mahasiswa terlebih dahulu..", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Cetak Surat Keterangan untuk mahasiswa dengan NPM " + lblNPM.Text + " dengan nama " + lblNama.Text + " ? ", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    uC_SuratKeterangan1.setflag(1);
                    string hal = "Surat Keterangan";
                    uC_SuratKeterangan1.isiTextBox(lblNPM.Text, lblNama.Text, lblProdi.Text, lblKaprodi.Text, hal);
                    uC_SuratKeterangan1.Visible = true;
                    disable();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.searchDatagridView(dataGridMahasiswa, this.txtCari.Text);
            if (txtCari.Text == "")
            {
                this.searchDatagridView(dataGridMahasiswa, this.txtCari.Text);
            }
        }

        private void btnIjinLain_Click(object sender, EventArgs e)
        {
            if (lblNPM.Text == "-")
            {
                MessageBox.Show("Silahkan pilih mahasiswa terlebih dahulu..", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Cetak Permohonan Ijin Penelitian untuk mahasiswa dengan NPM " + lblNPM.Text + " dengan nama " + lblNama.Text + " ? ", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    uC_IjinPenelitianLain1.setflag(1);
                    //string hal = "Permohonan Ijin Penelitian " + lblHal.Text;
                    uC_IjinPenelitianLain1.isiTextBox(lblNPM.Text, lblNama.Text, lblProdi.Text, lblKaprodi.Text, lblHal.Text);
                    uC_IjinPenelitianLain1.Visible = true;
                    disable();
                }
            }
        }

        private void btnSKLain_Click(object sender, EventArgs e)
        {
            if (lblNPM.Text == "-")
            {
                MessageBox.Show("Silahkan pilih mahasiswa terlebih dahulu..", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Cetak Surat Keterangan untuk mahasiswa dengan NPM " + lblNPM.Text + " dengan nama " + lblNama.Text + " ? ", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    uC_SuratKeteranganLain1.setflag(1);
                    string hal = "Surat Keterangan Lainnya";
                    uC_SuratKeteranganLain1.isiTextBox(lblNPM.Text, lblNama.Text, lblProdi.Text, lblKaprodi.Text, hal);
                    uC_SuratKeteranganLain1.Visible = true;
                    disable();
                }
            }
        }

    }
}
