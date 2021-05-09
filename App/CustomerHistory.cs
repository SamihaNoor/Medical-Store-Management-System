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
    public partial class CustomerHistory : Form
    {
        HistoryService hisServ;
        Credential user;
        public CustomerHistory(Credential user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CustomerHistory_FormClosing(object sender, FormClosingEventArgs e)
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

        private void showAll_bt_Click(object sender, EventArgs e)
        {
            hisServ= new HistoryService();
            custHistory_table.DataSource = hisServ.GetAll();
        }

        private void search_tb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    hisServ = new HistoryService();
                    custHistory_table.DataSource = hisServ.GetAll(Convert.ToInt32(search_tb.Text));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }
    }
}
