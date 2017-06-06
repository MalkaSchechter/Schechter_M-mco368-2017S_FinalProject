namespace FinalProjectStore
{
    partial class frmAccount
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
            this.grpCurrInfo = new System.Windows.Forms.GroupBox();
            this.txtBal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.lblAvail = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.lblLimit = new System.Windows.Forms.Label();
            this.grpPayAcct = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblAmt = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.dpLow = new System.Windows.Forms.DateTimePicker();
            this.grdInvoices = new System.Windows.Forms.DataGridView();
            this.dpHi = new System.Windows.Forms.DateTimePicker();
            this.lblDtRange = new System.Windows.Forms.Label();
            this.txtPriceLow = new System.Windows.Forms.TextBox();
            this.txtPriceHi = new System.Windows.Forms.TextBox();
            this.lblPrcRange = new System.Windows.Forms.Label();
            this.grpCurrInfo.SuspendLayout();
            this.grpPayAcct.SuspendLayout();
            this.grpHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCurrInfo
            // 
            this.grpCurrInfo.Controls.Add(this.txtBal);
            this.grpCurrInfo.Controls.Add(this.label2);
            this.grpCurrInfo.Controls.Add(this.txtAvail);
            this.grpCurrInfo.Controls.Add(this.lblAvail);
            this.grpCurrInfo.Controls.Add(this.txtLimit);
            this.grpCurrInfo.Controls.Add(this.lblLimit);
            this.grpCurrInfo.Location = new System.Drawing.Point(12, 10);
            this.grpCurrInfo.Name = "grpCurrInfo";
            this.grpCurrInfo.Size = new System.Drawing.Size(299, 181);
            this.grpCurrInfo.TabIndex = 6;
            this.grpCurrInfo.TabStop = false;
            this.grpCurrInfo.Text = "Current Information";
            // 
            // txtBal
            // 
            this.txtBal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBal.Location = new System.Drawing.Point(136, 41);
            this.txtBal.Name = "txtBal";
            this.txtBal.ReadOnly = true;
            this.txtBal.Size = new System.Drawing.Size(100, 22);
            this.txtBal.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current Balance:";
            // 
            // txtAvail
            // 
            this.txtAvail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAvail.Location = new System.Drawing.Point(136, 119);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.ReadOnly = true;
            this.txtAvail.Size = new System.Drawing.Size(100, 22);
            this.txtAvail.TabIndex = 9;
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.Location = new System.Drawing.Point(16, 122);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(112, 17);
            this.lblAvail.TabIndex = 8;
            this.lblAvail.Text = "Available Funds:";
            // 
            // txtLimit
            // 
            this.txtLimit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLimit.Location = new System.Drawing.Point(136, 80);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.ReadOnly = true;
            this.txtLimit.Size = new System.Drawing.Size(100, 22);
            this.txtLimit.TabIndex = 7;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(16, 83);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(82, 17);
            this.lblLimit.TabIndex = 6;
            this.lblLimit.Text = "Credit Limit:";
            // 
            // grpPayAcct
            // 
            this.grpPayAcct.Controls.Add(this.btnPay);
            this.grpPayAcct.Controls.Add(this.lblAmt);
            this.grpPayAcct.Controls.Add(this.txtAmt);
            this.grpPayAcct.Location = new System.Drawing.Point(12, 208);
            this.grpPayAcct.Name = "grpPayAcct";
            this.grpPayAcct.Size = new System.Drawing.Size(299, 161);
            this.grpPayAcct.TabIndex = 7;
            this.grpPayAcct.TabStop = false;
            this.grpPayAcct.Text = "Pay Down Your Account";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(53, 85);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(153, 42);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay Down Account";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(45, 49);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(101, 17);
            this.lblAmt.TabIndex = 1;
            this.lblAmt.Text = "Dollar Amount:";
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(152, 47);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(100, 22);
            this.txtAmt.TabIndex = 0;
            // 
            // grpHistory
            // 
            this.grpHistory.Controls.Add(this.lblPrcRange);
            this.grpHistory.Controls.Add(this.txtPriceHi);
            this.grpHistory.Controls.Add(this.txtPriceLow);
            this.grpHistory.Controls.Add(this.lblDtRange);
            this.grpHistory.Controls.Add(this.dpHi);
            this.grpHistory.Controls.Add(this.dpLow);
            this.grpHistory.Controls.Add(this.grdInvoices);
            this.grpHistory.Location = new System.Drawing.Point(318, 10);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(680, 370);
            this.grpHistory.TabIndex = 8;
            this.grpHistory.TabStop = false;
            this.grpHistory.Text = "Purchase History";
            // 
            // dpLow
            // 
            this.dpLow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpLow.Location = new System.Drawing.Point(215, 48);
            this.dpLow.Name = "dpLow";
            this.dpLow.Size = new System.Drawing.Size(90, 22);
            this.dpLow.TabIndex = 10;
            this.dpLow.ValueChanged += new System.EventHandler(this.dpLow_ValueChanged);
            // 
            // grdInvoices
            // 
            this.grdInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInvoices.Location = new System.Drawing.Point(7, 80);
            this.grdInvoices.Name = "grdInvoices";
            this.grdInvoices.RowTemplate.Height = 24;
            this.grdInvoices.Size = new System.Drawing.Size(664, 279);
            this.grdInvoices.TabIndex = 9;
            // 
            // dpHi
            // 
            this.dpHi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpHi.Location = new System.Drawing.Point(318, 48);
            this.dpHi.Name = "dpHi";
            this.dpHi.Size = new System.Drawing.Size(90, 22);
            this.dpHi.TabIndex = 11;
            this.dpHi.ValueChanged += new System.EventHandler(this.dpHi_ValueChanged);
            // 
            // lblDtRange
            // 
            this.lblDtRange.AutoSize = true;
            this.lblDtRange.Location = new System.Drawing.Point(267, 23);
            this.lblDtRange.Name = "lblDtRange";
            this.lblDtRange.Size = new System.Drawing.Size(88, 17);
            this.lblDtRange.TabIndex = 12;
            this.lblDtRange.Text = "Date Range:";
            // 
            // txtPriceLow
            // 
            this.txtPriceLow.Location = new System.Drawing.Point(465, 48);
            this.txtPriceLow.Name = "txtPriceLow";
            this.txtPriceLow.Size = new System.Drawing.Size(100, 22);
            this.txtPriceLow.TabIndex = 13;
            this.txtPriceLow.TextChanged += new System.EventHandler(this.txtPriceLow_TextChanged);
            // 
            // txtPriceHi
            // 
            this.txtPriceHi.Location = new System.Drawing.Point(571, 48);
            this.txtPriceHi.Name = "txtPriceHi";
            this.txtPriceHi.Size = new System.Drawing.Size(100, 22);
            this.txtPriceHi.TabIndex = 14;
            this.txtPriceHi.TextChanged += new System.EventHandler(this.txtPriceHi_TextChanged);
            // 
            // lblPrcRange
            // 
            this.lblPrcRange.AutoSize = true;
            this.lblPrcRange.Location = new System.Drawing.Point(521, 23);
            this.lblPrcRange.Name = "lblPrcRange";
            this.lblPrcRange.Size = new System.Drawing.Size(90, 17);
            this.lblPrcRange.TabIndex = 15;
            this.lblPrcRange.Text = "Price Range:";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 383);
            this.Controls.Add(this.grpHistory);
            this.Controls.Add(this.grpPayAcct);
            this.Controls.Add(this.grpCurrInfo);
            this.Name = "frmAccount";
            this.Text = "My Account";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.grpCurrInfo.ResumeLayout(false);
            this.grpCurrInfo.PerformLayout();
            this.grpPayAcct.ResumeLayout(false);
            this.grpPayAcct.PerformLayout();
            this.grpHistory.ResumeLayout(false);
            this.grpHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCurrInfo;
        private System.Windows.Forms.TextBox txtBal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.GroupBox grpPayAcct;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.DataGridView grdInvoices;
        private System.Windows.Forms.DateTimePicker dpLow;
        private System.Windows.Forms.Label lblDtRange;
        private System.Windows.Forms.DateTimePicker dpHi;
        private System.Windows.Forms.Label lblPrcRange;
        private System.Windows.Forms.TextBox txtPriceHi;
        private System.Windows.Forms.TextBox txtPriceLow;
    }
}