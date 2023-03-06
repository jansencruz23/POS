namespace POS.Report
{
    partial class Receipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionDS = new POS.Report.TransactionDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.transactionDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionTableAdapter = new POS.Report.TransactionDSTableAdapters.tblTransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblTransactionBindingSource
            // 
            this.tblTransactionBindingSource.DataMember = "tblTransaction";
            this.tblTransactionBindingSource.DataSource = this.transactionDS;
            // 
            // transactionDS
            // 
            this.transactionDS.DataSetName = "TransactionDS";
            this.transactionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.tblTransactionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.Report.Print.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(424, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // transactionDSBindingSource
            // 
            this.transactionDSBindingSource.DataSource = this.transactionDS;
            this.transactionDSBindingSource.Position = 0;
            // 
            // tblTransactionBindingSource1
            // 
            this.tblTransactionBindingSource1.DataMember = "tblTransaction";
            this.tblTransactionBindingSource1.DataSource = this.transactionDSBindingSource;
            // 
            // tblTransactionTableAdapter
            // 
            this.tblTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource transactionDSBindingSource;
        private TransactionDS transactionDS;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource1;
        private TransactionDSTableAdapters.tblTransactionTableAdapter tblTransactionTableAdapter;
    }
}