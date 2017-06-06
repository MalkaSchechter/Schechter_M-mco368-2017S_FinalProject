namespace FinalProjectStore
{
    partial class frmProducts
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
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.grdProducts);
            this.grpProducts.Location = new System.Drawing.Point(8, 12);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(537, 309);
            this.grpProducts.TabIndex = 1;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "Products For Sale.  Double Click The Product Description To Purchase";
            // 
            // grdProducts
            // 
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Location = new System.Drawing.Point(28, 36);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.RowTemplate.Height = 24;
            this.grdProducts.Size = new System.Drawing.Size(500, 256);
            this.grdProducts.TabIndex = 1;
            this.grdProducts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellContentDoubleClick);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 333);
            this.Controls.Add(this.grpProducts);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Form";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.grpProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.DataGridView grdProducts;
    }
}