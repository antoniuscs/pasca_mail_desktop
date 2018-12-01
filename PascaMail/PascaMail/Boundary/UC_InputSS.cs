using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PascaMail.Control;
using PascaMail.Entity;
using PascaMail.dbPascaMailTableAdapters;

namespace PascaMail.Boundary
{
    public partial class UC_InputSS : UserControl
    {
        public UC_InputSS()
        {
            InitializeComponent();
        }

        int flagperintah = 0;
        public void setflag(int flag)
        {
            flagperintah = flag;
        }

        PascaControl PC = new PascaControl();

        private void UC_InputSS_Load(object sender, EventArgs e)
        {
            cleartxt();
        }

        private void cleartxt()
        {
            txtNama.Clear();
        }

        string temp_nama = "";
        public void isiTextBox(string nama, string id)
        {
            txtNama.Text = nama;
            temp_nama = nama;
            txtID.Text = id;
        }

        private bool cektxt()
        {
            bool temp = true;
            if (txtNama.Text == "")
            {
                errorProvider1.SetError(txtNama, "Silahkan isi nama staff..");
                txtNama.Focus();
                temp = false;
            }

            return temp;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cektxt() == true)
            {
                if (flagperintah == 1)
                {
                    errorProvider1.Clear();
                    PascaMail.Entity.Staff S = new Entity.Staff(txtNama.Text);
                    PC.insertStaff(S);
                    MessageBox.Show("Staff berhasil diinputkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormStudentStaff myParent = (FormStudentStaff)this.Parent;
                    myParent.Enable();
                }
                else
                {
                    errorProvider1.Clear();
                    PascaMail.Entity.Staff S = new Entity.Staff(txtNama.Text);
                    PC.updateStaff(S, int.Parse(txtID.Text));
                    MessageBox.Show("Staff berhasil diinputkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormStudentStaff myParent = (FormStudentStaff)this.Parent;
                    myParent.EnableEdit();
                }
            }
            else
            {
                MessageBox.Show("Silahkan lengkapi data terlebih dahulu..", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            FormStudentStaff myParent = (FormStudentStaff)this.Parent;
            myParent.Enable();
        }
    }
}
