namespace PascaMail.Boundary
{
    partial class UC_IjinPenelitianLain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_IjinPenelitianLain));
            this.cmbMakul = new System.Windows.Forms.ComboBox();
            this.dateSurat = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbStatusSurat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHalSurat = new System.Windows.Forms.Label();
            this.lblIdSurat = new System.Windows.Forms.Label();
            this.lblKaprodi = new System.Windows.Forms.Label();
            this.lblProdi = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.radioBtnEks = new System.Windows.Forms.RadioButton();
            this.radioBtnInt = new System.Windows.Forms.RadioButton();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNPM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMakul
            // 
            this.cmbMakul.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMakul.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMakul.FormattingEnabled = true;
            this.cmbMakul.Location = new System.Drawing.Point(169, 414);
            this.cmbMakul.Name = "cmbMakul";
            this.cmbMakul.Size = new System.Drawing.Size(164, 21);
            this.cmbMakul.TabIndex = 76;
            // 
            // dateSurat
            // 
            this.dateSurat.CustomFormat = "dd MMMM yyyy";
            this.dateSurat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSurat.Location = new System.Drawing.Point(169, 378);
            this.dateSurat.Name = "dateSurat";
            this.dateSurat.Size = new System.Drawing.Size(164, 20);
            this.dateSurat.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Tanggal Surat";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(399, 538);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(109, 52);
            this.btnKeluar.TabIndex = 73;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBatal.Location = new System.Drawing.Point(284, 538);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(109, 52);
            this.btnBatal.TabIndex = 72;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelesai.Location = new System.Drawing.Point(169, 538);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(109, 52);
            this.btnSelesai.TabIndex = 71;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPreview.Location = new System.Drawing.Point(54, 538);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(109, 52);
            this.btnPreview.TabIndex = 70;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbStatusSurat
            // 
            this.cmbStatusSurat.FormattingEnabled = true;
            this.cmbStatusSurat.Location = new System.Drawing.Point(169, 494);
            this.cmbStatusSurat.Name = "cmbStatusSurat";
            this.cmbStatusSurat.Size = new System.Drawing.Size(164, 21);
            this.cmbStatusSurat.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Status Surat";
            // 
            // lblHalSurat
            // 
            this.lblHalSurat.AutoSize = true;
            this.lblHalSurat.Location = new System.Drawing.Point(530, 166);
            this.lblHalSurat.Name = "lblHalSurat";
            this.lblHalSurat.Size = new System.Drawing.Size(35, 13);
            this.lblHalSurat.TabIndex = 67;
            this.lblHalSurat.Text = "label8";
            // 
            // lblIdSurat
            // 
            this.lblIdSurat.AutoSize = true;
            this.lblIdSurat.Location = new System.Drawing.Point(530, 134);
            this.lblIdSurat.Name = "lblIdSurat";
            this.lblIdSurat.Size = new System.Drawing.Size(35, 13);
            this.lblIdSurat.TabIndex = 66;
            this.lblIdSurat.Text = "label8";
            this.lblIdSurat.Visible = false;
            // 
            // lblKaprodi
            // 
            this.lblKaprodi.AutoSize = true;
            this.lblKaprodi.Location = new System.Drawing.Point(530, 104);
            this.lblKaprodi.Name = "lblKaprodi";
            this.lblKaprodi.Size = new System.Drawing.Size(35, 13);
            this.lblKaprodi.TabIndex = 65;
            this.lblKaprodi.Text = "label9";
            this.lblKaprodi.Visible = false;
            // 
            // lblProdi
            // 
            this.lblProdi.AutoSize = true;
            this.lblProdi.Location = new System.Drawing.Point(530, 80);
            this.lblProdi.Name = "lblProdi";
            this.lblProdi.Size = new System.Drawing.Size(35, 13);
            this.lblProdi.TabIndex = 64;
            this.lblProdi.Text = "label8";
            this.lblProdi.Visible = false;
            // 
            // cmbStaff
            // 
            this.cmbStaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStaff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(169, 453);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(164, 21);
            this.cmbStaff.TabIndex = 63;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(167, 211);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(341, 64);
            this.txtKeterangan.TabIndex = 62;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(169, 304);
            this.txtAlamat.Multiline = true;
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(341, 58);
            this.txtAlamat.TabIndex = 61;
            // 
            // radioBtnEks
            // 
            this.radioBtnEks.AutoSize = true;
            this.radioBtnEks.Location = new System.Drawing.Point(264, 281);
            this.radioBtnEks.Name = "radioBtnEks";
            this.radioBtnEks.Size = new System.Drawing.Size(69, 17);
            this.radioBtnEks.TabIndex = 60;
            this.radioBtnEks.TabStop = true;
            this.radioBtnEks.Text = "Eksternal";
            this.radioBtnEks.UseVisualStyleBackColor = true;
            // 
            // radioBtnInt
            // 
            this.radioBtnInt.AutoSize = true;
            this.radioBtnInt.Location = new System.Drawing.Point(169, 281);
            this.radioBtnInt.Name = "radioBtnInt";
            this.radioBtnInt.Size = new System.Drawing.Size(60, 17);
            this.radioBtnInt.TabIndex = 59;
            this.radioBtnInt.TabStop = true;
            this.radioBtnInt.Text = "Internal";
            this.radioBtnInt.UseVisualStyleBackColor = true;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(166, 139);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(35, 13);
            this.lblNama.TabIndex = 58;
            this.lblNama.Text = "label9";
            // 
            // lblNPM
            // 
            this.lblNPM.AutoSize = true;
            this.lblNPM.Location = new System.Drawing.Point(166, 104);
            this.lblNPM.Name = "lblNPM";
            this.lblNPM.Size = new System.Drawing.Size(35, 13);
            this.lblNPM.TabIndex = 57;
            this.lblNPM.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Nama Staff Input";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Alamat Tujuan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Jenis Surat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Keterangan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "NPM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERMOHONAN IJIN PENELITIAN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(393, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Mata Kuliah";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 93);
            this.panel1.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 79;
            this.label11.Text = "LAINNYA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "Perihal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(166, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Permohonan Ijin";
            // 
            // txtHal
            // 
            this.txtHal.Location = new System.Drawing.Point(255, 174);
            this.txtHal.Name = "txtHal";
            this.txtHal.Size = new System.Drawing.Size(156, 20);
            this.txtHal.TabIndex = 81;
            // 
            // UC_IjinPenelitianLain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbMakul);
            this.Controls.Add(this.dateSurat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cmbStatusSurat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHalSurat);
            this.Controls.Add(this.lblIdSurat);
            this.Controls.Add(this.lblKaprodi);
            this.Controls.Add(this.lblProdi);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.radioBtnEks);
            this.Controls.Add(this.radioBtnInt);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNPM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UC_IjinPenelitianLain";
            this.Size = new System.Drawing.Size(573, 600);
            this.Load += new System.EventHandler(this.UC_IjinPenelitianLain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMakul;
        private System.Windows.Forms.DateTimePicker dateSurat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbStatusSurat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHalSurat;
        private System.Windows.Forms.Label lblIdSurat;
        private System.Windows.Forms.Label lblKaprodi;
        private System.Windows.Forms.Label lblProdi;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.RadioButton radioBtnEks;
        private System.Windows.Forms.RadioButton radioBtnInt;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNPM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}
