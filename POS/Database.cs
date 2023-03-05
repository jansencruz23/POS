using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS
{
    public class Database
    {
        static string connectionString = "Data Source=DESKTOP-6G9JM0U\\SQLEXPRESS01; Initial Catalog=PosDb; Integrated Security=true;";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataReader rdr;
        public static List<Item> items = new List<Item>();

        // read values for product buttons
        public void ReadProductValues()
        {
            cmd = new SqlCommand("SELECT * FROM tblProduct", con);
            con.Open();
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Item item = new Item();
                item.Id = (int)rdr[0];
                item.ProductName = (string)rdr[1];
                item.ProductPrice = (double)rdr[2];
                items.Add(item);
            }
            con.Close();
        }

        // inserts customer info to the database
        public void InsertCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.Name) || string.IsNullOrWhiteSpace(customer.Number))
                MessageBox.Show("Please fill customer info");
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO tblCustomer (CustomerName, CustomerNumber) VALUES (@name, @number)", con);
                cmd.Parameters.AddWithValue("@name", customer.Name);
                cmd.Parameters.AddWithValue("@number", customer.Number);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added!");
                con.Close();
            }
        }

        // insert all the info to the database
        public void InsertTransaction(Customer customer, List<int> pId, List<string> pName, List<int> pQty, List<double> pAmount, List<double> pTotal, double gross, double tax, double disc, double total, int tId, string payment, double cost, double change, string dtp)
        {
            string prodId = string.Join(", ", pId);
            string prodName = string.Join(", ", pName);
            string prodQty = string.Join(", ", pQty);
            string prodAmount = string.Join(", ", pAmount);
            string prodTotal = string.Join(", ", pAmount);

            con.Open();
            cmd = new SqlCommand("INSERT INTO tblTransaction (ProductId, ProductName, ProductQty, " +
                "ProductAmount, ProductSubTotal, CustomerId, CustomerName, CustomerNumber, GrossTotal, Tax, " +
                "Discount, Total, PaymentMethod, Cost, Change, DateTime) VALUES (@pId, @pName, @pQty, @pAmount, @pTotal, @cId, @cName, @cNum, @gross, @tax," +
                "@disc, @total, @payment, @cost, @change, @dtp)", con);

            #region --SETTING PARAMS--
            cmd.Parameters.AddWithValue("@pId", prodId);
            cmd.Parameters.AddWithValue("@pName", prodName);
            cmd.Parameters.AddWithValue("@pQty", prodQty);
            cmd.Parameters.AddWithValue("@pAmount", prodAmount);
            cmd.Parameters.AddWithValue("@pTotal", prodTotal);
            cmd.Parameters.AddWithValue("@cId", customer.Id);
            cmd.Parameters.AddWithValue("@cName", customer.Name);
            cmd.Parameters.AddWithValue("@cNum", customer.Number);
            cmd.Parameters.AddWithValue("@gross", gross);
            cmd.Parameters.AddWithValue("@tax", tax);
            cmd.Parameters.AddWithValue("@disc", disc);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@payment", payment);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@change", change);
            cmd.Parameters.AddWithValue("@dtp", dtp);
            #endregion

            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaction Successful!");
            con.Close();
        }

        // gets latest id based on the parameter which decides which table to get
        public int GetLatestId(string table, string column)
        {
            int id;
            cmd = new SqlCommand($"SELECT TOP 1 {column} FROM {table} ORDER BY {column} DESC", con);
            con.Open();
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                id = rdr.GetInt32(0) + 1;
                con.Close();
                return id;
            }
            else
            {
                con.Close();
                return 1;
            }
        }
    }
}