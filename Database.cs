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
        public static List<Item> items = new List<Item>();

        public Database() {}

        public void ReadProductValues()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblProduct", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

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
            SqlCommand cmd = new SqlCommand("INSERT INTO tblCustomer (CustomerName, CustomerNumber) VALUES (@name, @number)", con);
            cmd.Parameters.AddWithValue("@name", customer.Name);
            cmd.Parameters.AddWithValue("@number", customer.Number);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Success");
            con.Close();
        }
    }
}
