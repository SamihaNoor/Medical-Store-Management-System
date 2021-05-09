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
    public partial class LoginForm : Form
    {
        CredentialService credService;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void password_tb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (login_tb.Text == "" || password_tb.Text == "")
                    {
                      MessageBox.Show("Please Give Your UserId and Password", "Warning!!");
                    }
                    else
                    {
                        credService = new CredentialService();
                        Credential user;
                        user = credService.GetUser(Convert.ToInt32(login_tb.Text), password_tb.Text);
                        if (user != null)
                        {
                           Home h = new Home(user);
                          h.Show();
                          this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("User Not Found. Please Try Agian", "Error");
                            login_tb.Text = "";
                            password_tb.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); } 
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (login_tb.Text == "" || password_tb.Text == "")
                {
                    MessageBox.Show("Please Give Your UserId and Password", "Warning!!");
                }
                else
                {
                    credService = new CredentialService();
                    Credential user;
                    user = credService.GetUser(Convert.ToInt32(login_tb.Text), password_tb.Text);
                    if (user != null)
                    {
                        Home h = new Home(user);
                        h.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User Not Found. Please Try Agian", "Error");
                        login_tb.Text = "";
                        password_tb.Text = "";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        private void showPassword_bt_MouseDown(object sender, MouseEventArgs e)
        {
            password_tb.UseSystemPasswordChar = false;
        }

        private void password_tb_TextChanged(object sender, EventArgs e)
        {
            if (password_tb.Text.Equals("")) { password_tb.UseSystemPasswordChar = false; }
            else { password_tb.UseSystemPasswordChar = true; }
        }

        private void showPassword_bt_MouseLeave(object sender, EventArgs e)
        {
            password_tb.UseSystemPasswordChar = true;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
