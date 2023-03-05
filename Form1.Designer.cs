namespace POS
{
    partial class Form1
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
            this.panelItems = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCId = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCNum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtTransId = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnTransact = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbPayMethod = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItems
            // 
            this.panelItems.Location = new System.Drawing.Point(696, 139);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(200, 252);
            this.panelItems.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Item,
            this.Qty,
            this.Amount,
            this.SubTotal});
            this.dgv.Location = new System.Drawing.Point(266, 98);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(374, 282);
            this.dgv.TabIndex = 1;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(803, 433);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(803, 481);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "CANCEL";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCId
            // 
            this.txtCId.Enabled = false;
            this.txtCId.Location = new System.Drawing.Point(266, 30);
            this.txtCId.Name = "txtCId";
            this.txtCId.Size = new System.Drawing.Size(100, 20);
            this.txtCId.TabIndex = 4;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(266, 56);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 20);
            this.txtCName.TabIndex = 5;
            // 
            // txtCNum
            // 
            this.txtCNum.Location = new System.Drawing.Point(395, 30);
            this.txtCNum.Name = "txtCNum";
            this.txtCNum.Size = new System.Drawing.Size(100, 20);
            this.txtCNum.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(791, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtTax);
            this.panel1.Controls.Add(this.txtGross);
            this.panel1.Location = new System.Drawing.Point(24, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 125);
            this.panel1.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(74, 94);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(119, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(74, 67);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(119, 20);
            this.txtDiscount.TabIndex = 2;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(74, 40);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(119, 20);
            this.txtTax.TabIndex = 1;
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(74, 13);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(119, 20);
            this.txtGross.TabIndex = 0;
            // 
            // txtTransId
            // 
            this.txtTransId.Enabled = false;
            this.txtTransId.Location = new System.Drawing.Point(395, 56);
            this.txtTransId.Name = "txtTransId";
            this.txtTransId.Size = new System.Drawing.Size(100, 20);
            this.txtTransId.TabIndex = 9;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(535, 29);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 10;
            this.dtp.Value = new System.DateTime(2023, 3, 5, 11, 8, 4, 0);
            // 
            // btnTransact
            // 
            this.btnTransact.Location = new System.Drawing.Point(696, 435);
            this.btnTransact.Name = "btnTransact";
            this.btnTransact.Size = new System.Drawing.Size(75, 23);
            this.btnTransact.TabIndex = 11;
            this.btnTransact.Text = "TRANSACT";
            this.btnTransact.UseVisualStyleBackColor = true;
            this.btnTransact.Click += new System.EventHandler(this.btnTransact_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnC);
            this.panel2.Controls.Add(this.btnPeriod);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Location = new System.Drawing.Point(12, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 292);
            this.panel2.TabIndex = 12;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 10);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(59, 47);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(88, 10);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(59, 47);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(171, 10);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(59, 47);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 76);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(59, 47);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(88, 76);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(59, 47);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(171, 76);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(59, 47);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 141);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(59, 47);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(88, 141);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(59, 47);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(171, 141);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(59, 47);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 211);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(59, 47);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Location = new System.Drawing.Point(88, 211);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(59, 47);
            this.btnPeriod.TabIndex = 10;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(171, 211);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(59, 47);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtChange);
            this.panel3.Controls.Add(this.txtCost);
            this.panel3.Controls.Add(this.cbPayMethod);
            this.panel3.Location = new System.Drawing.Point(278, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 125);
            this.panel3.TabIndex = 13;
            // 
            // cbPayMethod
            // 
            this.cbPayMethod.FormattingEnabled = true;
            this.cbPayMethod.Items.AddRange(new object[] {
            "CASH",
            "G-CASH"});
            this.cbPayMethod.Location = new System.Drawing.Point(145, 13);
            this.cbPayMethod.Name = "cbPayMethod";
            this.cbPayMethod.Size = new System.Drawing.Size(146, 21);
            this.cbPayMethod.TabIndex = 0;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(145, 50);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(146, 20);
            this.txtCost.TabIndex = 1;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(145, 89);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(146, 20);
            this.txtChange.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(696, 481);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 14;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 550);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTransact);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtTransId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCNum);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCId);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panelItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelItems;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCId;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCNum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtTransId;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btnTransact;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.ComboBox cbPayMethod;
        private System.Windows.Forms.Button btnPay;
    }
}

