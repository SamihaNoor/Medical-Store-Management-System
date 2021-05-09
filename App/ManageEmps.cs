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
    public partial class ManageEmps : Form
    {
        Credential user;
        Employee emp;
        EmployeeService empService;
        CredentialService credSer;

        public ManageEmps(Credential user)
        {
            InitializeComponent();
            this.user = user;
            insertPanel.Visible = false;
            updatePanel.Visible = false;
            deletePanel.Visible = false;

        }

        private void insert_Click(object sender, EventArgs e)
        {
            empName_in_tb.Text = ""; designation_in_tb.Text = ""; contact_in_tb.Text = ""; salary_in_tb.Text = "";
            insertPanel.Visible = true;
            updatePanel.Visible = false;
            deletePanel.Visible = false;
        }


        private void delete_Click(object sender, EventArgs e)
        {
            empId_del_tb.Text = "";
            deletePanel.Visible = true;
            updatePanel.Visible = false;
            insertPanel.Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            empId_up_tb.Text = ""; empName_up_tb.Text = ""; designation_up_tb.Text = ""; contact_up_tb.Text = ""; salary_up_tb.Text = "";
            updatePanel.Visible = true;
            insertPanel.Visible = false;
            deletePanel.Visible = false;
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

        private void done_in_bt_Click(object sender, EventArgs e)
        {
            empService = new EmployeeService();
            try
            {
                if (empName_in_tb.Text == "" || designation_in_tb.Text == "" || contact_in_tb.Text == "" || salary_in_tb.Text == "")
                {
                    MessageBox.Show("Requirements incomplete!!");
                }
                else
                {
                    emp = new Employee();
                    emp.EmpName = empName_in_tb.Text;
                    emp.Designation = designation_in_tb.Text;
                    emp.Contact = Convert.ToInt32(contact_in_tb.Text);
                    emp.Salary = Convert.ToInt32(salary_in_tb.Text);
                    int result = empService.InsertEmp(emp);
                    if (result > 0)
                    {
                        Credential u = new Credential();
                        emp.EmpId = result;
                        u.UserId = emp.EmpId;
                        Random r = new Random();
                        string password = "p" + r.Next(9999999);
                        u.Password = password;
                        if (designation_in_tb.Text == "Manager")
                        {
                            u.Type = 1;
                        }
                        else { u.Type = 0; }

                        credSer = new CredentialService();
                        int i = credSer.InsertUser(u);
                        if (i > 0)
                        {
                            MessageBox.Show("User created. UserId(" + u.UserId + ")  password(" + password + ")");
                            empName_in_tb.Text = ""; designation_in_tb.Text = ""; contact_in_tb.Text = ""; salary_in_tb.Text = "";
                            UpdateGridView();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        private void done_up_bt_Click(object sender, EventArgs e)
        {
            empService = new EmployeeService();
            emp = new Employee();
            try
            {
                emp.EmpId = Convert.ToInt32(empId_up_tb.Text);
                emp.EmpName = empName_up_tb.Text;
                emp.Designation = designation_up_tb.Text;
                emp.Contact = Convert.ToInt32(contact_up_tb.Text);
                emp.Salary = Convert.ToInt32(salary_up_tb.Text);

                int result = empService.UpdateEmp(emp);
                if (result > 0)
                { MessageBox.Show("Employee Updated"); }
                empId_up_tb.Text = ""; empName_up_tb.Text = ""; designation_up_tb.Text = ""; contact_up_tb.Text = ""; salary_up_tb.Text = "";
                UpdateGridView();
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        private void done_del_bt_Click(object sender, EventArgs e)
        {
            try
            {
                credSer = new CredentialService();
                int i = credSer.DeleteUser(Convert.ToInt32(empId_del_tb.Text));
                if (i > 0)
                {
                    empService = new EmployeeService();
                    int result = empService.DeleteEmp(Convert.ToInt32(empId_del_tb.Text));
                    if (result > 0)
                    {
                        { MessageBox.Show("Employee Deleted"); empId_del_tb.Text = ""; }
                    }
                }
                UpdateGridView();
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }
        void UpdateGridView()
        {
            empService = new EmployeeService();
            empTable.DataSource = empService.GetEmps();
        }

        private void showAll_bt_Click(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void empTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            empId_up_tb.Text = empTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            empName_up_tb.Text = empTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            designation_up_tb.Text = empTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            contact_up_tb.Text = empTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            salary_up_tb.Text = empTable.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void ManageEmps_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
                    empService = new EmployeeService();
                    empTable.DataSource = empService.GetEmps(search_tb.Text);
                }
            }
        }
    }
}
