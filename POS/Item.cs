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
    public partial class Item : UserControl
    {
        public event ItemEventHandler ItemClicked;
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public double TotalPrice { get; set; }

        public Item()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        // this is a bit tricky, it only supports .jpg and .png file. 
        // since the items are based on database and can not be dynamically set,
        // this is the method i thought of
=======
>>>>>>> 9df1b6c (Add database method for the transaction. Add cost and the number buttons)
        private void OnItemLoad(object sender, EventArgs e)
        {
            TotalPrice = ProductPrice;
            try
            {
                pbIcon.Image = Image.FromFile(@"..\..\img\" + ProductName + ".jpg");
            }
            catch (Exception ex){
                pbIcon.Image = Image.FromFile(@"..\..\img\" + ProductName + ".png");
            }
        }

<<<<<<< HEAD
        // method when item is clicked, it invokes (calls) all the methods that are subscribe to it
=======
>>>>>>> 9df1b6c (Add database method for the transaction. Add cost and the number buttons)
        private void OnItemClick(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, new ItemEventArgs { Id = Id, ProductName = ProductName, ProductPrice = ProductPrice });
        }
    }
}
