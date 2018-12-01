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
    public partial class UC_InputMhs : UserControl
    {
        public UC_InputMhs()
        {
            InitializeComponent();
        }

        int flagperintah = 0;
        public void setflag(int flag)
        {
            flagperintah = flag;
        }

        PascaControl PC = new PascaControl();

        string jenisKelaminMhs;
        private void cleartxt()
        {
            txtNama.Clear();
            txtNPM.Clear();
            txtTempatLahir.Clear();
            radioBtnLaki.Checked = false;
            radioBtnPerempuan.Checked = false;
            dateAwalStudi.Text = DateTime.Now.ToString("dd MMMM yyyy");
            dateTglLahir.Text = DateTime.Now.ToString("dd MMMM yyyy");
            cmbProdi.SelectedIndex = -1;
            cmbAgama.SelectedIndex = -1;
            cmbAngkatan.SelectedIndex = -1;
            cmbKewarganegaraan.SelectedIndex = -1;
            cmbKaprodi.SelectedIndex = -1;
            cmbKaprodi.Enabled = false;
        }

        private void cmbProdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKaprodi.Items.Count > 0)
            {
                if (cmbProdi.SelectedIndex == 0)
                {
                    cmbKaprodi.SelectedIndex = 0;
                }
                if (cmbProdi.SelectedIndex == 1)
                {
                    cmbKaprodi.SelectedIndex = 1;
                }
                if (cmbProdi.SelectedIndex == 2)
                {
                    cmbKaprodi.SelectedIndex = 2;
                }
                if (cmbProdi.SelectedIndex == 3)
                {
                    cmbKaprodi.SelectedIndex = 3;
                }
                if (cmbProdi.SelectedIndex == 4)
                {
                    cmbKaprodi.SelectedIndex = 4;
                }
                if (cmbProdi.SelectedIndex == 5)
                {
                    cmbKaprodi.SelectedIndex = 5;
                }
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtTempatLahir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtNPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
            {
                e.Handled = false;
                txtNPM.MaxLength = 9;
            }
            else
                e.Handled = true;
        }

        public void comboAgama()
        {
            cmbAgama.Items.Add("Islam");
            cmbAgama.Items.Add("Katholik");
            cmbAgama.Items.Add("Kristen Protestan");
            cmbAgama.Items.Add("Hindu");
            cmbAgama.Items.Add("Buddha");
            cmbAgama.Items.Add("Konghucu");
            cmbAgama.Items.Add("Lainnya");
        }

        public void comboWargaNegara()
        {
            cmbKewarganegaraan.Items.Add("WNI");
            cmbKewarganegaraan.Items.Add("WNA");
            cmbKewarganegaraan.Items.Add("Lainnya");
        }

        public void comboAngkatan()
        {
            cmbAngkatan.Items.Add("2010");
            cmbAngkatan.Items.Add("2011");
            cmbAngkatan.Items.Add("2012");
            cmbAngkatan.Items.Add("2013");
            cmbAngkatan.Items.Add("2014");
            cmbAngkatan.Items.Add("2015");
            cmbAngkatan.Items.Add("2016");
            cmbAngkatan.Items.Add("2017");
            cmbAngkatan.Items.Add("2018");
            cmbAngkatan.Items.Add("2019");
            cmbAngkatan.Items.Add("2020");
            cmbAngkatan.Items.Add("2021");
            cmbAngkatan.Items.Add("2022");
            cmbAngkatan.Items.Add("2023");
            cmbAngkatan.Items.Add("2024");
            cmbAngkatan.Items.Add("2025");
            cmbAngkatan.Items.Add("2026");
            cmbAngkatan.Items.Add("2027");
            cmbAngkatan.Items.Add("2028");
            cmbAngkatan.Items.Add("2029");
            cmbAngkatan.Items.Add("2030");
        }

        public void isiTextBox(string npm, string nama, string tempatLahir, string tanggalLahir, string agama, string jeniKelamin, string angkatan, string awalStudi, string kewarganegaraan, string prodi, string kaprodi, string id)
        {
            txtNPM.Text = npm;
            txtNama.Text = nama;
            txtTempatLahir.Text = tempatLahir;
            dateTglLahir.Text = tanggalLahir;
            cmbAgama.Text = agama;
            cmbAngkatan.Text = angkatan;
            dateAwalStudi.Text = awalStudi;
            cmbKewarganegaraan.Text = kewarganegaraan;
            cmbProdi.Text = prodi;
            txtID.Text = id;
        }

        private bool cektxt()
        {
            bool temp = true;
            if (txtNPM.Text == "")
            {
                errorProvider1.SetError(txtNPM, "Silahkan isi npm mahasiswa..");
                txtNPM.Focus();
                temp = false;
            }
            if (txtNPM.TextLength < 9)
            {
                errorProvider1.SetError(txtNPM, "Silahkan isi npm mahasiswa sebanyak 9 karakter..");
                txtNPM.Focus();
                temp = false;
            }
            if (txtNama.Text == "")
            {
                errorProvider1.SetError(txtNama, "Silahkan isi nama mahasiswa..");
                txtNama.Focus();
                temp = false;
            }
            if (txtTempatLahir.Text == "")
            {
                errorProvider1.SetError(txtTempatLahir, "Silahkan isi tempat lahir Anda..");
                txtTempatLahir.Focus();
                temp = false;
            }
            if (cmbAgama.Text == "")
            {
                errorProvider1.SetError(cmbAgama, "Silahkan pilih agama Anda..");
                cmbAgama.Focus();
                temp = false;
            }
            if (dateTglLahir.Text == DateTime.Now.ToString("dd MMMM yyyy"))
            {
                errorProvider1.SetError(dateTglLahir, "Silahkan pilih tanggal lahir Anda..");
                dateTglLahir.Focus();
                temp = false;
            }
            if (!radioBtnLaki.Checked && !radioBtnPerempuan.Checked)
            {
                errorProvider1.SetError(radioBtnLaki, "Silahkan pilih jenis kelamin Anda..");
                errorProvider1.SetError(radioBtnPerempuan, "Silahkan pilih jenis kelamin Anda..");
                radioBtnLaki.Focus();
                radioBtnPerempuan.Focus();
                temp = false;
            }
            if (cmbAngkatan.Text == "")
            {
                errorProvider1.SetError(cmbAngkatan, "Silahkan pilih tahun angkatan Anda..");
                cmbAngkatan.Focus();
                temp = false;
            }
            if (dateAwalStudi.Text == DateTime.Now.ToString("dd MMMM yyyy"))
            {
                errorProvider1.SetError(dateAwalStudi, "Silahkan pilih tanggal awal masuk studi Anda..");
                dateAwalStudi.Focus();
                temp = false;
            }
            if (cmbKewarganegaraan.Text == "")
            {
                errorProvider1.SetError(cmbKewarganegaraan, "Silahkan pilih warga negara Anda..");
                cmbKewarganegaraan.Focus();
                temp = false;
            }

            if (cmbProdi.Text == "")
            {
                errorProvider1.SetError(cmbProdi, "Silahkan pilih program studi Anda..");
                cmbProdi.Focus();
                temp = false;
            }
            if (cmbKaprodi.Text == "")
            {
                errorProvider1.SetError(cmbKaprodi, "Silahkan pilih kaprodi..");
                cmbKaprodi.Focus();
                temp = false;
            }

            return temp;
        }

        private void UC_InputMhs_Load(object sender, EventArgs e)
        {
            cleartxt();
            comboAgama();
            comboAngkatan();
            comboWargaNegara();

            cmbProdi.DataSource = PC.getProdi();
            cmbProdi.DisplayMember = "nama_prodi";

            cmbKaprodi.DataSource = PC.getKaprodi();
            cmbKaprodi.DisplayMember = "nama_kaprodi";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            FormMahasiswa myParent = (FormMahasiswa)this.Parent;
            myParent.Enable();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            bool temp = true;
            temp = PC.cekNPM(txtNPM.Text);

            if (cektxt() == true)
            {
                if (flagperintah == 1)
                {

                    errorProvider1.Clear();
                    if (radioBtnLaki.Checked == true)
                    {
                        jenisKelaminMhs = "Laki-Laki";
                    }
                    else
                    {
                        jenisKelaminMhs = "Perempuan";
                    }
                    int IDProdi = PC.getIDProdi(cmbProdi.Text);
                    int IDKaprodi = PC.getIDKaprodi(cmbKaprodi.Text);
                    PascaMail.Entity.Mahasiswa M = new Entity.Mahasiswa(txtNPM.Text, txtNama.Text, IDProdi, IDKaprodi, txtTempatLahir.Text, dateTglLahir.Text, cmbAgama.Text, jenisKelaminMhs, cmbAngkatan.Text, dateAwalStudi.Text, cmbKewarganegaraan.Text);
                    PC.insertMhs(M);
                    MessageBox.Show("Mahasiswa berhasil diinputkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormMahasiswa myParent = (FormMahasiswa)this.Parent;
                    myParent.Enable();
                }
                else
                {
                    temp = false;
                    errorProvider1.Clear();
                    if (radioBtnLaki.Checked == true)
                    {
                        jenisKelaminMhs = "Laki-Laki";
                    }
                    else
                    {
                        jenisKelaminMhs = "Perempuan";
                    }
                    int IDProdi = PC.getIDProdi(cmbProdi.Text);
                    int IDKaprodi = PC.getIDKaprodi(cmbKaprodi.Text);
                    PascaMail.Entity.Mahasiswa M = new Entity.Mahasiswa(txtNPM.Text, txtNama.Text, IDProdi, IDKaprodi, txtTempatLahir.Text, dateTglLahir.Text, cmbAgama.Text, jenisKelaminMhs, cmbAngkatan.Text, dateAwalStudi.Text, cmbKewarganegaraan.Text);
                    PC.updateMhs(M, int.Parse(txtID.Text));
                    MessageBox.Show("Mahasiswa berhasil diinputkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormMahasiswa myParent = (FormMahasiswa)this.Parent;
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
