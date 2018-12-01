namespace PascaMail
{
    partial class FormPengelola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPengelola));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHal = new System.Windows.Forms.Label();
            this.btnSKLain = new System.Windows.Forms.Button();
            this.btnIjinLain = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSKL = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNPM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridMahasiswa = new System.Windows.Forms.DataGridView();
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
            this.btnIjin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKaprodi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uC_SuratKeterangan1 = new PascaMail.Boundary.UC_SuratKeterangan();
            this.uC_IjinPenelitian1 = new PascaMail.Boundary.UC_IjinPenelitian();
            this.uC_IjinPenelitianLain1 = new PascaMail.Boundary.UC_IjinPenelitianLain();
            this.uC_SuratKeteranganLain1 = new PascaMail.Boundary.UC_SuratKeteranganLain();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMahasiswa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblHal);
            this.panel1.Controls.Add(this.btnSKLain);
            this.panel1.Controls.Add(this.btnIjinLain);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBatal);
            this.panel1.Controls.Add(this.btnSKL);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridMahasiswa);
            this.panel1.Controls.Add(this.bindingNavigator1);
            this.panel1.Controls.Add(this.btnIjin);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-5, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 519);
            this.panel1.TabIndex = 0;
            // 
            // lblHal
            // 
            this.lblHal.AutoSize = true;
            this.lblHal.Location = new System.Drawing.Point(752, 14);
            this.lblHal.Name = "lblHal";
            this.lblHal.Size = new System.Drawing.Size(35, 13);
            this.lblHal.TabIndex = 11;
            this.lblHal.Text = "label7";
            this.lblHal.Visible = false;
            // 
            // btnSKLain
            // 
            this.btnSKLain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSKLain.Location = new System.Drawing.Point(505, 363);
            this.btnSKLain.Name = "btnSKLain";
            this.btnSKLain.Size = new System.Drawing.Size(282, 38);
            this.btnSKLain.TabIndex = 10;
            this.btnSKLain.Text = "Surat Keterangan Lainnya";
            this.btnSKLain.UseVisualStyleBackColor = false;
            this.btnSKLain.Click += new System.EventHandler(this.btnSKLain_Click);
            // 
            // btnIjinLain
            // 
            this.btnIjinLain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIjinLain.Location = new System.Drawing.Point(505, 275);
            this.btnIjinLain.Name = "btnIjinLain";
            this.btnIjinLain.Size = new System.Drawing.Size(282, 38);
            this.btnIjinLain.TabIndex = 9;
            this.btnIjinLain.Text = "Permohonan Ijin Lainnya";
            this.btnIjinLain.UseVisualStyleBackColor = false;
            this.btnIjinLain.Click += new System.EventHandler(this.btnIjinLain_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pilihan Surat";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBatal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBatal.Location = new System.Drawing.Point(505, 424);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(282, 57);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Refresh";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSKL
            // 
            this.btnSKL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSKL.Location = new System.Drawing.Point(505, 319);
            this.btnSKL.Name = "btnSKL";
            this.btnSKL.Size = new System.Drawing.Size(282, 38);
            this.btnSKL.TabIndex = 4;
            this.btnSKL.Text = "Surat Keterangan Lulus";
            this.btnSKL.UseVisualStyleBackColor = false;
            this.btnSKL.Click += new System.EventHandler(this.btnSK_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblNama);
            this.panel2.Controls.Add(this.lblNPM);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblProdi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(505, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 143);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Program Studi : ";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(66, 78);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(35, 13);
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "label5";
            // 
            // lblNPM
            // 
            this.lblNPM.AutoSize = true;
            this.lblNPM.Location = new System.Drawing.Point(66, 49);
            this.lblNPM.Name = "lblNPM";
            this.lblNPM.Size = new System.Drawing.Size(35, 13);
            this.lblNPM.TabIndex = 3;
            this.lblNPM.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NPM  :";
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Location = new System.Drawing.Point(104, 107);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(35, 13);
            this.lblProdi.TabIndex = 5;
            this.lblProdi.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA MAHASISWA";
            // 
            // dataGridMahasiswa
            // 
            this.dataGridMahasiswa.AllowUserToAddRows = false;
            this.dataGridMahasiswa.AllowUserToDeleteRows = false;
            this.dataGridMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMahasiswa.Location = new System.Drawing.Point(11, 82);
            this.dataGridMahasiswa.Name = "dataGridMahasiswa";
            this.dataGridMahasiswa.ReadOnly = true;
            this.dataGridMahasiswa.Size = new System.Drawing.Size(470, 395);
            this.dataGridMahasiswa.TabIndex = 1;
            this.dataGridMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMahasiswa_CellClick);
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
            this.bindingNavigator1.Location = new System.Drawing.Point(11, 484);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator1.TabIndex = 8;
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
            // btnIjin
            // 
            this.btnIjin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIjin.Location = new System.Drawing.Point(506, 231);
            this.btnIjin.Name = "btnIjin";
            this.btnIjin.Size = new System.Drawing.Size(282, 38);
            this.btnIjin.TabIndex = 3;
            this.btnIjin.Text = "Permohonan Ijin Penelitian";
            this.btnIjin.UseVisualStyleBackColor = false;
            this.btnIjin.Click += new System.EventHandler(this.btnIjin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 62);
            this.groupBox1.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 89);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblKaprodi
            // 
            this.lblKaprodi.AutoSize = true;
            this.lblKaprodi.Location = new System.Drawing.Point(748, 42);
            this.lblKaprodi.Name = "lblKaprodi";
            this.lblKaprodi.Size = new System.Drawing.Size(35, 13);
            this.lblKaprodi.TabIndex = 6;
            this.lblKaprodi.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(237, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(546, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "PENGELOLAAN SURAT MAHASISWA";
            // 
            // bindingSource1
            // 
            this.bindingSource1.PositionChanged += new System.EventHandler(this.bindingSource1_PositionChanged);
            // 
            // uC_SuratKeterangan1
            // 
            this.uC_SuratKeterangan1.BackColor = System.Drawing.SystemColors.Control;
            this.uC_SuratKeterangan1.Location = new System.Drawing.Point(125, 7);
            this.uC_SuratKeterangan1.Name = "uC_SuratKeterangan1";
            this.uC_SuratKeterangan1.Size = new System.Drawing.Size(544, 604);
            this.uC_SuratKeterangan1.TabIndex = 9;
            // 
            // uC_IjinPenelitian1
            // 
            this.uC_IjinPenelitian1.Location = new System.Drawing.Point(123, 12);
            this.uC_IjinPenelitian1.Name = "uC_IjinPenelitian1";
            this.uC_IjinPenelitian1.Size = new System.Drawing.Size(557, 622);
            this.uC_IjinPenelitian1.TabIndex = 8;
            // 
            // uC_IjinPenelitianLain1
            // 
            this.uC_IjinPenelitianLain1.Location = new System.Drawing.Point(123, 18);
            this.uC_IjinPenelitianLain1.Name = "uC_IjinPenelitianLain1";
            this.uC_IjinPenelitianLain1.Size = new System.Drawing.Size(574, 613);
            this.uC_IjinPenelitianLain1.TabIndex = 10;
            // 
            // uC_SuratKeteranganLain1
            // 
            this.uC_SuratKeteranganLain1.Location = new System.Drawing.Point(136, 18);
            this.uC_SuratKeteranganLain1.Name = "uC_SuratKeteranganLain1";
            this.uC_SuratKeteranganLain1.Size = new System.Drawing.Size(544, 593);
            this.uC_SuratKeteranganLain1.TabIndex = 11;
            // 
            // FormPengelola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 633);
            this.Controls.Add(this.uC_SuratKeteranganLain1);
            this.Controls.Add(this.uC_IjinPenelitianLain1);
            this.Controls.Add(this.uC_SuratKeterangan1);
            this.Controls.Add(this.uC_IjinPenelitian1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKaprodi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPengelola";
            this.Text = "Pengelolaan Surat Mahasiswa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPengelola_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMahasiswa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSKL;
        private System.Windows.Forms.Button btnIjin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMahasiswa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNPM;
        private System.Windows.Forms.Label lblProdi;
        private System.Windows.Forms.Label lblKaprodi;
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSKLain;
        private System.Windows.Forms.Button btnIjinLain;
        private Boundary.UC_IjinPenelitian uC_IjinPenelitian1;
        private Boundary.UC_SuratKeterangan uC_SuratKeterangan1;
        private Boundary.UC_IjinPenelitianLain uC_IjinPenelitianLain1;
        private Boundary.UC_SuratKeteranganLain uC_SuratKeteranganLain1;
        private System.Windows.Forms.Label lblHal;
    }
}

