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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrint = new System.Windows.Forms.Button();
            this.transactionDS = new POS.Report.TransactionDS();
            this.transactionDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblTransactionTableAdapter = new POS.Report.TransactionDSTableAdapters.tblTransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.tblTransactionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS.Report.Print.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 333);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(354, 30);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // transactionDS
            // 
            this.transactionDS.DataSetName = "TransactionDS";
            this.transactionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionDSBindingSource
            // 
            this.transactionDSBindingSource.DataSource = this.transactionDS;
            this.transactionDSBindingSource.Position = 0;
            // 
            // tblTransactionBindingSource
            // 
            this.tblTransactionBindingSource.DataMember = "tblTransaction";
            this.tblTransactionBindingSource.DataSource = this.transactionDS;
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransactionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource transactionDSBindingSource;
        private TransactionDS transactionDS;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource;
        private System.Windows.Forms.BindingSource tblTransactionBindingSource1;
        private TransactionDSTableAdapters.tblTransactionTableAdapter tblTransactionTableAdapter;
    }
}