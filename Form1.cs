using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        Process process = new Process();
        Database db = new Database();

        public Form1()
        {
            InitializeComponent();
            db.ReadProductValues();
            foreach (var item in Database.items)
            {
                item.ItemClicked += ProductClicked;
            }
        }

        public void ProductClicked(object sender, ItemEventArgs e)
        {
            process.AddToTable(dgv, sender);
            process.UpdateTextBox(txtGross, txtTax, txtDiscount, txtTotal);
        }

        private void FormLoad(object sender, EventArgs e)
        {
            foreach(var item in Database.items)
            {
                panelItems.Controls.Add(item);
            }
            txtCId.Text = db.GetLatestId("tblCustomer", "CustomerId").ToString();
            txtTransId.Text = db.GetLatestId("tblTransaction", "TransactionId").ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = GetSelectedRowId();
            process.RemoveFromTable(dgv, id);
            process.SubtractRemoved(id, txtGross, txtTax, txtDiscount, txtTotal);
           
        }

        private int GetSelectedRowId()
        {
            DataGridViewRow selectedRow = dgv.SelectedRows[0];
            int value = Convert.ToInt32(selectedRow.Cells[0].Value);
            return value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            process.ResetTable(dgv);
            ResetTextBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.InsertCustomer(SaveCustomer());
        }

        private void ResetTextBox()
        {
            txtGross.Text = "";
            txtTax.Text = "";
            txtDiscount.Text = "";
            txtTotal.Text = "";
        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            process.Transact(SaveCustomer(), dgv, txtGross, txtTax, txtDiscount, txtTotal, Convert.ToInt32(txtTransId.Text));
        }

        private Customer SaveCustomer()
        {
            Customer customer = new Customer();
            customer.Id = db.GetLatestId("tblCustomer", "CustomerId");
            customer.Name = txtCName.Text;
            customer.Number = txtCNum.Text;

            return customer;
        }

        private void btnNumbers_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    txtCost.Text += btn.Text;
                    break;
                case ".":
                    if(!txtCost.Text.Contains("."))
                        txtCost.Text += ".";
                    break;
                case "C":
                    if(txtCost.Text.Length > 0)
                        txtCost.Text = txtCost.Text.Substring(0, txtCost.Text.Length -1);
                    break;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double.TryParse(txtTotal.Text, out double total);
            double.TryParse(txtCost.Text, out double cost);
            double change; 

            if(cost >= total)
            {
                change = cost - total;
                txtChange.Text = change.ToString();
            }
            else
            {
                MessageBox.Show("Insufficient amount");
            }
        }
    }
}
