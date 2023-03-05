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

        public Database() {}

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

        public void InsertCustomer(Customer customer)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO tblCustomer (CustomerName, CustomerNumber) VALUES (@name, @number)", con);
            cmd.Parameters.AddWithValue("@name", customer.Name);
            cmd.Parameters.AddWithValue("@number", customer.Number);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Success");
            con.Close();
        }

        public void InsertTransaction(Customer customer, List<int> pId, List<string> pName,
            List<int> pQty, List<double> pAmount, List<double> pTotal, double gross, double tax,
            double disc, double total, int tId)
        {
            string prodId = "";
            foreach(var id in pId)
            {
                prodId += id + ", ";
            }

            string prodName = "";
            foreach(var name in pName)
            {
                prodName += name + ", ";
            }

            string prodQty = "";
            foreach (var qty in pQty)
            {
                prodQty += qty + ", ";
            }

            string prodAmount = "";
            foreach (var qty in pAmount)
            {
                prodAmount += qty + ", ";
            }

            string prodTotal = "";
            foreach (var qty in pTotal)
            {
                prodTotal += qty + ", ";
            }

            con.Open();
            cmd = new SqlCommand("INSERT INTO tblTransaction (ProductId, ProductName, ProductQty, " +
                "ProductAmount, ProductSubTotal, CustomerId, CustomerName, CustomerNumber, GrossTotal, Tax, " +
                "Discount, Total) VALUES (@pId, @pName, @pQty, @pAmount, @pTotal, @cId, @cName, @cNum, @gross, @tax," +
                "@disc, @total)", con);
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

            cmd.ExecuteNonQuery();
            MessageBox.Show("Success");
            con.Close();
        }

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
