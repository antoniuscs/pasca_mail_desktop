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
    public partial class FormKaprodi : Form
    {
        public FormKaprodi()
        {
            InitializeComponent();
        }

        PascaControl PC = new PascaControl();

        public void setDatagridViewKaprodi(DataGridView DG)
        {
            DG.DataSource = PC.showKaprodi();

            //Code Data Binding
            DataTable DT = PC.showKaprodi();
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
                    if (counter == 10)
                        counter = 0;
                }
            }
            bindingSource1.DataSource = listTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            DG.DataSource = (DT.Rows.Count > 0 ? listTbl[bindingSource1.Position] : DT);

            DG.Columns[0].Visible = false;
            DG.Columns[1].HeaderText = "NAMA KAPRODI";
            DG.Columns[2].HeaderText = "PROGRAM STUDI";

            DG.Columns[1].Width = 200;
            DG.Columns[2].Width = 200;
        }

        public void searchDatagridViewKaprodi(DataGridView DG, string keyword)
        {
            DG.DataSource = PC.searchKaprodi(keyword);

            //Code Data Binding
            DataTable DT = PC.searchKaprodi(keyword);
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
                    if (counter == 10)
                        counter = 0;
                }
            }
            bindingSource1.DataSource = listTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            DG.DataSource = (DT.Rows.Count > 0 ? listTbl[bindingSource1.Position] : DT);

            DG.Columns[0].Visible = false;
            DG.Columns[1].HeaderText = "NAMA KAPRODI";
            DG.Columns[2].HeaderText = "PROGRAM STUDI";

            DG.Columns[1].Width = 200;
            DG.Columns[2].Width = 200;
        }

        private void FormKaprodi_Load(object sender, EventArgs e)
        {
            cleartxt();
            setDatagridViewKaprodi(this.dataGridKaprodi);
            uC_InputKaprodi1.Visible = false;
        }

        private void cleartxt()
        {
            txtCari.Clear();
            lblKaprodi.Text = "-";
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

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            searchDatagridViewKaprodi(this.dataGridKaprodi, txtCari.Text);
        }

        private void disable()
        {
            txtCari.Enabled = false;
            btnBatal.Enabled = false;
            btnHapus.Enabled = false;
            btnTambah.Enabled = false;
            btnUbah.Enabled = false;
            dataGridKaprodi.Enabled = false;
        }

        public void Enable()
        {
            txtCari.Enabled = true;
            btnUbah.Enabled = true;
            btnTambah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
            dataGridKaprodi.Enabled = true;

            setDatagridViewKaprodi(this.dataGridKaprodi);
            if (dataGridKaprodi.RowCount > 0)
            {
                dataGridKaprodi.Rows[0].Selected = true;
                txtID.Text = getKolom(dataGridKaprodi, 0);
            }
        }

        public void EnableEdit()
        {
            txtCari.Enabled = true;
            btnUbah.Enabled = true;
            btnTambah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
            dataGridKaprodi.Enabled = true;

            setDatagridViewKaprodi(this.dataGridKaprodi);
            dataGridKaprodi.Rows[0].Selected = true;
            txtID.Text = getKolomEdit(dataGridKaprodi, int.Parse(txtRow.Text));
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.searchDatagridViewKaprodi(dataGridKaprodi, this.txtCari.Text);
            if (txtCari.Text == "")
            {
                this.setDatagridViewKaprodi(dataGridKaprodi);
            }
        }

        private void dataGridKaprodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridKaprodi, 0);
            lblKaprodi.Text = getKolom(dataGridKaprodi, 1);
            lblProdi.Text = getKolom(dataGridKaprodi, 2);
            txtRow.Text = getRow(dataGridKaprodi);
        }

        private void dataGridKaprodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridKaprodi, 0);
            txtRow.Text = getRow(dataGridKaprodi);
        }

        private void dataGridKaprodi_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridKaprodi, 0);
            txtRow.Text = getRow(dataGridKaprodi);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_InputKaprodi1.setflag(1);
            uC_InputKaprodi1.Visible = true;
            disable();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridKaprodi.Focus();
            }
            else
            {
                uC_InputKaprodi1.setflag(2);

                uC_InputKaprodi1.isiTextBox(lblKaprodi.Text, lblProdi.Text, txtID.Text);
                uC_InputKaprodi1.Visible = true;
                txtID.Clear();
                disable();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridKaprodi.Focus();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Apakah Anda yakin untuk menghapus data ini ? ", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    PC.deleteKaprodi(int.Parse(txtID.Text));
                    MessageBox.Show("Data Kaprodi berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
