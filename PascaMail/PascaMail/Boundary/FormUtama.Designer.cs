namespace PascaMail.Boundary
{
    partial class FormUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputProgramStudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputKepalaProgramStudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengelolaanStudentStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengelolaanMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengelolaanStatusSuratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengelolaanStatusSuratToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoginToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.studentStaffToolStripMenuItem,
            this.staffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuLoginToolStripMenuItem
            // 
            this.menuLoginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuLoginToolStripMenuItem.Name = "menuLoginToolStripMenuItem";
            this.menuLoginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.menuLoginToolStripMenuItem.Text = "Login";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputMahasiswaToolStripMenuItem,
            this.inputProgramStudiToolStripMenuItem,
            this.inputKepalaProgramStudiToolStripMenuItem,
            this.pengelolaanStudentStaffToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // inputMahasiswaToolStripMenuItem
            // 
            this.inputMahasiswaToolStripMenuItem.Name = "inputMahasiswaToolStripMenuItem";
            this.inputMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.inputMahasiswaToolStripMenuItem.Text = "Pengelolaan Mahasiswa";
            this.inputMahasiswaToolStripMenuItem.Click += new System.EventHandler(this.inputMahasiswaToolStripMenuItem_Click);
            // 
            // inputProgramStudiToolStripMenuItem
            // 
            this.inputProgramStudiToolStripMenuItem.Name = "inputProgramStudiToolStripMenuItem";
            this.inputProgramStudiToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.inputProgramStudiToolStripMenuItem.Text = "Pengelolaan Program Studi";
            this.inputProgramStudiToolStripMenuItem.Click += new System.EventHandler(this.inputProgramStudiToolStripMenuItem_Click);
            // 
            // inputKepalaProgramStudiToolStripMenuItem
            // 
            this.inputKepalaProgramStudiToolStripMenuItem.Name = "inputKepalaProgramStudiToolStripMenuItem";
            this.inputKepalaProgramStudiToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.inputKepalaProgramStudiToolStripMenuItem.Text = "Pengelolaan Kepala Program Studi";
            this.inputKepalaProgramStudiToolStripMenuItem.Click += new System.EventHandler(this.inputKepalaProgramStudiToolStripMenuItem_Click);
            // 
            // pengelolaanStudentStaffToolStripMenuItem
            // 
            this.pengelolaanStudentStaffToolStripMenuItem.Name = "pengelolaanStudentStaffToolStripMenuItem";
            this.pengelolaanStudentStaffToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.pengelolaanStudentStaffToolStripMenuItem.Text = "Pengelolaan Student Staff";
            this.pengelolaanStudentStaffToolStripMenuItem.Click += new System.EventHandler(this.pengelolaanStudentStaffToolStripMenuItem_Click);
            // 
            // studentStaffToolStripMenuItem
            // 
            this.studentStaffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pengelolaanMahasiswaToolStripMenuItem,
            this.pengelolaanStatusSuratToolStripMenuItem});
            this.studentStaffToolStripMenuItem.Name = "studentStaffToolStripMenuItem";
            this.studentStaffToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.studentStaffToolStripMenuItem.Text = "Student Staff";
            // 
            // pengelolaanMahasiswaToolStripMenuItem
            // 
            this.pengelolaanMahasiswaToolStripMenuItem.Name = "pengelolaanMahasiswaToolStripMenuItem";
            this.pengelolaanMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pengelolaanMahasiswaToolStripMenuItem.Text = "Input Surat Mahasiswa";
            this.pengelolaanMahasiswaToolStripMenuItem.Click += new System.EventHandler(this.pengelolaanMahasiswaToolStripMenuItem_Click);
            // 
            // pengelolaanStatusSuratToolStripMenuItem
            // 
            this.pengelolaanStatusSuratToolStripMenuItem.Name = "pengelolaanStatusSuratToolStripMenuItem";
            this.pengelolaanStatusSuratToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pengelolaanStatusSuratToolStripMenuItem.Text = "Pengelolaan Status Surat";
            this.pengelolaanStatusSuratToolStripMenuItem.Click += new System.EventHandler(this.pengelolaanStatusSuratToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pengelolaanStatusSuratToolStripMenuItem1});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // pengelolaanStatusSuratToolStripMenuItem1
            // 
            this.pengelolaanStatusSuratToolStripMenuItem1.Name = "pengelolaanStatusSuratToolStripMenuItem1";
            this.pengelolaanStatusSuratToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.pengelolaanStatusSuratToolStripMenuItem1.Text = "Pengelolaan Status Surat";
            this.pengelolaanStatusSuratToolStripMenuItem1.Click += new System.EventHandler(this.pengelolaanStatusSuratToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(521, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripUser
            // 
            this.toolStripUser.Name = "toolStripUser";
            this.toolStripUser.Size = new System.Drawing.Size(118, 17);
            this.toolStripUser.Text = "toolStripStatusLabel1";
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 363);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUtama";
            this.Text = "Pasca Mail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputMahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputProgramStudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputKepalaProgramStudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengelolaanMahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengelolaanStatusSuratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengelolaanStatusSuratToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripUser;
        private System.Windows.Forms.ToolStripMenuItem pengelolaanStudentStaffToolStripMenuItem;
    }
}