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
    public partial class FormStudentStaff : Form
    {
        public FormStudentStaff()
        {
            InitializeComponent();
        }

        PascaControl PC = new PascaControl();
        public void setDatagridViewStaff(DataGridView DG)
        {
            DG.DataSource = PC.showStaff();

            //Code Data Binding
            DataTable DT = PC.showStaff();
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
            DG.Columns[1].HeaderText = "NAMA STAFF";

            DG.Columns[1].Width = 189;
        }

        public void searchDatagridViewStaff(DataGridView DG, string keyword)
        {
            DG.DataSource = PC.searchStaff(keyword);

            //Code Data Binding
            DataTable DT = PC.searchStaff(keyword);
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
            DG.Columns[1].HeaderText = "NAMA STAFF";

            DG.Columns[1].Width = 189;
        }

        private void FormStudentStaff_Load(object sender, EventArgs e)
        {
            cleartxt();
            setDatagridViewStaff(this.dataGridStudentStaff);
            uC_InputSS1.Visible = false;
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
            lblStaff.Text = "-";
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            searchDatagridViewStaff(this.dataGridStudentStaff, txtCari.Text);
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.searchDatagridViewStaff(dataGridStudentStaff, this.txtCari.Text);
            if (txtCari.Text == "")
            {
                this.setDatagridViewStaff(dataGridStudentStaff);
            }
        }

        private void disable()
        {
            txtCari.Enabled = false;
            btnBatal.Enabled = false;
            btnHapus.Enabled = false;
            btnTambah.Enabled = false;
            btnUbah.Enabled = false;
            dataGridStudentStaff.Enabled = false;
        }

        public void Enable()
        {
            txtCari.Enabled = true;
            btnUbah.Enabled = true;
            btnTambah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
            dataGridStudentStaff.Enabled = true;

            setDatagridViewStaff(this.dataGridStudentStaff);
            if (dataGridStudentStaff.RowCount > 0)
            {
                dataGridStudentStaff.Rows[0].Selected = true;
                txtID.Text = getKolom(dataGridStudentStaff, 0);
            }
            
        }

        public void EnableEdit()
        {
            txtCari.Enabled = true;
            btnUbah.Enabled = true;
            btnTambah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;
            dataGridStudentStaff.Enabled = true;

            setDatagridViewStaff(this.dataGridStudentStaff);
            dataGridStudentStaff.Rows[0].Selected = true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_InputSS1.setflag(1);
            uC_InputSS1.Visible = true;
            disable();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridStudentStaff.Focus();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Apakah Anda yakin untuk menghapus data ini ? ", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    PC.deleteStaff(int.Parse(txtID.Text));
                    MessageBox.Show("Data Staff berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtID.Clear();
                this.Enable();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridStudentStaff.Focus();
            }
            else
            {
                uC_InputSS1.setflag(2);

                uC_InputSS1.isiTextBox(lblStaff.Text, txtID.Text);
                uC_InputSS1.Visible = true;
                txtID.Clear();
                disable();
            }
        }

        private void dataGridStudentStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridStudentStaff, 0);
            txtRow.Text = getRow(dataGridStudentStaff);
        }

        private void dataGridStudentStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridStudentStaff, 0);
            lblStaff.Text = getKolom(dataGridStudentStaff, 1);
            txtRow.Text = getRow(dataGridStudentStaff);
        }

        private void dataGridStudentStaff_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridStudentStaff, 0);
            txtRow.Text = getRow(dataGridStudentStaff);
        }
    }
}
