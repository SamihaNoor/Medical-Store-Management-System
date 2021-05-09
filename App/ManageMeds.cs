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
    public partial class ManageMeds : Form
    {
        Credential user;
        MedicineService medServ;
        Medicine med;

        public ManageMeds(Credential user)
        {
            InitializeComponent();
            this.user = user;
            insertPanel.Visible = false;
            updatePanel.Visible = false;
            deletePanel.Visible = false;
        }

        private void ManageMeds_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            medName_in_tb.Text = ""; type_in_tb.Text = ""; buyingPrice_in_tb.Text = ""; sellingPrice_in_tb.Text = ""; quantity_in_tb.Text = "";
            insertPanel.Visible = true;
            updatePanel.Visible = false;
            deletePanel.Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            medId_del_tb.Text = "";
            deletePanel.Visible = true;
            updatePanel.Visible = false;
            insertPanel.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            medId_up_tb.Text = ""; medName_up_tb.Text = ""; type_up_tb.Text = ""; buyingPrice_up_tb.Text = ""; sellingPrice_up_tb.Text = ""; quantity_up_tb.Text = "";
            updatePanel.Visible = true;
            insertPanel.Visible = false;
            deletePanel.Visible = false;
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

        private void showAll_bt_Click(object sender, EventArgs e)
        {
            UpdateGridview();
        }

        private void done_in_bt_Click(object sender, EventArgs e)
        {
            medServ = new MedicineService();

            if (medName_in_tb.Text == "" || type_in_tb.Text == "" || buyingPrice_in_tb.Text == "" || sellingPrice_in_tb.Text == "" || quantity_in_tb.Text == "")
            {
                MessageBox.Show("Empty Textbox!!");
            }
            else
            {
                try
                {
                    med = new Medicine();
                    med.MedName = medName_in_tb.Text;
                    med.Type = type_in_tb.Text;
                    med.BuyingPrice = Convert.ToDouble(buyingPrice_in_tb.Text);
                    med.SellingPrice = Convert.ToDouble(sellingPrice_in_tb.Text);
                    med.Quantity = Convert.ToInt32(quantity_in_tb.Text);
                    int result = medServ.InsertMed(med);
                    if (result > 0)
                    {
                        MessageBox.Show("Medicine Added");
                        medName_in_tb.Text = ""; type_in_tb.Text = ""; buyingPrice_in_tb.Text = ""; sellingPrice_in_tb.Text = ""; quantity_in_tb.Text = "";
                    }
                    else { MessageBox.Show("Please Try Again"); }
                    UpdateGridview();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.StackTrace);
                    medName_in_tb.Text = ""; type_in_tb.Text = ""; buyingPrice_in_tb.Text = ""; sellingPrice_in_tb.Text = ""; quantity_in_tb.Text = "";
                }
            }

        }

        private void done_del_bt_Click(object sender, EventArgs e)
        {
            medServ = new MedicineService();
            try
            {
                int result = medServ.DeleteMed(Convert.ToInt32(medId_del_tb.Text));
                if (result > 0)
                {
                    MessageBox.Show("Medicine Deleted");
                    medId_del_tb.Text = "";
                    UpdateGridview();
                }
                else { MessageBox.Show("Please Try Again"); }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void done_up_bt_Click(object sender, EventArgs e)
        {
            medServ = new MedicineService();
            med = new Medicine();
            try
            {
                med.MedId = Convert.ToInt32(medId_up_tb.Text);
                med.MedName = medName_up_tb.Text;
                med.Type = type_up_tb.Text;
                med.BuyingPrice = Convert.ToDouble(buyingPrice_up_tb.Text);
                med.SellingPrice = Convert.ToDouble(sellingPrice_up_tb.Text);
                med.Quantity = Convert.ToInt32(quantity_up_tb.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }

            int result = medServ.UpdateMed(med);
            if (result > 0)
            { 
                MessageBox.Show("Medicine Updated");
                medId_up_tb.Text = ""; medName_up_tb.Text = ""; type_up_tb.Text = ""; buyingPrice_up_tb.Text = ""; sellingPrice_up_tb.Text = ""; quantity_up_tb.Text = "";
                UpdateGridview();
            }
        }

        void UpdateGridview()
        {
            medServ = new MedicineService();
            medTable.DataSource = medServ.GetMeds();
        }
        private void deletePanel_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void medTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            medId_up_tb.Text = medTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            medName_up_tb.Text = medTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            type_up_tb.Text = medTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            buyingPrice_up_tb.Text = medTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            sellingPrice_up_tb.Text = medTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            quantity_up_tb.Text = medTable.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void search_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (search_tb.Text == "")
                {
                    MessageBox.Show("Your search box is empty");
                }
                else
                {
                    medServ = new MedicineService();
                    medTable.DataSource = medServ.GetMeds(search_tb.Text);
                }
            }
        }

    }
}
