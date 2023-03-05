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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtTransId = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnTransact = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.cbPayMethod = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelItems
            // 
            this.panelItems.AutoScroll = true;
            this.panelItems.Location = new System.Drawing.Point(809, 88);
            this.panelItems.Margin = new System.Windows.Forms.Padding(6);
            this.panelItems.Name = "panelItems";
            this.panelItems.Padding = new System.Windows.Forms.Padding(5);
            this.panelItems.Size = new System.Drawing.Size(491, 381);
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
            this.dgv.Location = new System.Drawing.Point(312, 88);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(488, 381);
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
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(210, 30);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 30);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(210, 84);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 30);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "CANCEL";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCId
            // 
            this.txtCId.Location = new System.Drawing.Point(199, 18);
            this.txtCId.Name = "txtCId";
            this.txtCId.ReadOnly = true;
            this.txtCId.Size = new System.Drawing.Size(167, 20);
            this.txtCId.TabIndex = 4;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(199, 44);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(167, 20);
            this.txtCName.TabIndex = 5;
            // 
            // txtCNum
            // 
            this.txtCNum.Location = new System.Drawing.Point(537, 18);
            this.txtCNum.Name = "txtCNum";
            this.txtCNum.Size = new System.Drawing.Size(167, 20);
            this.txtCNum.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(744, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ADD";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtTax);
            this.panel1.Controls.Add(this.txtGross);
            this.panel1.Location = new System.Drawing.Point(12, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 147);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gross Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(153, 105);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(156, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(153, 78);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(156, 20);
            this.txtDiscount.TabIndex = 2;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(153, 51);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(156, 20);
            this.txtTax.TabIndex = 1;
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(153, 24);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(156, 20);
            this.txtGross.TabIndex = 0;
            // 
            // txtTransId
            // 
            this.txtTransId.Location = new System.Drawing.Point(537, 44);
            this.txtTransId.Name = "txtTransId";
            this.txtTransId.ReadOnly = true;
            this.txtTransId.Size = new System.Drawing.Size(167, 20);
            this.txtTransId.TabIndex = 9;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(809, 17);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(221, 20);
            this.dtp.TabIndex = 10;
            this.dtp.Value = new System.DateTime(2023, 3, 5, 11, 8, 4, 0);
            // 
            // btnTransact
            // 
            this.btnTransact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransact.Enabled = false;
            this.btnTransact.FlatAppearance.BorderSize = 0;
            this.btnTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransact.Location = new System.Drawing.Point(37, 30);
            this.btnTransact.Name = "btnTransact";
            this.btnTransact.Size = new System.Drawing.Size(134, 30);
            this.btnTransact.TabIndex = 11;
            this.btnTransact.Text = "TRANSACT";
            this.btnTransact.UseVisualStyleBackColor = false;
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
            this.panel2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 381);
            this.panel2.TabIndex = 12;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Location = new System.Drawing.Point(210, 274);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(74, 62);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btnPeriod
            // 
            this.btnPeriod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPeriod.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriod.Location = new System.Drawing.Point(110, 274);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(77, 62);
            this.btnPeriod.TabIndex = 10;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = false;
            this.btnPeriod.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Location = new System.Drawing.Point(10, 274);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 62);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Location = new System.Drawing.Point(210, 196);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(74, 62);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Location = new System.Drawing.Point(110, 196);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(77, 62);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Location = new System.Drawing.Point(10, 196);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 62);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Location = new System.Drawing.Point(210, 116);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(74, 62);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Location = new System.Drawing.Point(110, 116);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(74, 62);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(10, 116);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 62);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(210, 35);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(74, 62);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(110, 35);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(74, 62);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(10, 35);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 62);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumbers_Clicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtChange);
            this.panel3.Controls.Add(this.txtCost);
            this.panel3.Controls.Add(this.cbPayMethod);
            this.panel3.Location = new System.Drawing.Point(426, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 147);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Payment Method";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(192, 102);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(146, 20);
            this.txtChange.TabIndex = 2;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(192, 63);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(146, 20);
            this.txtCost.TabIndex = 1;
            // 
            // cbPayMethod
            // 
            this.cbPayMethod.FormattingEnabled = true;
            this.cbPayMethod.Items.AddRange(new object[] {
            "CASH",
            "G-CASH"});
            this.cbPayMethod.Location = new System.Drawing.Point(192, 26);
            this.cbPayMethod.Name = "cbPayMethod";
            this.cbPayMethod.Size = new System.Drawing.Size(146, 22);
            this.cbPayMethod.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPay.Enabled = false;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Location = new System.Drawing.Point(37, 84);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(134, 30);
            this.btnPay.TabIndex = 14;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTransact);
            this.panel4.Controls.Add(this.btnPay);
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Controls.Add(this.btnReset);
            this.panel4.Location = new System.Drawing.Point(922, 484);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 147);
            this.panel4.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "Customer ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 14);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "Customer Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "Transaction ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(741, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 14);
            this.label12.TabIndex = 20;
            this.label12.Text = "Date/Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1322, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtTransId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCNum);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCId);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panelItems);
            this.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}

