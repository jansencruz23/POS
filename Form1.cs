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
            Customer customer = new Customer();
            customer.Name = txtCName.Text;
            customer.Number = txtCNum.Text;

            db.InsertCustomer(customer);
        }

        private void ResetTextBox()
        {
            txtGross.Text = "";
            txtTax.Text = "";
            txtDiscount.Text = "";
            txtTotal.Text = "";
        }
    }
}
