using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_IT4B
{
    public partial class FormLogin : Form
    {
        SqlRepository sqlRepository;

        public FormLogin()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            sqlRepository.ConvertUsersFromPasswordToPasswordHash();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var user = sqlRepository.GetUser(txtUsername.Text.Trim());
            if(user != null)
            {
                if (user.VerifyPassword(txtPassword.Text))
                {
                    new FormMain(user).Show(this);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect.");
                }
            }
            else
            {
                MessageBox.Show("Username or password incorrect.");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }
    }
}
