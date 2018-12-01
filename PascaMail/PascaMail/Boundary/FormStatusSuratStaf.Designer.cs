namespace PascaMail.Boundary
{
    partial class FormStatusSuratStaf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatusSuratStaf));
            this.btnAmplopSurat = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNPM = new System.Windows.Forms.Label();
            this.lblHalSurat = new System.Windows.Forms.Label();
            this.lblIdSurat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dataGridSurat = new System.Windows.Forms.DataGridView();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStaffAmbil = new System.Windows.Forms.Label();
            this.lblMakul = new System.Windows.Forms.Label();
            this.lblTglTesis = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblTglAmbil = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblStaffInput = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTglMasuk = new System.Windows.Forms.Label();
            this.lblTglWisuda = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUbah = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uC_UbahIP1 = new PascaMail.Boundary.UC_UbahIP();
            this.uC_UbahIPLain1 = new PascaMail.Boundary.UC_UbahIPLain();
            this.uC_UbahSK1 = new PascaMail.Boundary.UC_UbahSK();
            this.uC_UbahSKLain1 = new PascaMail.Boundary.UC_UbahSKLain();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSurat)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAmplopSurat
            // 
            this.btnAmplopSurat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAmplopSurat.Location = new System.Drawing.Point(924, 417);
            this.btnAmplopSurat.Name = "btnAmplopSurat";
            this.btnAmplopSurat.Size = new System.Drawing.Size(285, 45);
            this.btnAmplopSurat.TabIndex = 32;
            this.btnAmplopSurat.Text = "Cetak Amplop Surat";
            this.btnAmplopSurat.UseVisualStyleBackColor = false;
            this.btnAmplopSurat.Click += new System.EventHandler(this.btnAmplopSurat_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLaporan.Location = new System.Drawing.Point(924, 519);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(285, 48);
            this.btnLaporan.TabIndex = 31;
            this.btnLaporan.Text = "Laporan Keseluruhan Surat";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblNPM);
            this.panel2.Controls.Add(this.lblHalSurat);
            this.panel2.Controls.Add(this.lblIdSurat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(924, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 179);
            this.panel2.TabIndex = 26;
            // 
            // lblNPM
            // 
            this.lblNPM.AutoSize = true;
            this.lblNPM.Location = new System.Drawing.Point(81, 133);
            this.lblNPM.Name = "lblNPM";
            this.lblNPM.Size = new System.Drawing.Size(35, 13);
            this.lblNPM.TabIndex = 6;
            this.lblNPM.Text = "label7";
            // 
            // lblHalSurat
            // 
            this.lblHalSurat.AutoSize = true;
            this.lblHalSurat.Location = new System.Drawing.Point(81, 96);
            this.lblHalSurat.Name = "lblHalSurat";
            this.lblHalSurat.Size = new System.Drawing.Size(35, 13);
            this.lblHalSurat.TabIndex = 5;
            this.lblHalSurat.Text = "label6";
            // 
            // lblIdSurat
            // 
            this.lblIdSurat.AutoSize = true;
            this.lblIdSurat.Location = new System.Drawing.Point(81, 57);
            this.lblIdSurat.Name = "lblIdSurat";
            this.lblIdSurat.Size = new System.Drawing.Size(35, 13);
            this.lblIdSurat.TabIndex = 4;
            this.lblIdSurat.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NPM   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Perihal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nomor :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA SURAT";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(10, 570);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator1.TabIndex = 24;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Location = new System.Drawing.Point(10, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 62);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian Berdasarkan NPM Mahasiswa";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(6, 19);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(372, 37);
            this.txtCari.TabIndex = 1;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // dataGridSurat
            // 
            this.dataGridSurat.AllowUserToAddRows = false;
            this.dataGridSurat.AllowUserToDeleteRows = false;
            this.dataGridSurat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSurat.Location = new System.Drawing.Point(10, 171);
            this.dataGridSurat.Name = "dataGridSurat";
            this.dataGridSurat.ReadOnly = true;
            this.dataGridSurat.Size = new System.Drawing.Size(905, 396);
            this.dataGridSurat.TabIndex = 22;
            this.dataGridSurat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSurat_CellClick);
            this.dataGridSurat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSurat_CellContentClick);
            this.dataGridSurat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridSurat_KeyUp);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPreview.Location = new System.Drawing.Point(924, 366);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(285, 45);
            this.btnPreview.TabIndex = 29;
            this.btnPreview.Text = "Cetak Surat";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRefresh.Location = new System.Drawing.Point(924, 326);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(285, 34);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblStaffAmbil);
            this.panel1.Controls.Add(this.lblMakul);
            this.panel1.Controls.Add(this.lblTglTesis);
            this.panel1.Controls.Add(this.lblKeterangan);
            this.panel1.Controls.Add(this.lblTglAmbil);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRow);
            this.panel1.Controls.Add(this.lblAlamat);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblStaffInput);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblTglMasuk);
            this.panel1.Controls.Add(this.lblTglWisuda);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 94);
            this.panel1.TabIndex = 28;
            // 
            // lblStaffAmbil
            // 
            this.lblStaffAmbil.AutoSize = true;
            this.lblStaffAmbil.Location = new System.Drawing.Point(629, 41);
            this.lblStaffAmbil.Name = "lblStaffAmbil";
            this.lblStaffAmbil.Size = new System.Drawing.Size(54, 13);
            this.lblStaffAmbil.TabIndex = 21;
            this.lblStaffAmbil.Text = "StaffAmbil";
            // 
            // lblMakul
            // 
            this.lblMakul.AutoSize = true;
            this.lblMakul.Location = new System.Drawing.Point(257, 63);
            this.lblMakul.Name = "lblMakul";
            this.lblMakul.Size = new System.Drawing.Size(36, 13);
            this.lblMakul.TabIndex = 20;
            this.lblMakul.Text = "Makul";
            // 
            // lblTglTesis
            // 
            this.lblTglTesis.AutoSize = true;
            this.lblTglTesis.Location = new System.Drawing.Point(442, 11);
            this.lblTglTesis.Name = "lblTglTesis";
            this.lblTglTesis.Size = new System.Drawing.Size(47, 13);
            this.lblTglTesis.TabIndex = 19;
            this.lblTglTesis.Text = "TglTesis";
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(442, 28);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(62, 13);
            this.lblKeterangan.TabIndex = 18;
            this.lblKeterangan.Text = "Keterangan";
            // 
            // lblTglAmbil
            // 
            this.lblTglAmbil.AutoSize = true;
            this.lblTglAmbil.Location = new System.Drawing.Point(246, 44);
            this.lblTglAmbil.Name = "lblTglAmbil";
            this.lblTglAmbil.Size = new System.Drawing.Size(47, 13);
            this.lblTglAmbil.TabIndex = 17;
            this.lblTglAmbil.Text = "TglAmbil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(729, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(482, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = "PENGELOLAAN STATUS SURAT";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(209, 41);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(31, 20);
            this.txtRow.TabIndex = 14;
            this.txtRow.Visible = false;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(442, 63);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(39, 13);
            this.lblAlamat.TabIndex = 5;
            this.lblAlamat.Text = "Alamat";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(209, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(31, 20);
            this.txtID.TabIndex = 15;
            this.txtID.Visible = false;
            // 
            // lblStaffInput
            // 
            this.lblStaffInput.AutoSize = true;
            this.lblStaffInput.Location = new System.Drawing.Point(629, 11);
            this.lblStaffInput.Name = "lblStaffInput";
            this.lblStaffInput.Size = new System.Drawing.Size(53, 13);
            this.lblStaffInput.TabIndex = 4;
            this.lblStaffInput.Text = "StaffInput";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(629, 63);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // lblTglMasuk
            // 
            this.lblTglMasuk.AutoSize = true;
            this.lblTglMasuk.Location = new System.Drawing.Point(246, 18);
            this.lblTglMasuk.Name = "lblTglMasuk";
            this.lblTglMasuk.Size = new System.Drawing.Size(54, 13);
            this.lblTglMasuk.TabIndex = 1;
            this.lblTglMasuk.Text = "TglMasuk";
            // 
            // lblTglWisuda
            // 
            this.lblTglWisuda.AutoSize = true;
            this.lblTglWisuda.Location = new System.Drawing.Point(442, 48);
            this.lblTglWisuda.Name = "lblTglWisuda";
            this.lblTglWisuda.Size = new System.Drawing.Size(58, 13);
            this.lblTglWisuda.TabIndex = 2;
            this.lblTglWisuda.Text = "TglWisuda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(921, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pilihan Menu";
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUbah.Location = new System.Drawing.Point(924, 468);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(287, 45);
            this.btnUbah.TabIndex = 25;
            this.btnUbah.Text = "Ubah Status Surat";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.PositionChanged += new System.EventHandler(this.bindingSource1_PositionChanged);
            // 
            // uC_UbahIP1
            // 
            this.uC_UbahIP1.Location = new System.Drawing.Point(304, 6);
            this.uC_UbahIP1.Name = "uC_UbahIP1";
            this.uC_UbahIP1.Size = new System.Drawing.Size(558, 596);
            this.uC_UbahIP1.TabIndex = 33;
            // 
            // uC_UbahIPLain1
            // 
            this.uC_UbahIPLain1.Location = new System.Drawing.Point(320, 6);
            this.uC_UbahIPLain1.Name = "uC_UbahIPLain1";
            this.uC_UbahIPLain1.Size = new System.Drawing.Size(555, 590);
            this.uC_UbahIPLain1.TabIndex = 34;
            // 
            // uC_UbahSK1
            // 
            this.uC_UbahSK1.Location = new System.Drawing.Point(304, 6);
            this.uC_UbahSK1.Name = "uC_UbahSK1";
            this.uC_UbahSK1.Size = new System.Drawing.Size(555, 533);
            this.uC_UbahSK1.TabIndex = 35;
            // 
            // uC_UbahSKLain1
            // 
            this.uC_UbahSKLain1.Location = new System.Drawing.Point(297, 6);
            this.uC_UbahSKLain1.Name = "uC_UbahSKLain1";
            this.uC_UbahSKLain1.Size = new System.Drawing.Size(554, 603);
            this.uC_UbahSKLain1.TabIndex = 36;
            // 
            // FormStatusSuratStaf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 618);
            this.Controls.Add(this.uC_UbahSKLain1);
            this.Controls.Add(this.uC_UbahSK1);
            this.Controls.Add(this.uC_UbahIPLain1);
            this.Controls.Add(this.uC_UbahIP1);
            this.Controls.Add(this.btnAmplopSurat);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridSurat);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUbah);
            this.Name = "FormStatusSuratStaf";
            this.Text = "FormStatusSuratStaf";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStatusSuratStaf_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSurat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAmplopSurat;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNPM;
        private System.Windows.Forms.Label lblHalSurat;
        private System.Windows.Forms.Label lblIdSurat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dataGridSurat;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStaffAmbil;
        private System.Windows.Forms.Label lblMakul;
        private System.Windows.Forms.Label lblTglTesis;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblTglAmbil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblStaffInput;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTglMasuk;
        private System.Windows.Forms.Label lblTglWisuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.BindingSource bindingSource1;
        private UC_UbahIP uC_UbahIP1;
        private UC_UbahIPLain uC_UbahIPLain1;
        private UC_UbahSK uC_UbahSK1;
        private UC_UbahSKLain uC_UbahSKLain1;
    }
}