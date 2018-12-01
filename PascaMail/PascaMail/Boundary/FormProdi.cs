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
    public partial class FormProdi : Form
    {
        public FormProdi()
        {
            InitializeComponent();
        }
        PascaControl PC = new PascaControl();

        public void setDatagridViewProdi(DataGridView DG)
        {
            DG.DataSource = PC.showProdi();

            //Code Data Binding
            DataTable DT = PC.showProdi();
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

            DG.Columns[1].Width = 200;
        }

        public void searchDatagridViewProdi(DataGridView DG, string keyword)
        {
            DG.DataSource = PC.searchProdi(keyword);

            //Code Data Binding
            DataTable DT = PC.searchProdi(keyword);
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

            DG.Columns[1].Width = 200;
        }

        private void cleartxt()
        {
            txtCari.Clear();
            lblProdi.Text = "-";
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

        private void FormProdi_Load(object sender, EventArgs e)
        {
            cleartxt();
            setDatagridViewProdi(this.dataGridProdi);
            uC_InputProdi1.Visible = false;
        }

        private void disable()
        {
            txtCari.Enabled = false;
            btnBatal.Enabled = false;
            btnHapus.Enabled = false;
            btnTambah.Enabled = false;
            btnUbah.Enabled = false;
            dataGridProdi.Enabled = false;
        }

        public void Enable()
        {
            txtCari.Enabled = true;
            btnUbah.Enabled = true;
            btnTambah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
            dataGridProdi.Enabled = true;

            setDatagridViewProdi(this.dataGridProdi);
            if (dataGridProdi.RowCount > 0)
            {
                dataGridProdi.Rows[0].Selected = true;
                txtID.Text = getKolom(dataGridProdi, 0);
            }
        }

        public void EnableEdit()
        {
            txtCari.Enabled = true;
            btnUbah.Enabled = true;
            btnTambah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
            dataGridProdi.Enabled = true;

            setDatagridViewProdi(this.dataGridProdi);
            dataGridProdi.Rows[0].Selected = true;
            txtID.Text = getKolomEdit(dataGridProdi, int.Parse(txtRow.Text));
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            searchDatagridViewProdi(this.dataGridProdi, txtCari.Text);
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.searchDatagridViewProdi(dataGridProdi, this.txtCari.Text);
            if (txtCari.Text == "")
            {
                this.setDatagridViewProdi(dataGridProdi);
            }
        }

        private void dataGridProdi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridProdi, 0);
            lblProdi.Text = getKolom(dataGridProdi, 1);
            txtRow.Text = getRow(dataGridProdi);
        }

        private void dataGridProdi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridProdi, 0);
            txtRow.Text = getRow(dataGridProdi);
        }

        private void dataGridProdi_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridProdi, 0);
            txtRow.Text = getRow(dataGridProdi);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_InputProdi1.setflag(1);
            uC_InputProdi1.Visible = true;
            disable();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridProdi.Focus();
            }
            else
            {
                uC_InputProdi1.setflag(2);

                uC_InputProdi1.isiTextBox(lblProdi.Text, txtID.Text);
                uC_InputProdi1.Visible = true;
                txtID.Clear();
                disable();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridProdi.Focus();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Apakah Anda yakin untuk menghapus data ini ? ", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    PC.deleteProdi(int.Parse(txtID.Text));
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
