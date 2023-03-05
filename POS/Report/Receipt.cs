using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Report
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionDS.tblTransaction' table. You can move, or remove it, as needed.
            this.tblTransactionTableAdapter.Fill(this.transactionDS.tblTransaction);

            this.reportViewer1.RefreshReport();
        }
    }
}
