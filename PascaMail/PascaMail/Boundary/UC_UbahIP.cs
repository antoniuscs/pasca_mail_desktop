﻿using System;
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
    public partial class UC_UbahIP : UserControl
    {
        public UC_UbahIP()
        {
            InitializeComponent();
        }

        int flagperintah = 0;
        public void setflag(int flag)
        {
            flagperintah = flag;
        }

        PascaControl MC = new PascaControl();

        string temp = "";
        public void isiTextBox(string idSurat, string perihal, string tglMasuk, string tglAmbil, string npm, string alamat, string keterangan, string staffInput, string staffAmbil, string status, string id)
        {
            lblIdSurat.Text = idSurat;
            temp = idSurat;
            lblPerihal.Text = perihal;
            dateMasuk.Text = tglMasuk;
            dateAmbil.Text = tglAmbil;
            lblNPM.Text = npm;
            cmbStaffInput.Text = staffInput;
            cmbStaffAmbil.Text = staffAmbil;
            cmbStatus.Text = status;
            txtKeterangan.Text = keterangan;
            txtAlamat.Text = alamat;
            txtID.Text = id;
        }

        private bool cektxt()
        {
            bool temp = true;
            if (dateMasuk.Text == dateAmbil.Text)
            {
                errorProvider1.SetError(dateAmbil, "Silahkan pilih tanggal surat ambil...");
                dateAmbil.Focus();
                temp = false;
            }

            return temp;
        }
        private void UC_UbahIP_Load(object sender, EventArgs e)
        {
            cmbMakul.Visible = false;
            cmbMakul.SelectedText = "";
            cmbMakul.DataSource = MC.getMakul();
            cmbMakul.DisplayMember = "nama_mata_kuliah";

            dateMasuk.Enabled = false;
            cmbStaffInput.Enabled = false;
            cmbStaffInput.DataSource = MC.getStaff();
            cmbStaffInput.DisplayMember = "nama_staff";

            cmbStaffAmbil.DataSource = MC.getStaff();
            cmbStaffAmbil.DisplayMember = "nama_staff";

            cmbStatus.DataSource = MC.getStatus();
            cmbStatus.DisplayMember = "nama_status";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStatusSuratStaf myParent = (FormStatusSuratStaf)this.Parent;
            myParent.EnableEdit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cektxt() == true)
            {
                errorProvider1.Clear();

                int IDStatus = MC.getIDStatus(cmbStatus.Text);
                int IDStaffInput = MC.getIDStaff(cmbStaffInput.Text);
                int IDStaffAmbil = MC.getIDStaff(cmbStaffAmbil.Text);
                int IDMakul = MC.getIDMakul(cmbMakul.Text);
                PascaMail.Entity.Surat S = new Entity.Surat(lblIdSurat.Text, lblPerihal.Text, lblNPM.Text, dateMasuk.Text, dateAmbil.Text, txtKeterangan.Text, "", "", IDMakul, txtAlamat.Text, IDStaffInput, IDStaffAmbil, IDStatus);
                MC.updateSurat(S, int.Parse(txtID.Text));
                MessageBox.Show("Surat berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormStatusSuratStaf myParent = (FormStatusSuratStaf)this.Parent;
                myParent.EnableEdit();
            }
            else
            {
                MessageBox.Show("Silahkan lengkapi data terlebih dahulu..", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    }
}
