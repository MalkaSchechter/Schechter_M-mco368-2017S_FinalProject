namespace FinalProjectStore
{
    partial class frmPurchase
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblPPU = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtTotPrice = new System.Windows.Forms.TextBox();
            this.txtPPU = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(49, 56);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(61, 17);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Product:";
            // 
            // lblPPU
            // 
            this.lblPPU.AutoSize = true;
            this.lblPPU.Location = new System.Drawing.Point(49, 89);
            this.lblPPU.Name = "lblPPU";
            this.lblPPU.Size = new System.Drawing.Size(99, 17);
            this.lblPPU.TabIndex = 1;
            this.lblPPU.Text = "Price Per Unit:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(49, 177);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(80, 17);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(49, 116);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(65, 17);
            this.lblQty.TabIndex = 3;
            this.lblQty.Text = "Quantity:";
            // 
            // txtTotPrice
            // 
            this.txtTotPrice.Location = new System.Drawing.Point(196, 172);
            this.txtTotPrice.Name = "txtTotPrice";
            this.txtTotPrice.ReadOnly = true;
            this.txtTotPrice.Size = new System.Drawing.Size(100, 22);
            this.txtTotPrice.TabIndex = 5;
            // 
            // txtPPU
            // 
            this.txtPPU.Location = new System.Drawing.Point(196, 84);
            this.txtPPU.Name = "txtPPU";
            this.txtPPU.ReadOnly = true;
            this.txtPPU.Size = new System.Drawing.Size(100, 22);
            this.txtPPU.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(196, 51);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(100, 22);
            this.txtDesc.TabIndex = 7;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(342, 86);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(115, 54);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(196, 118);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(100, 22);
            this.numQty.TabIndex = 10;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 255);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPPU);
            this.Controls.Add(this.txtTotPrice);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPPU);
            this.Controls.Add(this.lblProduct);
            this.Name = "frmPurchase";
            this.Text = "frmPurchase";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPPU;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtTotPrice;
        private System.Windows.Forms.TextBox txtPPU;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.NumericUpDown numQty;
    }
}