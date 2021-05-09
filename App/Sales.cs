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
    public partial class Sales : Form
    {
        Credential user;
        SaleService salServ;

        public Sales(Credential user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            new Home(user).Show();
            this.Hide();
        }

        private void show_Click(object sender, EventArgs e)
        {
           
            salServ = new SaleService();
            try
            {
                List<Sale> sales = salServ.GetChart(fromDate.Text, toDate.Text);
                foreach (var item in sales)
                    {
                        chart1.Series["Quantity"].Points.AddXY(item.MedName, item.Quantity);
                    }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
