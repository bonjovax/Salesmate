namespace SalesMate
{
    partial class frmMain
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Unleaded",
            "500.00"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vATConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSalesMateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxPLU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxQty = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblChangeDue = new System.Windows.Forms.Label();
            this.lviewMain = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSubTotal = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnNoSale = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTwenty = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPriceLookUp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.logoutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.accountPanelToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.vATConfigToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "A&dmin";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.itemsToolStripMenuItem.Text = "&Items and Costing";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // accountPanelToolStripMenuItem
            // 
            this.accountPanelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accountPanelToolStripMenuItem.Name = "accountPanelToolStripMenuItem";
            this.accountPanelToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.accountPanelToolStripMenuItem.Text = "Accou&nt Panel";
            this.accountPanelToolStripMenuItem.Click += new System.EventHandler(this.accountPanelToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // vATConfigToolStripMenuItem
            // 
            this.vATConfigToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.vATConfigToolStripMenuItem.Name = "vATConfigToolStripMenuItem";
            this.vATConfigToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.vATConfigToolStripMenuItem.Text = "&VAT config";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raToolStripMenuItem,
            this.aboutSalesMateToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "&Help";
            // 
            // raToolStripMenuItem
            // 
            this.raToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.raToolStripMenuItem.Name = "raToolStripMenuItem";
            this.raToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.raToolStripMenuItem.Text = "&RA 9257";
            // 
            // aboutSalesMateToolStripMenuItem
            // 
            this.aboutSalesMateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aboutSalesMateToolStripMenuItem.Name = "aboutSalesMateToolStripMenuItem";
            this.aboutSalesMateToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutSalesMateToolStripMenuItem.Text = "A&bout SalesMate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxPLU);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(210, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter PLU #";
            // 
            // txtBoxPLU
            // 
            this.txtBoxPLU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBoxPLU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPLU.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPLU.Location = new System.Drawing.Point(10, 34);
            this.txtBoxPLU.Name = "txtBoxPLU";
            this.txtBoxPLU.Size = new System.Drawing.Size(551, 34);
            this.txtBoxPLU.TabIndex = 0;
            this.txtBoxPLU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxPLU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPLU_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qty:";
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.BackColor = System.Drawing.Color.MistyRose;
            this.txtBoxQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxQty.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQty.Location = new System.Drawing.Point(317, 148);
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.Size = new System.Drawing.Size(52, 22);
            this.txtBoxQty.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusDate
            // 
            this.statusDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDate.Name = "statusDate";
            this.statusDate.Size = new System.Drawing.Size(127, 17);
            this.statusDate.Text = "toolStripStatusLabel1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.lblTotalAmount);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(6, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 96);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Amount";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTotalAmount.Location = new System.Drawing.Point(26, 28);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(108, 55);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "0.00";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.lblChangeDue);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(6, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 96);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Change Due";
            // 
            // lblChangeDue
            // 
            this.lblChangeDue.AutoSize = true;
            this.lblChangeDue.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChangeDue.ForeColor = System.Drawing.Color.Firebrick;
            this.lblChangeDue.Location = new System.Drawing.Point(26, 28);
            this.lblChangeDue.Name = "lblChangeDue";
            this.lblChangeDue.Size = new System.Drawing.Size(108, 55);
            this.lblChangeDue.TabIndex = 12;
            this.lblChangeDue.Text = "0.00";
            // 
            // lviewMain
            // 
            this.lviewMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lviewMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lviewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lviewMain.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lviewMain.FullRowSelect = true;
            this.lviewMain.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lviewMain.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lviewMain.Location = new System.Drawing.Point(212, 176);
            this.lviewMain.Name = "lviewMain";
            this.lviewMain.Scrollable = false;
            this.lviewMain.Size = new System.Drawing.Size(559, 281);
            this.lviewMain.TabIndex = 12;
            this.lviewMain.UseCompatibleStateImageBehavior = false;
            this.lviewMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Qty";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 406;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 460;
            // 
            // btnSubTotal
            // 
            this.btnSubTotal.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSubTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubTotal.Location = new System.Drawing.Point(138, 435);
            this.btnSubTotal.Name = "btnSubTotal";
            this.btnSubTotal.Size = new System.Drawing.Size(63, 23);
            this.btnSubTotal.TabIndex = 13;
            this.btnSubTotal.Text = "S&ubtotal";
            this.btnSubTotal.UseVisualStyleBackColor = false;
            this.btnSubTotal.Click += new System.EventHandler(this.btnSubTotal_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCash.Enabled = false;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCash.Location = new System.Drawing.Point(5, 13);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(43, 23);
            this.btnCash.TabIndex = 14;
            this.btnCash.Text = "&Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheck.Location = new System.Drawing.Point(48, 13);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(55, 23);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "C&heck";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.Yellow;
            this.btnVoid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.Location = new System.Drawing.Point(138, 369);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(63, 23);
            this.btnVoid.TabIndex = 18;
            this.btnVoid.Text = "&Void";
            this.btnVoid.UseVisualStyleBackColor = false;
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.Plum;
            this.btnRefund.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefund.Enabled = false;
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.Location = new System.Drawing.Point(138, 413);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(63, 23);
            this.btnRefund.TabIndex = 19;
            this.btnRefund.Text = "&Refund";
            this.btnRefund.UseVisualStyleBackColor = false;
            // 
            // btnNoSale
            // 
            this.btnNoSale.BackColor = System.Drawing.Color.Yellow;
            this.btnNoSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNoSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoSale.Location = new System.Drawing.Point(138, 391);
            this.btnNoSale.Name = "btnNoSale";
            this.btnNoSale.Size = new System.Drawing.Size(63, 23);
            this.btnNoSale.TabIndex = 20;
            this.btnNoSale.Text = "&No Sale";
            this.btnNoSale.UseVisualStyleBackColor = false;
            this.btnNoSale.Click += new System.EventHandler(this.btnNoSale_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTwenty);
            this.groupBox4.Controls.Add(this.btnTen);
            this.groupBox4.Controls.Add(this.btnFive);
            this.groupBox4.Location = new System.Drawing.Point(6, 370);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(123, 42);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Discount";
            // 
            // btnTwenty
            // 
            this.btnTwenty.BackColor = System.Drawing.Color.LawnGreen;
            this.btnTwenty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwenty.Enabled = false;
            this.btnTwenty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTwenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwenty.Location = new System.Drawing.Point(79, 14);
            this.btnTwenty.Name = "btnTwenty";
            this.btnTwenty.Size = new System.Drawing.Size(39, 22);
            this.btnTwenty.TabIndex = 23;
            this.btnTwenty.Text = "20%";
            this.btnTwenty.UseVisualStyleBackColor = false;
            this.btnTwenty.Click += new System.EventHandler(this.btnTwenty_Click);
            // 
            // btnTen
            // 
            this.btnTen.BackColor = System.Drawing.Color.LawnGreen;
            this.btnTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTen.Enabled = false;
            this.btnTen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTen.Location = new System.Drawing.Point(40, 14);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(39, 22);
            this.btnTen.TabIndex = 22;
            this.btnTen.Text = "10%";
            this.btnTen.UseVisualStyleBackColor = false;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.LawnGreen;
            this.btnFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFive.Enabled = false;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(5, 14);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(35, 22);
            this.btnFive.TabIndex = 0;
            this.btnFive.Text = "5%";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCheck);
            this.groupBox5.Controls.Add(this.btnCash);
            this.groupBox5.Location = new System.Drawing.Point(6, 415);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(107, 42);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Payment Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Name:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(317, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 105);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnPriceLookUp
            // 
            this.btnPriceLookUp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPriceLookUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceLookUp.Location = new System.Drawing.Point(682, 147);
            this.btnPriceLookUp.Name = "btnPriceLookUp";
            this.btnPriceLookUp.Size = new System.Drawing.Size(89, 23);
            this.btnPriceLookUp.TabIndex = 26;
            this.btnPriceLookUp.Text = "&Price Look Up";
            this.btnPriceLookUp.UseVisualStyleBackColor = false;
            this.btnPriceLookUp.Click += new System.EventHandler(this.btnPriceLookUp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(788, 488);
            this.Controls.Add(this.btnPriceLookUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnNoSale);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.btnVoid);
            this.Controls.Add(this.btnSubTotal);
            this.Controls.Add(this.lviewMain);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtBoxQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AC/DC COMPONENT PART SALES & SERVICE CENTER | (SalesMate)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSalesMateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxPLU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxQty;
        private System.Windows.Forms.ToolStripMenuItem vATConfigToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblChangeDue;
        private System.Windows.Forms.ListView lviewMain;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnSubTotal;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnNoSale;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTwenty;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPriceLookUp;
    }
}