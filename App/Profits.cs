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
    public partial class Profits : Form
    {
        Credential user;
        ProfitService profServ;

        public Profits(Credential user)
        {
            InitializeComponent();
            this.user = user;
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

        private void show_chart_Click(object sender, EventArgs e)
        {
            try
            {
                profServ = new ProfitService();
                List<Profit> profits = profServ.Show(fromDate.Text, toDate.Text);
                foreach (var item in profits)
                {
                    weekly_profit.Series["Income"].Points.AddXY(item.Date, item.Income);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        private void Profits_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
