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
    public partial class UC_InputProdi : UserControl
    {
        public UC_InputProdi()
        {
            InitializeComponent();
        }

        int flagperintah = 0;
        public void setflag(int flag)
        {
            flagperintah = flag;
        }

        PascaControl PC = new PascaControl();
        private void cleartxt()
        {
            txtProdi.Clear();
        }

        private void UC_InputProdi_Load(object sender, EventArgs e)
        {
            cleartxt();
        }

        public void isiTextBox(string prodi, string id)
        {
            txtProdi.Text = prodi;
            txtID.Text = id;
        }

        private bool cektxt()
        {
            bool temp = true;
            if (txtProdi.Text == "")
            {
                errorProvider1.SetError(txtProdi, "Silahkan isi program studi..");
                txtProdi.Focus();
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

                    PascaMail.Entity.Prodi P = new Entity.Prodi(txtProdi.Text);
                    PC.insertProdi(P);
                    MessageBox.Show("Prodi berhasil diinputkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormProdi myParent = (FormProdi)this.Parent;
                    myParent.Enable();
                }
                else
                {
                    errorProvider1.Clear();

                    PascaMail.Entity.Prodi P = new Entity.Prodi(txtProdi.Text);
                    PC.updateProdi(P, int.Parse(txtID.Text));
                    MessageBox.Show("Prodi berhasil diinputkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormProdi myParent = (FormProdi)this.Parent;
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
            FormProdi myParent = (FormProdi)this.Parent;
            myParent.Enable();
        }
    }
}
