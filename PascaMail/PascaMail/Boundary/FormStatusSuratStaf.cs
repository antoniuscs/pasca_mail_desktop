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
    public partial class FormStatusSuratStaf : Form
    {
        public FormStatusSuratStaf()
        {
            InitializeComponent();
        }

        PascaControl PC = new PascaControl();

        public void showDatagridViewSurat(DataGridView DG)
        {
            DG.DataSource = PC.showSurat();

            //Code Data Binding
            DataTable DT = PC.showSurat();
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
                    if (counter == 15)
                        counter = 0;
                }
            }
            bindingSource1.DataSource = listTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            DG.DataSource = (DT.Rows.Count > 0 ? listTbl[bindingSource1.Position] : DT);

            DG.Columns[0].Visible = false;
            DG.Columns[1].HeaderText = "ID SURAT";
            DG.Columns[2].HeaderText = "HAL SURAT";
            DG.Columns[3].HeaderText = "TANGGAL INPUT";
            DG.Columns[4].HeaderText = "TANGGAL AMBIL";
            DG.Columns[5].HeaderText = "KETERANGAN";
            DG.Columns[6].Visible = false;
            DG.Columns[7].Visible = false;
            DG.Columns[8].HeaderText = "ALAMAT";
            DG.Columns[9].HeaderText = "NPM";
            DG.Columns[10].Visible = false;
            DG.Columns[11].HeaderText = "NAMA STAFF INPUT";
            DG.Columns[12].HeaderText = "NAMA STAFF AMBIL";
            DG.Columns[13].HeaderText = "STATUS SURAT";

            DG.Columns[1].Width = 70;
            DG.Columns[2].Width = 140;
            DG.Columns[3].Width = 100;
            DG.Columns[4].Width = 100;
            DG.Columns[5].Width = 100;
            DG.Columns[8].Width = 100;
            DG.Columns[9].Width = 70;
            DG.Columns[11].Width = 50;
            DG.Columns[12].Width = 50;
            DG.Columns[13].Width = 90;
        }

        public void searchDatagridViewSurat(DataGridView DG, string keyword)
        {
            DG.DataSource = PC.searchSurat(keyword);

            //Code Data Binding
            DataTable DT = PC.searchSurat(keyword);
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
                    if (counter == 15)
                        counter = 0;
                }
            }
            bindingSource1.DataSource = listTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            DG.DataSource = (DT.Rows.Count > 0 ? listTbl[bindingSource1.Position] : DT);

            DG.Columns[0].Visible = false;
            DG.Columns[1].HeaderText = "ID SURAT";
            DG.Columns[2].HeaderText = "HAL SURAT";
            DG.Columns[3].HeaderText = "TANGGAL INPUT";
            DG.Columns[4].HeaderText = "TANGGAL AMBIL";
            DG.Columns[5].HeaderText = "KETERANGAN";
            DG.Columns[6].Visible = false;
            DG.Columns[7].Visible = false;
            DG.Columns[8].HeaderText = "ALAMAT";
            DG.Columns[9].HeaderText = "NPM";
            DG.Columns[10].Visible = false;
            DG.Columns[11].HeaderText = "NAMA STAFF INPUT";
            DG.Columns[12].HeaderText = "NAMA STAFF AMBIL";
            DG.Columns[13].HeaderText = "STATUS SURAT";

            DG.Columns[1].Width = 70;
            DG.Columns[2].Width = 140;
            DG.Columns[3].Width = 100;
            DG.Columns[4].Width = 100;
            DG.Columns[5].Width = 100;
            DG.Columns[8].Width = 100;
            DG.Columns[9].Width = 70;
            DG.Columns[11].Width = 50;
            DG.Columns[12].Width = 50;
            DG.Columns[13].Width = 90;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            searchDatagridViewSurat(this.dataGridSurat, txtCari.Text);
        }

        private void dataGridSurat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridSurat, 0);
            lblIdSurat.Text = getKolom(dataGridSurat, 1);
            lblHalSurat.Text = getKolom(dataGridSurat, 2);
            lblTglMasuk.Text = getKolom(dataGridSurat, 3);
            lblTglAmbil.Text = getKolom(dataGridSurat, 4);
            lblKeterangan.Text = getKolom(dataGridSurat, 5);
            lblTglTesis.Text = getKolom(dataGridSurat, 6);
            lblTglWisuda.Text = getKolom(dataGridSurat, 7);
            lblAlamat.Text = getKolom(dataGridSurat, 8);
            lblNPM.Text = getKolom(dataGridSurat, 9);
            lblMakul.Text = getKolom(dataGridSurat, 10);
            lblStaffInput.Text = getKolom(dataGridSurat, 11);
            lblStaffAmbil.Text = getKolom(dataGridSurat, 12);
            lblStatus.Text = getKolom(dataGridSurat, 13);
            txtRow.Text = getRow(dataGridSurat);
        }

        private void dataGridSurat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridSurat, 0);
            txtRow.Text = getRow(dataGridSurat);
        }

        private void dataGridSurat_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridSurat, 0);
            txtRow.Text = getRow(dataGridSurat);
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

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.searchDatagridViewSurat(dataGridSurat, this.txtCari.Text);
            if (txtCari.Text == "")
            {
                this.showDatagridViewSurat(dataGridSurat);
            }
        }

        private void cleartxt()
        {
            lblIdSurat.Text = "-";
            lblHalSurat.Text = "-";
            lblNPM.Text = "-";
            txtCari.Clear();
            txtID.Visible = false;
            lblTglMasuk.Visible = false;
            lblTglAmbil.Visible = false;
            lblKeterangan.Visible = false;
            lblTglTesis.Visible = false;
            lblTglWisuda.Visible = false;
            lblAlamat.Visible = false;
            lblMakul.Visible = false;
            lblStaffInput.Visible = false;
            lblStaffAmbil.Visible = false;
            lblStatus.Visible = false;
            txtRow.Visible = false;
        }

        private void disable()
        {
            txtCari.Enabled = false;
            btnUbah.Enabled = false;
            btnAmplopSurat.Enabled = false;
            btnLaporan.Enabled = false;
            btnPreview.Enabled = false;
            dataGridSurat.Enabled = false;
        }

        public void Enable()
        {
            txtCari.Enabled = true;
            btnUbah.Enabled = true;
            btnAmplopSurat.Enabled = true;
            btnLaporan.Enabled = true;
            btnPreview.Enabled = true;
            dataGridSurat.Enabled = true;
            showDatagridViewSurat(this.dataGridSurat);

            if (dataGridSurat.RowCount > 0)
            {
                dataGridSurat.Rows[0].Selected = true;
                lblIdSurat.Text = getKolom(dataGridSurat, 1);
                txtID.Text = getKolom(dataGridSurat, 0);
            }
        }

        public void EnableEdit()
        {
            txtCari.Enabled = true;
            btnUbah.Enabled = true;
            btnAmplopSurat.Enabled = true;
            btnLaporan.Enabled = true;
            btnPreview.Enabled = true;
            dataGridSurat.Enabled = true;
            showDatagridViewSurat(this.dataGridSurat);

            if (dataGridSurat.RowCount > 0)
            {
                dataGridSurat.Rows[0].Selected = true;
                lblIdSurat.Text = getKolom(dataGridSurat, 1);
                txtID.Text = getKolomEdit(dataGridSurat, int.Parse(txtRow.Text));
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (lblIdSurat.Text == "-")
            {
                MessageBox.Show("Silahkan pilih data surat terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridSurat.Focus();
            }
            else
            {
                if (lblHalSurat.Text == "Surat Keterangan")
                {
                    uC_UbahSK1.setflag(1);
                    uC_UbahSK1.isiTextBox(lblIdSurat.Text, lblHalSurat.Text, lblTglMasuk.Text, lblTglAmbil.Text, lblTglWisuda.Text, lblNPM.Text, lblTglTesis.Text, lblStaffInput.Text, lblStaffAmbil.Text, lblStatus.Text, txtID.Text);
                    uC_UbahSK1.Visible = true;
                }
                else if (lblHalSurat.Text == "Surat Keterangan Lainnya")
                {
                    uC_UbahSKLain1.setflag(1);
                    uC_UbahSKLain1.isiTextBox(lblIdSurat.Text, lblHalSurat.Text, lblTglMasuk.Text, lblTglAmbil.Text, lblNPM.Text, lblAlamat.Text, lblKeterangan.Text, lblStaffInput.Text, lblStaffAmbil.Text, lblStatus.Text, txtID.Text);
                    uC_UbahSKLain1.Visible = true;
                }
                else if (lblHalSurat.Text == "Permohonan Ijin Penelitian")
                {
                    uC_UbahIP1.setflag(1);
                    uC_UbahIP1.isiTextBox(lblIdSurat.Text, lblHalSurat.Text, lblTglMasuk.Text, lblTglAmbil.Text, lblNPM.Text, lblAlamat.Text, lblKeterangan.Text, lblStaffInput.Text, lblStaffAmbil.Text, lblStatus.Text, txtID.Text);
                    uC_UbahIP1.Visible = true;
                }
                else
                {
                    uC_UbahIPLain1.setflag(1);
                    uC_UbahIPLain1.isiTextBox(lblIdSurat.Text, lblHalSurat.Text, lblTglMasuk.Text, lblMakul.Text, lblTglAmbil.Text, lblNPM.Text, lblAlamat.Text, lblKeterangan.Text, lblStaffInput.Text, lblStaffAmbil.Text, lblStatus.Text, txtID.Text);
                    uC_UbahIPLain1.Visible = true;
                }
                disable();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (lblIdSurat.Text == "-")
            {
                MessageBox.Show("Silahkan pilih data surat terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridSurat.Focus();
            }
            else
            {
                if (lblHalSurat.Text == "Surat Keterangan")
                {
                    CetakSuratKeterangan CSK = new CetakSuratKeterangan();
                    CSK.setID(lblIdSurat.Text);
                    CSK.Show();
                }
                else if (lblHalSurat.Text == "Surat Keterangan Lainnya")
                {
                    CetakSuratKeteranganLainnya CSK = new CetakSuratKeteranganLainnya();
                    CSK.setID(lblIdSurat.Text);
                    CSK.Show();
                }
                else if (lblHalSurat.Text == "Permohonan Ijin Penelitian")
                {
                    CetakIjinPenelitian CIP = new CetakIjinPenelitian();
                    CIP.setID(lblIdSurat.Text);
                    CIP.Show();
                }
                else
                {
                    CetakIjinPenelitianLain CIP = new CetakIjinPenelitianLain();
                    CIP.setID(lblIdSurat.Text);
                    CIP.Show();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cleartxt();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            FormLaporanSurat FLP = new FormLaporanSurat();
            FLP.Show();
        }

        private void btnAmplopSurat_Click(object sender, EventArgs e)
        {
            if (lblIdSurat.Text == "-")
            {
                MessageBox.Show("Silahkan pilih data surat terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataGridSurat.Focus();
            }
            else
            {
                CetakAmplopSurat CAS = new CetakAmplopSurat();
                CAS.setID(lblIdSurat.Text);
                CAS.Show();
            }
        }

        private void FormStatusSuratStaf_Load(object sender, EventArgs e)
        {
            cleartxt();
            showDatagridViewSurat(this.dataGridSurat);
            uC_UbahSK1.Visible = false;
            uC_UbahSKLain1.Visible = false;
            uC_UbahIP1.Visible = false;
            uC_UbahIPLain1.Visible = false;
        }
    }
}
