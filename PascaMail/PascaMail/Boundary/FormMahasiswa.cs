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

namespace PascaMail.Boundary
{
    public partial class FormMahasiswa : Form
    {
        public FormMahasiswa()
        {
            InitializeComponent();
        }

        PascaControl PC = new PascaControl();

        public void setDatagridViewMhs(DataGridView DG)
        {
            DG.DataSource = PC.showMahasiswa();

            //Code Data Binding
            DataTable DT = PC.showMahasiswa();
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
                    if (counter == 13)
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
            DG.Columns[6].HeaderText = "JENIS KELAMIN";
            DG.Columns[7].HeaderText = "TAHUN MASUK";
            DG.Columns[8].Visible = false;
            DG.Columns[9].Visible = false;
            DG.Columns[10].HeaderText = "PROGRAM STUDI";
            DG.Columns[11].Visible = false;

            DG.Columns[1].Width = 75;
            DG.Columns[2].Width = 175;
            DG.Columns[6].Width = 75;
            DG.Columns[7].Width = 50;
            DG.Columns[10].Width = 130;
        }

        public void searchDatagridViewMhs(DataGridView DG, string keyword)
        {
            DG.DataSource = PC.searchMahasiswa(keyword);

            //Code Data Binding
            DataTable DT = PC.searchMahasiswa(keyword);
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
                    if (counter == 13)
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
            DG.Columns[6].HeaderText = "JENIS KELAMIN";
            DG.Columns[7].HeaderText = "TAHUN MASUK";
            DG.Columns[8].Visible = false;
            DG.Columns[9].Visible = false;
            DG.Columns[10].HeaderText = "PROGRAM STUDI";
            DG.Columns[11].Visible = false;

            DG.Columns[1].Width = 75;
            DG.Columns[2].Width = 175;
            DG.Columns[6].Width = 75;
            DG.Columns[7].Width = 50;
            DG.Columns[10].Width = 130;
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
        {
            cleartxt();
            setDatagridViewMhs(this.dataGridMhs);
            uC_InputMhs1.Visible = false;
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

        private void cleartxt()
        {
            txtCari.Clear();
            lblNama.Text = "-";
            lblNPM.Text = "-";
            lblProdi.Text = "-";
            lblTmptLahir.Visible = false;
            lblTglLahir.Visible = false;
            lblAgama.Visible = false;
            lblJK.Visible = false;
            lblTahunMasuk.Visible = false;
            lblAwalStudi.Visible = false;
            lblKewarganegaraan.Visible = false;
            lblKaprodi.Visible = false;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            searchDatagridViewMhs(this.dataGridMhs, txtCari.Text);
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.searchDatagridViewMhs(this.dataGridMhs, this.txtCari.Text);
            if (txtCari.Text == "")
            {
                this.setDatagridViewMhs(this.dataGridMhs);
            }
        }

        private void disable()
        {
            txtCari.Enabled = false;
            btnBatal.Enabled = false;
            btnHapus.Enabled = false;
            btnTambah.Enabled = false;
            btnUbah.Enabled = false;
            dataGridMhs.Enabled = false;
        }

        public void Enable()
        {
            txtCari.Enabled = true;
            btnUbah.Enabled = true;
            btnTambah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
            dataGridMhs.Enabled = true;

            setDatagridViewMhs(this.dataGridMhs);
            if (dataGridMhs.RowCount > 0)
            {
                dataGridMhs.Rows[0].Selected = true;
                txtID.Text = getKolom(dataGridMhs, 0);
            }

        }

        public void EnableEdit()
        {
            txtCari.Enabled = true;
            btnUbah.Enabled = true;
            btnTambah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
            dataGridMhs.Enabled = true;

            setDatagridViewMhs(this.dataGridMhs);
            dataGridMhs.Rows[0].Selected = true;
        }

        private void dataGridMhs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridMhs, 0);
            txtRow.Text = getRow(dataGridMhs);
        }

        private void dataGridMhs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridMhs, 0);
            lblNPM.Text = getKolom(dataGridMhs, 1);
            lblNama.Text = getKolom(dataGridMhs, 2);
            lblTmptLahir.Text = getKolom(dataGridMhs, 3);
            lblTglLahir.Text = getKolom(dataGridMhs, 4);
            lblAgama.Text = getKolom(dataGridMhs, 5);
            lblJK.Text = getKolom(dataGridMhs, 6);
            lblTahunMasuk.Text=getKolom(dataGridMhs,7);
            lblAwalStudi.Text = getKolom(dataGridMhs, 8);
            lblKewarganegaraan.Text = getKolom(dataGridMhs, 9);
            lblProdi.Text = getKolom(dataGridMhs, 10);
            lblKaprodi.Text = getKolom(dataGridMhs, 11);
            txtRow.Text = getRow(dataGridMhs);
        }

        private void dataGridMhs_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridMhs, 0);
            txtRow.Text = getRow(dataGridMhs);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_InputMhs1.setflag(1);
            uC_InputMhs1.Visible = true;
            disable();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridMhs.Focus();
            }
            else
            {
                uC_InputMhs1.setflag(2);
                uC_InputMhs1.isiTextBox(lblNPM.Text, lblNama.Text, lblTmptLahir.Text, lblTglLahir.Text, lblAgama.Text, lblJK.Text, lblTahunMasuk.Text, lblAwalStudi.Text, lblKewarganegaraan.Text, lblProdi.Text, lblKaprodi.Text, txtID.Text);
                uC_InputMhs1.Visible = true;
                txtID.Clear();
                disable();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridMhs.Focus();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Apakah Anda yakin untuk menghapus data ini ? ", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    PC.deleteMhs(int.Parse(txtID.Text));
                    MessageBox.Show("Data Mahasiswa berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtID.Clear();
                this.Enable();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
        }
    }
}
