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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace App
{
    public partial class SellingPoint : Form
    {
        Credential user;
        Purchase pur;
        MedicineService medServ;
        PurchaseService pursServ;
        ProfitService profServ;
        SaleService salServ;
        Sale sal;
        Profit prof;
        public SellingPoint(Credential user)
        {
            try
            {
                InitializeComponent();
                this.user = user;
                pursServ = new PurchaseService();
                saleId_tb.Text = (pursServ.GetSaleId()).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        private void SellingPoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //back
        private void back_Click(object sender, EventArgs e)
        {
            try
            {
                pursServ = new PurchaseService();
                int result = pursServ.DeleteFromCart(Convert.ToInt32(saleId_tb.Text));
                new Home(user).Show();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        //logout
        private void logout_Click(object sender, EventArgs e)
        {
            try
            {
                pursServ = new PurchaseService();
                int result = pursServ.DeleteFromCart(Convert.ToInt32(saleId_tb.Text));
                new LoginForm().Show();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        private void addToCart_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        //search medicine
        private void search_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                medServ = new MedicineService();
                medSearch_table.DataSource = medServ.GetMeds(search_tb.Text);
            }
        }

        //show All Medicines
        private void showAll_bt_Click(object sender, EventArgs e)
        {
            medServ = new MedicineService();
            medSearch_table.DataSource = medServ.GetMeds();
        }

        //calculate amount
        private void calculate_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (medId_tb.Text == "" || medName_tb.Text == "" || unitPrice_tb.Text == "" || quantity_tb.Text == "")
                {
                    MessageBox.Show("Textbox Empty");
                }
                else
                {
                    int qty = Convert.ToInt32(quantity_tb.Text);
                    double prc = Convert.ToDouble(unitPrice_tb.Text);
                    amount_tb.Text = (prc * qty).ToString();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        //Add to Cart
        private void addToCart_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (medId_tb.Text == "" || medName_tb.Text == "" || unitPrice_tb.Text == "" || quantity_tb.Text == "" || amount_tb.Text == "")
                {
                    MessageBox.Show("You need to add first");
                }
                else
                {
                    pursServ = new PurchaseService();
                    pur = pursServ.Check(Convert.ToInt32(medId_tb.Text), Convert.ToInt32(saleId_tb.Text));
                    if (pur != null)
                    {
                        pur.Quantity = pur.Quantity + Convert.ToInt32(quantity_tb.Text);
                        pur.Amount = pur.Amount + Convert.ToDouble(amount_tb.Text);

                        PurchaseService pursSer = new PurchaseService();
                        int rs = pursSer.UpdateCart(pur);
                    }
                    else
                    {
                        pur = new Purchase();
                        pur.SaleId = Convert.ToInt32(saleId_tb.Text);
                        pur.MedId = Convert.ToInt32(medId_tb.Text);
                        pur.MedName = medName_tb.Text;
                        pur.UnitPrice = Convert.ToDouble(unitPrice_tb.Text);
                        pur.Quantity = Convert.ToInt32(quantity_tb.Text);
                        pur.Amount = Convert.ToDouble(amount_tb.Text);
                        PurchaseService pursSer = new PurchaseService();
                        int result = pursSer.AddToCart(pur);
                    }
                    pursServ = new PurchaseService();
                    cartTable.DataSource = pursServ.GetAll(pur.SaleId);
                }
                medId_tb.Text = ""; medName_tb.Text = ""; unitPrice_tb.Text = ""; quantity_tb.Text = ""; amount_tb.Text = "";
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }  
        }
        //remove from cart
        private void remove_bt_Click(object sender, EventArgs e)
        {
            pursServ = new PurchaseService();
            int result = pursServ.DeleteMed(Convert.ToInt32(medId_tb.Text), Convert.ToInt32(saleId_tb.Text));
            if (result > 0)
            {
                pursServ = new PurchaseService();
                cartTable.DataSource = pursServ.GetAll(pur.SaleId);
            }
            medId_tb.Text = ""; medName_tb.Text = ""; unitPrice_tb.Text = ""; quantity_tb.Text = ""; amount_tb.Text = "";
        }

        private void medSearch_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            medId_tb.Text = medSearch_table.Rows[e.RowIndex].Cells[0].Value.ToString();
            medName_tb.Text = medSearch_table.Rows[e.RowIndex].Cells[1].Value.ToString();
            unitPrice_tb.Text = medSearch_table.Rows[e.RowIndex].Cells[4].Value.ToString();
            quantity_tb.Text = "";
            amount_tb.Text = "";
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                pursServ = new PurchaseService();
                total_tb.Text = (pursServ.GetTotal(Convert.ToInt32(saleId_tb.Text))).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        private void checkout_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (cust_contact_tb.Text == "" || cashPaid_tb.Text == "" || total_tb.Text == "" || change_tb.Text == "")
                {
                    MessageBox.Show("Textbox Empty!");
                }
                else
                {//////////pdf

                    Document doc = new Document(iTextSharp.text.PageSize.A4);
                    string fileName = "D:\\Dropbox\\Project\\Project 5.1\\Medical Store\\receipts\\" + saleId_tb.Text + ".pdf";
                    PdfWriter pd = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                    doc.Open();
                    Paragraph para;

                    para = new Paragraph("****Medical Store****");
                    para.Alignment = 1;
                    doc.Add(para);

                    para = new Paragraph("Date: " + date.Text);
                    para.Alignment = 0;
                    doc.Add(para);

                    para = new Paragraph("Time: " + DateTime.Now.TimeOfDay);
                    para.Alignment = 2;
                    doc.Add(para);

                    para = new Paragraph("SaleId: " + saleId_tb.Text);
                    para.Alignment = 2;
                    doc.Add(para);

                    para = new Paragraph("Customer Contact: " + cust_contact_tb.Text);
                    para.Alignment = 2;
                    doc.Add(para);
                    para = new Paragraph("Salesman: " + user.UserId + "\n\n");
                    para.Alignment = 2;
                    doc.Add(para);

                    PdfPTable table = new PdfPTable(4);

                    
                    PdfPCell cell = new PdfPCell(new Phrase("Medicine Name"));
                    cell.HorizontalAlignment = 1;

                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase("Quantity"));
                    cell.HorizontalAlignment = 1;

                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase("Unit Price"));
                    cell.HorizontalAlignment = 1;

                    table.AddCell(cell);

                    cell = new PdfPCell(new Phrase("Amount"));
                    cell.HorizontalAlignment = 1;

                    table.AddCell(cell);

                    pursServ = new PurchaseService();

                    List<Purchase> purc = pursServ.GetAll(pur.SaleId);

                    
                    foreach (var item in purc)
                    {
                        table.AddCell(item.MedName);
                        table.AddCell(item.Quantity.ToString());
                        table.AddCell(item.UnitPrice.ToString());
                        table.AddCell(item.Amount.ToString());
                    }
                    doc.Add(table);

                    para = new Paragraph("Total: " + total_tb.Text + "\nCash Paid: " + cashPaid_tb.Text + "\nChange: " + change_tb.Text + "\n");
                    para.Alignment = 2;
                    doc.Add(para);

                    doc.Close();

                    ///// Profit
                    pursServ = new PurchaseService();
                    List<Purchase> purs2 = pursServ.GetAll(pur.SaleId);
                    
                    foreach (var item in purs2)
                    {
                        Medicine med = new Medicine();
                        medServ = new MedicineService();
                        med = medServ.GetMed(item.MedId);
                        med.Quantity = med.Quantity - item.Quantity;
                        medServ = new MedicineService();
                        int res = medServ.UpdateMed(med);

                        prof = new Profit();

                        prof.SaleId = item.SaleId;
                        prof.MedId = item.MedId;
                        prof.Date = Convert.ToDateTime(date.Text);
                        prof.Income = item.Amount - (med.BuyingPrice * item.Quantity);

                        profServ = new ProfitService();

                        int rsl = profServ.Insert(prof);
                    }
                    //// History
                    HistoryService hisServ;
                    CustHistory custHis;
                    pursServ = new PurchaseService();
                    List<Purchase> purs = pursServ.GetAll(pur.SaleId);
                    List<CustHistory> histories = new List<CustHistory>();
                    foreach (var item in purs)
                    {
                        custHis = new CustHistory();
                        custHis.Date = Convert.ToDateTime(date.Text);
                        custHis.Contact = Convert.ToInt32(cust_contact_tb.Text);
                        custHis.SaleId = Convert.ToInt32(item.SaleId);
                        custHis.MedName = item.MedName;
                        custHis.Quantity = item.Quantity;

                        hisServ = new HistoryService();
                        int rst = hisServ.Insert(custHis);
                    }

                    //////Sale
                    pursServ = new PurchaseService();
                    List<Purchase> purs1 = pursServ.GetAll(pur.SaleId);
                    List<Sale> sales = new List<Sale>();
                    foreach (var item in purs1)
                    {
                        sal = new Sale();
                        sal.Date = Convert.ToDateTime(date.Text);
                        sal.SaleId = item.SaleId;
                        sal.MedName = item.MedName;
                        sal.Quantity = item.Quantity;

                        salServ = new SaleService();
                        int rlt = salServ.Insert(sal);
                    }
                    
                    new Home(user).Show();
                    this.Hide();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }  
        }

        private void cashPaid_tb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (cashPaid_tb.Text == "")
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        MessageBox.Show("Amount needed");
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        change_tb.Text = (Convert.ToDouble(cashPaid_tb.Text) - Convert.ToDouble(total_tb.Text)).ToString();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.StackTrace); }
        }

        private void cartTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            medId_tb.Text = cartTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            medName_tb.Text = cartTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            unitPrice_tb.Text = cartTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            quantity_tb.Text = "";
            amount_tb.Text = "";
        }
    }
}
