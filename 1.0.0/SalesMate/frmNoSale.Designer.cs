namespace SalesMate
{
    partial class frmNoSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxReason = new System.Windows.Forms.TextBox();
            this.btnNSProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reason(s)";
            // 
            // txtBoxReason
            // 
            this.txtBoxReason.BackColor = System.Drawing.Color.MistyRose;
            this.txtBoxReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxReason.Location = new System.Drawing.Point(73, 6);
            this.txtBoxReason.Name = "txtBoxReason";
            this.txtBoxReason.Size = new System.Drawing.Size(189, 20);
            this.txtBoxReason.TabIndex = 1;
            // 
            // btnNSProceed
            // 
            this.btnNSProceed.BackColor = System.Drawing.Color.Yellow;
            this.btnNSProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNSProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNSProceed.Location = new System.Drawing.Point(187, 29);
            this.btnNSProceed.Name = "btnNSProceed";
            this.btnNSProceed.Size = new System.Drawing.Size(75, 23);
            this.btnNSProceed.TabIndex = 2;
            this.btnNSProceed.Text = "&Proceed";
            this.btnNSProceed.UseVisualStyleBackColor = false;
            this.btnNSProceed.Click += new System.EventHandler(this.btnNSProceed_Click);
            // 
            // frmNoSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(269, 55);
            this.Controls.Add(this.btnNSProceed);
            this.Controls.Add(this.txtBoxReason);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNoSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No Sale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxReason;
        private System.Windows.Forms.Button btnNSProceed;
    }
}