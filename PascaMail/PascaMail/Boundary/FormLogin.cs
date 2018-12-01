using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PascaMail.Control;

namespace PascaMail.Boundary
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        LoginControl LC = new LoginControl();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LC.cekLogin(txtUser.Text, txtPass.Text) == true)
            {
                int role = LC.GetRoleUser(txtUser.Text, txtPass.Text);
                if (role == 1)
                {
                    this.Hide();
                    FormUtama fr = new FormUtama();
                    fr.setToolStripUser("Pengguna : Admin - " + txtUser.Text);
                    fr.setVisibleMenuAdmin(true);
                    fr.setVisibleMenuStaff(true);
                    fr.setVisibleMenuStudentStaff(true);
                    fr.ShowDialog();
                    this.Close();
                }
                else if (role == 2)
                {
                    this.Hide();
                    FormUtama fr = new FormUtama();
                    fr.setToolStripUser("Pengguna : Staff - " + txtUser.Text);
                    fr.setVisibleMenuAdmin(false);
                    fr.setVisibleMenuStaff(true);
                    fr.setVisibleMenuStudentStaff(false);
                    fr.ShowDialog();
                    this.Close();
                }
                else if (role == 3)
                {
                    this.Hide();
                    FormUtama fr = new FormUtama();
                    fr.setToolStripUser("Pengguna : Student Staff - " + txtUser.Text);
                    fr.setVisibleMenuAdmin(false);
                    fr.setVisibleMenuStaff(false);
                    fr.setVisibleMenuStudentStaff(true);
                    fr.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pengguna tidak diketahui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
                e.Handled = true;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
                e.Handled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
        }

    }
}
