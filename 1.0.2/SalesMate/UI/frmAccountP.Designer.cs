namespace SalesMate
{
    partial class frmAccountP
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
            this.lviewAccount = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPurgeAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.cBoxUpdateIsAdmin = new System.Windows.Forms.ComboBox();
            this.btnCloseUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdatePass = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateLName = new System.Windows.Forms.TextBox();
            this.txtUpdateMName = new System.Windows.Forms.TextBox();
            this.txtUpdateFName = new System.Windows.Forms.TextBox();
            this.txtUpdateCashierUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdateCashierID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpCreateAccount = new System.Windows.Forms.GroupBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.txtBoxMName = new System.Windows.Forms.TextBox();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cBoxIsAdmin = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.grpCreateAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lviewAccount
            // 
            this.lviewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lviewAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lviewAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lviewAccount.FullRowSelect = true;
            this.lviewAccount.GridLines = true;
            this.lviewAccount.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lviewAccount.Location = new System.Drawing.Point(8, 16);
            this.lviewAccount.Name = "lviewAccount";
            this.lviewAccount.Size = new System.Drawing.Size(707, 140);
            this.lviewAccount.TabIndex = 1;
            this.lviewAccount.UseCompatibleStateImageBehavior = false;
            this.lviewAccount.View = System.Windows.Forms.View.Details;
            this.lviewAccount.SelectedIndexChanged += new System.EventHandler(this.lviewAccount_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cashier ID";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cashier User";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IsAdmin";
            this.columnHeader3.Width = 51;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Firstname";
            this.columnHeader5.Width = 121;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Middlename";
            this.columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Lastname";
            this.columnHeader7.Width = 142;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date Joined";
            this.columnHeader8.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lviewAccount);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(6, 11);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(97, 23);
            this.btnCreateAccount.TabIndex = 3;
            this.btnCreateAccount.Text = "&Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnPurgeAccount);
            this.groupBox2.Controls.Add(this.btnUpdateAccount);
            this.groupBox2.Controls.Add(this.btnCreateAccount);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 40);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(315, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPurgeAccount
            // 
            this.btnPurgeAccount.Location = new System.Drawing.Point(212, 11);
            this.btnPurgeAccount.Name = "btnPurgeAccount";
            this.btnPurgeAccount.Size = new System.Drawing.Size(97, 23);
            this.btnPurgeAccount.TabIndex = 5;
            this.btnPurgeAccount.Text = "&Purge Account";
            this.btnPurgeAccount.UseVisualStyleBackColor = true;
            this.btnPurgeAccount.Click += new System.EventHandler(this.btnPurgeAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(109, 11);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(97, 23);
            this.btnUpdateAccount.TabIndex = 4;
            this.btnUpdateAccount.Text = "&Update Account";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.cBoxUpdateIsAdmin);
            this.grpUpdate.Controls.Add(this.btnCloseUpdate);
            this.grpUpdate.Controls.Add(this.label7);
            this.grpUpdate.Controls.Add(this.txtUpdatePass);
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.txtUpdateLName);
            this.grpUpdate.Controls.Add(this.txtUpdateMName);
            this.grpUpdate.Controls.Add(this.txtUpdateFName);
            this.grpUpdate.Controls.Add(this.txtUpdateCashierUser);
            this.grpUpdate.Controls.Add(this.label6);
            this.grpUpdate.Controls.Add(this.label5);
            this.grpUpdate.Controls.Add(this.label4);
            this.grpUpdate.Controls.Add(this.label2);
            this.grpUpdate.Controls.Add(this.label1);
            this.grpUpdate.Controls.Add(this.txtUpdateCashierID);
            this.grpUpdate.Controls.Add(this.label3);
            this.grpUpdate.Location = new System.Drawing.Point(377, 170);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(359, 206);
            this.grpUpdate.TabIndex = 5;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update";
            // 
            // cBoxUpdateIsAdmin
            // 
            this.cBoxUpdateIsAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxUpdateIsAdmin.FormattingEnabled = true;
            this.cBoxUpdateIsAdmin.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cBoxUpdateIsAdmin.Location = new System.Drawing.Point(94, 60);
            this.cBoxUpdateIsAdmin.Name = "cBoxUpdateIsAdmin";
            this.cBoxUpdateIsAdmin.Size = new System.Drawing.Size(103, 21);
            this.cBoxUpdateIsAdmin.TabIndex = 32;
            // 
            // btnCloseUpdate
            // 
            this.btnCloseUpdate.Location = new System.Drawing.Point(130, 170);
            this.btnCloseUpdate.Name = "btnCloseUpdate";
            this.btnCloseUpdate.Size = new System.Drawing.Size(83, 27);
            this.btnCloseUpdate.TabIndex = 15;
            this.btnCloseUpdate.Text = "Cl&ose";
            this.btnCloseUpdate.UseVisualStyleBackColor = true;
            this.btnCloseUpdate.Click += new System.EventHandler(this.btnCloseUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            // 
            // txtUpdatePass
            // 
            this.txtUpdatePass.Location = new System.Drawing.Point(95, 145);
            this.txtUpdatePass.Name = "txtUpdatePass";
            this.txtUpdatePass.Size = new System.Drawing.Size(253, 20);
            this.txtUpdatePass.TabIndex = 13;
            this.txtUpdatePass.UseSystemPasswordChar = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(215, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 27);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Up&date";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateLName
            // 
            this.txtUpdateLName.Location = new System.Drawing.Point(95, 124);
            this.txtUpdateLName.Name = "txtUpdateLName";
            this.txtUpdateLName.Size = new System.Drawing.Size(253, 20);
            this.txtUpdateLName.TabIndex = 11;
            // 
            // txtUpdateMName
            // 
            this.txtUpdateMName.Location = new System.Drawing.Point(95, 103);
            this.txtUpdateMName.Name = "txtUpdateMName";
            this.txtUpdateMName.Size = new System.Drawing.Size(253, 20);
            this.txtUpdateMName.TabIndex = 10;
            // 
            // txtUpdateFName
            // 
            this.txtUpdateFName.Location = new System.Drawing.Point(95, 82);
            this.txtUpdateFName.Name = "txtUpdateFName";
            this.txtUpdateFName.Size = new System.Drawing.Size(253, 20);
            this.txtUpdateFName.TabIndex = 9;
            // 
            // txtUpdateCashierUser
            // 
            this.txtUpdateCashierUser.Location = new System.Drawing.Point(95, 39);
            this.txtUpdateCashierUser.Name = "txtUpdateCashierUser";
            this.txtUpdateCashierUser.Size = new System.Drawing.Size(253, 20);
            this.txtUpdateCashierUser.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Is Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier User";
            // 
            // txtUpdateCashierID
            // 
            this.txtUpdateCashierID.BackColor = System.Drawing.Color.White;
            this.txtUpdateCashierID.Enabled = false;
            this.txtUpdateCashierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateCashierID.Location = new System.Drawing.Point(95, 18);
            this.txtUpdateCashierID.Name = "txtUpdateCashierID";
            this.txtUpdateCashierID.Size = new System.Drawing.Size(59, 20);
            this.txtUpdateCashierID.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Cashier ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Middle Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cashier User";
            // 
            // grpCreateAccount
            // 
            this.grpCreateAccount.Controls.Add(this.txtBoxPassword);
            this.grpCreateAccount.Controls.Add(this.txtBoxUser);
            this.grpCreateAccount.Controls.Add(this.txtBoxLName);
            this.grpCreateAccount.Controls.Add(this.txtBoxMName);
            this.grpCreateAccount.Controls.Add(this.txtBoxFName);
            this.grpCreateAccount.Controls.Add(this.label13);
            this.grpCreateAccount.Controls.Add(this.label12);
            this.grpCreateAccount.Controls.Add(this.label11);
            this.grpCreateAccount.Controls.Add(this.label10);
            this.grpCreateAccount.Controls.Add(this.label9);
            this.grpCreateAccount.Controls.Add(this.label8);
            this.grpCreateAccount.Controls.Add(this.cBoxIsAdmin);
            this.grpCreateAccount.Controls.Add(this.btnClose);
            this.grpCreateAccount.Controls.Add(this.btnCreate);
            this.grpCreateAccount.Location = new System.Drawing.Point(377, 170);
            this.grpCreateAccount.Name = "grpCreateAccount";
            this.grpCreateAccount.Size = new System.Drawing.Size(359, 206);
            this.grpCreateAccount.TabIndex = 6;
            this.grpCreateAccount.TabStop = false;
            this.grpCreateAccount.Text = "Create Account";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(94, 106);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(252, 20);
            this.txtBoxPassword.TabIndex = 10;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(94, 85);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(252, 20);
            this.txtBoxUser.TabIndex = 9;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Location = new System.Drawing.Point(94, 64);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(252, 20);
            this.txtBoxLName.TabIndex = 8;
            // 
            // txtBoxMName
            // 
            this.txtBoxMName.Location = new System.Drawing.Point(94, 43);
            this.txtBoxMName.Name = "txtBoxMName";
            this.txtBoxMName.Size = new System.Drawing.Size(252, 20);
            this.txtBoxMName.TabIndex = 7;
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Location = new System.Drawing.Point(94, 22);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(252, 20);
            this.txtBoxFName.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "IsAdmin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Password";
            // 
            // cBoxIsAdmin
            // 
            this.cBoxIsAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxIsAdmin.FormattingEnabled = true;
            this.cBoxIsAdmin.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cBoxIsAdmin.Location = new System.Drawing.Point(94, 127);
            this.cBoxIsAdmin.Name = "cBoxIsAdmin";
            this.cBoxIsAdmin.Size = new System.Drawing.Size(91, 21);
            this.cBoxIsAdmin.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(127, 166);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 27);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(213, 166);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(133, 27);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmAccountP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(750, 383);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpCreateAccount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAccountP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Panel";
            this.Load += new System.EventHandler(this.frmAccountP_Load);
            this.Click += new System.EventHandler(this.frmAccountP_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpCreateAccount.ResumeLayout(false);
            this.grpCreateAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lviewAccount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPurgeAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateLName;
        private System.Windows.Forms.TextBox txtUpdateMName;
        private System.Windows.Forms.TextBox txtUpdateFName;
        private System.Windows.Forms.TextBox txtUpdateCashierUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdatePass;
        private System.Windows.Forms.Button btnCloseUpdate;
        private System.Windows.Forms.ComboBox cBoxUpdateIsAdmin;
        private System.Windows.Forms.TextBox txtUpdateCashierID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpCreateAccount;
        private System.Windows.Forms.ComboBox cBoxIsAdmin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.TextBox txtBoxMName;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;

    }
}