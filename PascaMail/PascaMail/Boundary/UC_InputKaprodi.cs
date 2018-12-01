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
    public partial class UC_InputKaprodi : UserControl
    {
        public UC_InputKaprodi()
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
            txtNama.Clear();
            cmbProdi.SelectedIndex = -1;
        }
        private void UC_InputKaprodi_Load(object sender, EventArgs e)
        {
            cleartxt();

            cmbProdi.DataSource = PC.getProdi();
            cmbProdi.DisplayMember = "nama_prodi";
        }

        public void isiTextBox(string nama, string prodi, string id)
        {
            txtNama.Text = nama;
            cmbProdi.Text = prodi;
            txtID.Text = id;
        }

        private bool cektxt()
        {
            bool temp = true;
            if (txtNama.Text == "")
            {
                errorProvider1.SetError(txtNama, "Silahkan isi nama kepala program studi..");
                txtNama.Focus();
                temp = false;
            }
            if (cmbProdi.Text == "")
            {
                errorProvider1.SetError(cmbProdi, "Silahkan pilih program studi..");
                cmbProdi.Focus();
                temp = false;
            }

            return temp;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            FormKaprodi myParent = (FormKaprodi)this.Parent;
            myParent.Enable();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (cektxt() == true)
            {
                if (flagperintah == 1)
                {
                    errorProvider1.Clear();
                    int IDProdi = PC.getIDProdi(cmbProdi.Text);
                    PascaMail.Entity.Kaprodi K = new Entity.Kaprodi(txtNama.Text, IDProdi);
                    PC.insertKaprodi(K);
                    MessageBox.Show("Kaprodi berhasil diinputkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormKaprodi myParent = (FormKaprodi)this.Parent;
                    myParent.EnableEdit();
                }
                else
                {
                    errorProvider1.Clear();
                    int IDProdi = PC.getIDProdi(cmbProdi.Text);
                    PascaMail.Entity.Kaprodi K = new Entity.Kaprodi(txtNama.Text, IDProdi);
                    PC.updateKaprodi(K, int.Parse(txtID.Text));
                    MessageBox.Show("Kaprodi berhasil diinputkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormKaprodi myParent = (FormKaprodi)this.Parent;
                    myParent.EnableEdit();
                }
            }
            else
            {
                MessageBox.Show("Silahkan lengkapi data terlebih dahulu..", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
