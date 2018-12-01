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
    public partial class UC_IjinPenelitian : UserControl
    {
        public UC_IjinPenelitian()
        {
            InitializeComponent();
        }

        int flagperintah = 0;
        public void setflag(int flag)
        {
            flagperintah = flag;
        }

        PascaControl MC = new PascaControl();
        string idsurat = "";

        public void isiTextBox(string npm, string nama, string prodi, string kaprodi, string halSurat)
        {
            lblNPM.Text = npm;
            lblNama.Text = nama;
            lblProdi.Text = prodi;
            lblKaprodi.Text = kaprodi;
            lblHalSurat.Text = halSurat;
        }

        private void UC_IjinPenelitian_Load(object sender, EventArgs e)
        {
            cleartxt();

            cmbStaff.DataSource = MC.getStaff();
            cmbStaff.DisplayMember = "nama_staff";

            cmbStatusSurat.Enabled = false;
            cmbStatusSurat.DataSource = MC.getStatus();
            cmbStatusSurat.DisplayMember = "nama_status";

            cmbMakul.DataSource = MC.getMakul();
            cmbMakul.DisplayMember = "nama_mata_kuliah";
        }

        private bool cektxt()
        {
            bool temp = true;
            if (txtKeterangan.Text == "")
            {
                errorProvider1.SetError(txtKeterangan, "Silahkan isi judul tesis");
                txtKeterangan.Focus();
                temp = false;
            }
            if (!radioBtnInt.Checked && !radioBtnEks.Checked)
            {
                errorProvider1.SetError(radioBtnInt, "Silahkan pilih jenis surat...");
                errorProvider1.SetError(radioBtnEks, "Silahkan pilih jenis surat...");
                temp = false;
            }
            if (txtAlamat.Text == "")
            {
                errorProvider1.SetError(txtAlamat, "Silahkan isi alamat tujuan instansi...");
                txtAlamat.Focus();
                temp = false;
            }
            if (cmbStaff.Text == "")
            {
                errorProvider1.SetError(cmbStaff, "Silahkan pilih nama staff...");
                cmbStaff.Focus();
                temp = false;
            }
            if (cmbStatusSurat.Text == "")
            {
                errorProvider1.SetError(cmbStatusSurat, "Silahkan pilih status surat...");
                cmbStatusSurat.Focus();
                temp = false;
            }
            if (dateSurat.Text == "")
            {
                errorProvider1.SetError(dateSurat, "Silahkan pilih tanggal Surat...");
                dateSurat.Focus();
                temp = false;
            }

            return temp;
        }

        private void cleartxt()
        {
            txtAlamat.Clear();
            txtKeterangan.Clear();
            cmbStaff.SelectedIndex = -1;
            cmbStatusSurat.SelectedText = "";
            cmbMakul.SelectedText = "";
            cmbMakul.Visible = false;
            radioBtnEks.Checked = false;
            radioBtnInt.Checked = false;
            lblNPM.Text = "-";
            lblNama.Text = "-";
            lblProdi.Visible = false;
            lblKaprodi.Visible = false;
            lblIdSurat.Visible = false;
            lblHalSurat.Visible = false;
            btnPreview.Enabled = false;
            btnSelesai.Enabled = true;
        }

        //Fungsi untuk membuat ID Surat secara berurutan sesuai Prodi
        public void generateIdCustomer()
        {
            int month = dateSurat.Value.Month;
            string temp_month = "";
            if (month == 1)
            {
                temp_month = "I";
            }
            else if (month == 2)
            {
                temp_month = "II";
            }
            else if (month == 3)
            {
                temp_month = "III";
            }
            else if (month == 4)
            {
                temp_month = "IV";
            }
            else if (month == 5)
            {
                temp_month = "V";
            }
            else if (month == 6)
            {
                temp_month = "VI";
            }
            else if (month == 7)
            {
                temp_month = "VII";
            }
            else if (month == 8)
            {
                temp_month = "VIII";
            }
            else if (month == 9)
            {
                temp_month = "IX";
            }
            else if (month == 10)
            {
                temp_month = "X";
            }
            else if (month == 11)
            {
                temp_month = "XI";
            }
            else if (month == 12)
            {
                temp_month = "XII";
            }
            int urut = MC.getCountRowSurat() + 1;
            string temp_urut = urut.ToString();
            if (radioBtnInt.Checked == true)
            {
                if (urut < 10)
                {
                    if (lblProdi.Text == "Magister Manajemen")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " In " + "/" + " III";
                    }
                    else if (lblProdi.Text == "Magister Teknik Sipil")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " In " + "/" + " IV";
                    }
                    else if (lblProdi.Text == "Magister Arsitektur")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " In " + "/" + " VII";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Hukum")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " In " + "/" + " V";
                    }
                    else if (lblProdi.Text == "Magister Teknik Informatika")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " In " + "/" + " VI";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Komunikasi")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " In " + "/" + " IX";
                    }
                }
                else if (urut < 100 && urut > 9)
                {
                    if (lblProdi.Text == "Magister Manajemen")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " In " + "/" + " III";
                    }
                    else if (lblProdi.Text == "Magister Teknik Sipil")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " In " + "/" + " IV";
                    }
                    else if (lblProdi.Text == "Magister Arsitektur")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " In " + "/" + " VII";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Hukum")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " In " + "/" + " V";
                    }
                    else if (lblProdi.Text == "Magister Teknik Informatika")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " In " + "/" + " VI";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Komunikasi")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " In " + "/" + " IX";
                    }
                }
                else if (urut > 99)
                {
                    if (lblProdi.Text == "Magister Manajemen")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " In " + "/" + " III";
                    }
                    else if (lblProdi.Text == "Magister Teknik Sipil")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " In " + "/" + " IV";
                    }
                    else if (lblProdi.Text == "Magister Arsitektur")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " In " + "/" + " VII";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Hukum")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " In " + "/" + " V";
                    }
                    else if (lblProdi.Text == "Magister Teknik Informatika")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " In " + "/" + " VI";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Komunikasi")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " In " + "/" + " IX";
                    }
                }
            }
            else if (radioBtnEks.Checked == true)
            {
                if (urut < 10)
                {
                    if (lblProdi.Text == "Magister Manajemen")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " III";
                    }
                    else if (lblProdi.Text == "Magister Teknik Sipil")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " IV";
                    }
                    else if (lblProdi.Text == "Magister Arsitektur")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " VII";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Hukum")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " V";
                    }
                    else if (lblProdi.Text == "Magister Teknik Informatika")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " VI";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Komunikasi")
                    {
                        idsurat = "00" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " IX";
                    }
                }
                else if (urut < 100 && urut > 9)
                {
                    if (lblProdi.Text == "Magister Manajemen")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " III";
                    }
                    else if (lblProdi.Text == "Magister Teknik Sipil")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " IV";
                    }
                    else if (lblProdi.Text == "Magister Arsitektur")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " VII";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Hukum")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " V";
                    }
                    else if (lblProdi.Text == "Magister Teknik Informatika")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " VI";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Komunikasi")
                    {
                        idsurat = "0" + temp_urut + "." + temp_month + " /" + " Eks " + "/" + " IX";
                    }
                }
                else if (urut > 99)
                {
                    if (lblProdi.Text == "Magister Manajemen")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " Eks " + "/" + " III";
                    }
                    else if (lblProdi.Text == "Magister Teknik Sipil")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " Eks " + "/" + " IV";
                    }
                    else if (lblProdi.Text == "Magister Arsitektur")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " Eks " + "/" + " VII";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Hukum")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " Eks " + "/" + " V";
                    }
                    else if (lblProdi.Text == "Magister Teknik Informatika")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " Eks " + "/" + " VI";
                    }
                    else if (lblProdi.Text == "Magister Ilmu Komunikasi")
                    {
                        idsurat = temp_urut + "." + temp_month + " /" + " Eks " + "/" + " IX";
                    }
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            CetakIjinPenelitian CIP = new CetakIjinPenelitian();
            CIP.setID(idsurat);
            CIP.Show();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah semua data sudah diisi dengan benar ? ", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (cektxt() == true)
                {
                    errorProvider1.Clear();
                    generateIdCustomer();

                    int IDStatus = MC.getIDStatus(cmbStatusSurat.Text);
                    int IDStaff = MC.getIDStaff(cmbStaff.Text);
                    int IDMakul = MC.getIDMakul(cmbMakul.Text);
                    PascaMail.Entity.Surat S = new Entity.Surat(idsurat, lblHalSurat.Text, lblNPM.Text, dateSurat.Text, "", txtKeterangan.Text, "", "", IDMakul, txtAlamat.Text, IDStaff, IDStaff, IDStatus);
                    MC.inputSurat(S);
                    btnSelesai.Enabled = false;
                    btnPreview.Enabled = true;
                    MessageBox.Show("Surat berhasil dibuat", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silahkan lengkapi data terlebih dahulu..", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if (cektxt() == true)
            {
                disableBatal();
            }
            else
            {
                MessageBox.Show("Silahkan lengkapi data dan selesaikan terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void disableBatal()
        {
            errorProvider1.Clear();
            txtKeterangan.Clear();
            txtAlamat.Clear();
            radioBtnEks.Checked = false;
            radioBtnInt.Checked = false;
            cmbStaff.SelectedIndex = -1;
            cmbStatusSurat.SelectedIndex = -1;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            FormPengelola myParent = (FormPengelola)this.Parent;
            myParent.Enable();
        }
    }
}
