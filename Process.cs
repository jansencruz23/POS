﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

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

        public void RemoveFromTable(DataGridView dgv, int id)
        {
            foreach (DataGridViewRow row in dgv.Rows) {
                int dgvId = Convert.ToInt32(row.Cells[0].Value);
                if (dgvId == id)
                {
                    foreach(var item in itemList)
                    {
                        if (item.Id == id)
                            item.TotalPrice = item.ProductPrice;
                    }
                    idList.Remove(id);
                    itemList.RemoveAll(item => item.Id == id);
                    dgv.Rows.Remove(row);
                    ResetValues();
                }
            }
        }

        public void ResetTable(DataGridView dgv)
        {
            foreach (var item in itemList)
            {
                    item.TotalPrice = item.ProductPrice;
            }
            dgv.Rows.Clear();
            idList.Clear();
            itemList.Clear();
            ResetValues();
        }

        public void UpdateTextBox(TextBox gross, TextBox tax, TextBox disc, TextBox total)
        {

            ResetValues();
            foreach (Item item in itemList)
            {
                grossRes = (item.TotalPrice + (item.TotalPrice * TAX));
                discRes = (item.TotalPrice + (item.TotalPrice * TAX)) * DISCOUNT;

                _gross += grossRes;
                _tax += item.TotalPrice * TAX;
                _discount += grossRes * DISCOUNT;
                _total += grossRes - discRes;
            }

            gross.Text = _gross.ToString();
            tax.Text = _tax.ToString();
            disc.Text = _discount.ToString();
            total.Text = _total.ToString();


        }

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
               


            foreach (Item item in itemList)
            {
                grossRes = (item.TotalPrice + (item.TotalPrice * TAX));
                discRes = (item.TotalPrice + (item.TotalPrice * TAX)) * DISCOUNT;

                _gross += grossRes;
                _tax += item.TotalPrice * TAX;
                _discount += grossRes * DISCOUNT;
                _total += grossRes - discRes;
            }

            gross.Text = _gross.ToString();
            tax.Text = _tax.ToString();
            disc.Text = _discount.ToString();
            total.Text = _total.ToString();
        }

        public void ResetValues()
        {
            _gross = 0;
            _tax = 0;
            _discount = 0;
            _total = 0;


            grossRes = 0;
            discRes = 0;
        }

    }
}