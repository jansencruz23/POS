using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using ComboBox = System.Windows.Forms.ComboBox;

namespace POS
{
    public class Process
    {
        const double TAX = 0.15;
        const double DISCOUNT = 0.05;

        double _gross = 0;
        double _tax = 0;
        double _discount = 0;
        double _total = 0;

        double grossRes;
        double discRes;

        List<int> idList = new List<int>();
        List<Item> itemList = new List<Item>();

        Database db = new Database();

        public void AddToTable(DataGridView dgv, object sender)
        {
            Item item = (Item)sender;

            if (idList.Contains(item.Id))
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    // to update only the clicked product
                    if (item.Id == Convert.ToInt32(dgv.Rows[i].Cells[0].Value))
                    {
                        int qty = Convert.ToInt32(dgv.Rows[i].Cells[2].Value);
                        double price = item.ProductPrice;

                        // update quantity and sub total
                        dgv.Rows[i].Cells[2].Value = ++qty;
                        item.TotalPrice = price * qty;
                        dgv.Rows[i].Cells[4].Value = price * qty;
                    }
                }
            }
            else
            {
                idList.Add(item.Id);
                itemList.Add(item);
                dgv.Rows.Add(item.Id, item.ProductName, 1, item.ProductPrice, item.ProductPrice);
            }
        }

        // removing single item from table
        public void RemoveFromTable(DataGridView dgv, int id)
        {
            try
            {
                foreach (DataGridViewRow row in dgv.Rows) {
                    int dgvId = Convert.ToInt32(row.Cells[0].Value);
                    if (dgvId == id)
                    {
                        foreach (var item in itemList)
                            if (item.Id == id)
                                item.TotalPrice = item.ProductPrice;

                        idList.Remove(id);
                        itemList.RemoveAll(item => item.Id == id);
                        dgv.Rows.Remove(row);
                        ResetValues();
                    }
                }
            }
            catch (Exception ex) { }
        }

        // clearing all items in table
        public void ResetTable(DataGridView dgv)
        {
            foreach (var item in itemList)
                 item.TotalPrice = item.ProductPrice;

            dgv.Rows.Clear();
            idList.Clear();
            itemList.Clear();
            ResetValues();
        }

        // updating textbox values
        public void UpdateTextBox(TextBox gross, TextBox tax, TextBox disc, TextBox total)
        {
            ResetValues();
            Formulate();
            SetTextBox(gross, tax, disc, total);
        }

        // updating textbox whenever an item is removed
        public void SubtractRemoved(int id, TextBox gross, TextBox tax, TextBox disc, TextBox total)
        {
            ResetValues();
            if(itemList.Count <= 0)
            {
                gross.Text = "";
                idList.Remove(id);
                itemList.RemoveAll(item => item.Id == id);
                ResetValues();
            }

            Formulate();
            SetTextBox(gross, tax, disc, total);
        }

        // resets the values
        public void ResetValues()
        {
            _gross = 0;
            _tax = 0;
            _discount = 0;
            _total = 0;

            grossRes = 0;
            discRes = 0;
        }

        // set ups values to be passed on the database
        public void Transact(Customer customer, DataGridView dgv, TextBox gross, TextBox tax, TextBox disc, TextBox total, int tId, ComboBox payMethod, TextBox cost, TextBox change, DateTimePicker dtp)
        {
            #region --CREATING LISTS--
            List<int> productId = new List<int>();
            List<string> productName = new List<string>();
            List<int> productQty = new List<int>();
            List<double> productAmount = new List<double>();
            List<double> productSubTotal = new List<double>();
            #endregion
            #region --PARSING VALUES--
            double dGross = double.Parse(gross.Text);
            double dTax = double.Parse(tax.Text);
            double dDisc = double.Parse(disc.Text);
            double dTotal = double.Parse(total.Text);
            string payment = payMethod.Text;
            double dCost = double.Parse(cost.Text);
            double dChange = double.Parse(change.Text);
            string dateTime = dtp.Value.ToString("MM/dd/yyyy");
            #endregion

            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                     productId.Add((int)row.Cells[0].Value);
                     productName.Add(row.Cells[1].Value.ToString());
                     productQty.Add((int)row.Cells[2].Value);
                     productAmount.Add((double)row.Cells[3].Value);
                     productSubTotal.Add((double)row.Cells[4].Value);
                }
            }
            catch {}
            db.InsertTransaction(customer, productId, productName, productQty, productAmount, productSubTotal, dGross, dTax, dDisc, dTotal, tId, payment, dCost, dChange, dateTime);
        }

        // formulas for values in textboxes
        private void Formulate()
        {
            foreach (Item item in itemList)
            {
                grossRes = (item.TotalPrice + (item.TotalPrice * TAX));
                discRes = (item.TotalPrice + (item.TotalPrice * TAX)) * DISCOUNT;

                _gross += grossRes;
                _tax += item.TotalPrice * TAX;
                _discount += grossRes * DISCOUNT;
                _total += grossRes - discRes;
            }
        }

        // sets the latest value to the textboxes
        private void SetTextBox(TextBox gross, TextBox tax, TextBox disc, TextBox total)
        {
            gross.Text = _gross.ToString();
            tax.Text = _tax.ToString();
            disc.Text = _discount.ToString();
            total.Text = _total.ToString();
        }
    }
}