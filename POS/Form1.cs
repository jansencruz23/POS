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
                item.ItemClicked += ProductClicked; // subscribe to the ItemClicked event
        }

        // when item is clicked, it calls process methods
        public void ProductClicked(object sender, ItemEventArgs e)
        {
            process.AddToTable(dgv, sender);
            process.UpdateTextBox(txtGross, txtTax, txtDiscount, txtTotal);
        }

        // sets up the main form
        private void FormLoad(object sender, EventArgs e)
        {
            foreach(var item in Database.items)
                panelItems.Controls.Add(item);

            txtCId.Text = db.GetLatestId("tblCustomer", "CustomerId").ToString();
            txtTransId.Text = db.GetLatestId("tblTransaction", "TransactionId").ToString();
            cbPayMethod.SelectedIndex = 0;
        }

        // when remove button is clicked, it calls process remove methods
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = GetSelectedRowId();
            process.RemoveFromTable(dgv, id);
            process.SubtractRemoved(id, txtGross, txtTax, txtDiscount, txtTotal);
        }

        // returns the selected id 
        private int GetSelectedRowId()
        {
            try
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];
                int value = Convert.ToInt32(selectedRow.Cells[0].Value);
                return value;
            }
            catch { return 0; } 
        }

        // method for clearing the data grid view
        private void btnReset_Click(object sender, EventArgs e)
        {
            process.ResetTable(dgv);
            ResetTextBox();
        }

        // saves customer info, calling database
        private void btnSave_Click(object sender, EventArgs e)
        {
            db.InsertCustomer(SaveCustomer());
            btnPay.Enabled = true;
        }

        // resets textboxes
        private void ResetTextBox()
        {
            txtGross.Text = "";
            txtTax.Text = "";
            txtDiscount.Text = "";
            txtTotal.Text = "";
        }

        // button for transaction
        private void btnTransact_Click(object sender, EventArgs e)
        {
            try
            {
                process.Transact(SaveCustomer(), dgv, txtGross, txtTax, txtDiscount, txtTotal, Convert.ToInt32(txtTransId.Text), cbPayMethod, txtCost, txtChange, dtp);
            }
            catch {
                MessageBox.Show("Please fill the textboxes");
            }
        }

        // returns the current customer
        private Customer SaveCustomer()
        {
            Customer customer = new Customer();
            customer.Id = db.GetLatestId("tblCustomer", "CustomerId");
            customer.Name = txtCName.Text;
            customer.Number = txtCNum.Text;

            return customer;
        }

        // event for the number buttons
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

        // for subtracting the cost to change
        private void btnPay_Click(object sender, EventArgs e)
        {
            double.TryParse(txtTotal.Text, out double total);
            double.TryParse(txtCost.Text, out double cost);
            double change; 

            if(cost >= total)
            {
                change = cost - total;
                txtChange.Text = change.ToString();
                btnTransact.Enabled = true;
            }
            else
                MessageBox.Show("Insufficient amount");
        }
    }
}