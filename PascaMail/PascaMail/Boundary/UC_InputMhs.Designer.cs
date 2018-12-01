namespace PascaMail.Boundary
{
    partial class UC_InputMhs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_InputMhs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKaprodi = new System.Windows.Forms.ComboBox();
            this.dateTglLahir = new System.Windows.Forms.DateTimePicker();
            this.dateAwalStudi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAgama = new System.Windows.Forms.ComboBox();
            this.cmbAngkatan = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.radioBtnLaki = new System.Windows.Forms.RadioButton();
            this.radioBtnPerempuan = new System.Windows.Forms.RadioButton();
            this.txtNPM = new System.Windows.Forms.TextBox();
            this.cmbKewarganegaraan = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 100);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATA MAHASISWA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Program Studi";
            // 
            // cmbProdi
            // 
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.Location = new System.Drawing.Point(147, 412);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(211, 21);
            this.cmbProdi.TabIndex = 18;
            this.cmbProdi.SelectedIndexChanged += new System.EventHandler(this.cmbProdi_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(568, 106);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(26, 20);
            this.txtID.TabIndex = 17;
            this.txtID.Visible = false;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBatal.Location = new System.Drawing.Point(289, 491);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(94, 47);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSimpan.ForeColor = System.Drawing.Color.Black;
            this.btnSimpan.Location = new System.Drawing.Point(153, 491);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(94, 47);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(145, 166);
            this.txtNama.Multiline = true;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(263, 38);
            this.txtNama.TabIndex = 14;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "NPM";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kaprodi";
            // 
            // cmbKaprodi
            // 
            this.cmbKaprodi.FormattingEnabled = true;
            this.cmbKaprodi.Location = new System.Drawing.Point(147, 452);
            this.cmbKaprodi.Name = "cmbKaprodi";
            this.cmbKaprodi.Size = new System.Drawing.Size(211, 21);
            this.cmbKaprodi.TabIndex = 23;
            // 
            // dateTglLahir
            // 
            this.dateTglLahir.CustomFormat = "dd MMMM yyyy";
            this.dateTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTglLahir.Location = new System.Drawing.Point(423, 222);
            this.dateTglLahir.Name = "dateTglLahir";
            this.dateTglLahir.Size = new System.Drawing.Size(143, 20);
            this.dateTglLahir.TabIndex = 24;
            // 
            // dateAwalStudi
            // 
            this.dateAwalStudi.CustomFormat = "dd MMMM yyyy";
            this.dateAwalStudi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAwalStudi.Location = new System.Drawing.Point(403, 332);
            this.dateAwalStudi.Name = "dateAwalStudi";
            this.dateAwalStudi.Size = new System.Drawing.Size(163, 20);
            this.dateAwalStudi.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tempat Lahir";
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Location = new System.Drawing.Point(145, 219);
            this.txtTempatLahir.Multiline = true;
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(162, 20);
            this.txtTempatLahir.TabIndex = 28;
            this.txtTempatLahir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempatLahir_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tanggal Lahir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Agama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Jenis Kelamin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Angkatan";
            // 
            // cmbAgama
            // 
            this.cmbAgama.FormattingEnabled = true;
            this.cmbAgama.Location = new System.Drawing.Point(145, 256);
            this.cmbAgama.Name = "cmbAgama";
            this.cmbAgama.Size = new System.Drawing.Size(162, 21);
            this.cmbAgama.TabIndex = 33;
            // 
            // cmbAngkatan
            // 
            this.cmbAngkatan.FormattingEnabled = true;
            this.cmbAngkatan.Location = new System.Drawing.Point(145, 331);
            this.cmbAngkatan.Name = "cmbAngkatan";
            this.cmbAngkatan.Size = new System.Drawing.Size(102, 21);
            this.cmbAngkatan.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Awal Masuk Studi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Kewarganegaraan";
            // 
            // radioBtnLaki
            // 
            this.radioBtnLaki.AutoSize = true;
            this.radioBtnLaki.Location = new System.Drawing.Point(145, 293);
            this.radioBtnLaki.Name = "radioBtnLaki";
            this.radioBtnLaki.Size = new System.Drawing.Size(68, 17);
            this.radioBtnLaki.TabIndex = 38;
            this.radioBtnLaki.TabStop = true;
            this.radioBtnLaki.Text = "Laki-Laki";
            this.radioBtnLaki.UseVisualStyleBackColor = true;
            // 
            // radioBtnPerempuan
            // 
            this.radioBtnPerempuan.AutoSize = true;
            this.radioBtnPerempuan.Location = new System.Drawing.Point(250, 293);
            this.radioBtnPerempuan.Name = "radioBtnPerempuan";
            this.radioBtnPerempuan.Size = new System.Drawing.Size(79, 17);
            this.radioBtnPerempuan.TabIndex = 39;
            this.radioBtnPerempuan.TabStop = true;
            this.radioBtnPerempuan.Text = "Perempuan";
            this.radioBtnPerempuan.UseVisualStyleBackColor = true;
            // 
            // txtNPM
            // 
            this.txtNPM.Location = new System.Drawing.Point(145, 127);
            this.txtNPM.Name = "txtNPM";
            this.txtNPM.Size = new System.Drawing.Size(156, 20);
            this.txtNPM.TabIndex = 43;
            this.txtNPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNPM_KeyPress);
            // 
            // cmbKewarganegaraan
            // 
            this.cmbKewarganegaraan.FormattingEnabled = true;
            this.cmbKewarganegaraan.Location = new System.Drawing.Point(145, 370);
            this.cmbKewarganegaraan.Name = "cmbKewarganegaraan";
            this.cmbKewarganegaraan.Size = new System.Drawing.Size(162, 21);
            this.cmbKewarganegaraan.TabIndex = 44;
            // 
            // UC_InputMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbKewarganegaraan);
            this.Controls.Add(this.txtNPM);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.radioBtnPerempuan);
            this.Controls.Add(this.radioBtnLaki);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbAngkatan);
            this.Controls.Add(this.cmbAgama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTempatLahir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateAwalStudi);
            this.Controls.Add(this.dateTglLahir);
            this.Controls.Add(this.cmbKaprodi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProdi);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_InputMhs";
            this.Size = new System.Drawing.Size(597, 558);
            this.Load += new System.EventHandler(this.UC_InputMhs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbKaprodi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateAwalStudi;
        private System.Windows.Forms.DateTimePicker dateTglLahir;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbAngkatan;
        private System.Windows.Forms.ComboBox cmbAgama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioBtnPerempuan;
        private System.Windows.Forms.RadioButton radioBtnLaki;
        private System.Windows.Forms.TextBox txtNPM;
        private System.Windows.Forms.ComboBox cmbKewarganegaraan;
    }
}
