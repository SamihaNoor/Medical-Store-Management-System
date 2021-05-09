using Entities;
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
    public partial class Home : Form
    {
        Credential user;

        public Home(Credential user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void manage_emps_Click(object sender, EventArgs e)
        {
            if (user.Type == 1)
            {
                ManageEmps m = new ManageEmps(user);
                m.Show();
                this.Hide();
            }
            else { MessageBox.Show("Access Denied"); }
        }
        private void manage_meds_Click_1(object sender, EventArgs e)
        {
            if (user.Type == 1)
            {
                ManageMeds m = new ManageMeds(user);
                m.Show();
                this.Hide();
            }
            else { MessageBox.Show("Access Denied"); }
        }

        private void sale_Click(object sender, EventArgs e)
        {
            if (user.Type == 1)
            {
                Sales s = new Sales(user);
                s.Show();
                this.Hide();
            }
            else { MessageBox.Show("Access Denied"); }
        }

        private void profits_Click(object sender, EventArgs e)
        {
            if (user.Type == 1)
            {
                Profits s = new Profits(user);
                s.Show();
                this.Hide();
            }
            else { MessageBox.Show("Access Denied"); }

        }

        private void cust_history_Click(object sender, EventArgs e)
        {
            CustomerHistory c = new CustomerHistory(user);
            c.Show();
            this.Hide();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings(user);
            s.Show();
            this.Hide();
        }

        private void sellingPoint_Click(object sender, EventArgs e)
        {
            SellingPoint s = new SellingPoint(user);
            s.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new LoginForm().Visible = true;
            this.Hide();
        }
    }
}
