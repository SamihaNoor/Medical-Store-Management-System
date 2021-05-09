using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Settings : Form
    {
        Credential user;
        CredentialService cred;

        public Settings(Credential user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            new Home(user).Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void currentPassword_tb_TextChanged(object sender, EventArgs e)
        {
            if (currentPassword_tb.Text.Equals("")) { currentPassword_tb.UseSystemPasswordChar = false; }
            else { currentPassword_tb.UseSystemPasswordChar = true; }
        }

        private void newPassword_tb_TextChanged(object sender, EventArgs e)
        {
            if (newPassword_tb.Text.Equals("")) { newPassword_tb.UseSystemPasswordChar = false; }
            else { newPassword_tb.UseSystemPasswordChar = true; }
        }

        private void curShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            currentPassword_tb.UseSystemPasswordChar = false;
        }

        private void curShowPass_MouseLeave(object sender, EventArgs e)
        {
            currentPassword_tb.UseSystemPasswordChar = true;
        }

        private void newShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            newPassword_tb.UseSystemPasswordChar = false;
        }

        private void newShowPass_MouseLeave(object sender, EventArgs e)
        {
            newPassword_tb.UseSystemPasswordChar = true;
        }

        private void confirm_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.Password == currentPassword_tb.Text)
                {
                    cred = new CredentialService();
                    user.Password = newPassword_tb.Text;
                    int r = cred.ChangePassword(user);
                    if (r > 0)
                    {
                        MessageBox.Show("Password Changed");
                        new Home(user).Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex) { }
        }    
    }
}
