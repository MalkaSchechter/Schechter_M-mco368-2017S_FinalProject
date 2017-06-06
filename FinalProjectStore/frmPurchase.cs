using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectStore
{

    public partial class frmPurchase : Form
    {
        public Product p;
        public Customer c;

        public frmPurchase(Product p, Customer c)
        {
            InitializeComponent();
            this.p = p;
            this.c = c;
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            txtPPU.Text = p.PricePerUnit.ToString();
            txtTotPrice.Text = String.Format("{0}", p.PricePerUnit);
            txtDesc.Text = p.Descr;
            numQty.Maximum = p.totAvail;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            using (StoreDataDataContext context = new StoreDataDataContext())
            {
                
                if (c.CreditLimit >= c.Balance + Decimal.Parse(txtTotPrice.Text))
                {

                    //create Invoice (1 product per purchase)
                    Invoice i = new Invoice();
                    i.CustID = c.CustID;
                    i.ProdID = p.ProdID;
                    i.Qty = (int) numQty.Value;
                    i.orderDate = DateTime.Today;
                    i.TotalBal = Decimal.Parse(txtTotPrice.Text);

                    context.Invoices.InsertOnSubmit(i);

                    var cstmr = context.Customers.Where(c => c.CustID == this.c.CustID).First();

                    Customer customer = (Customer)cstmr;
                    //bill customer
                    customer.Balance += i.TotalBal;


                    var prdct = context.Products.Where(p => p.ProdID == this.p.ProdID).First();

                    Product product= (Product)prdct;

                    // reduce number in stock
                    product.totAvail -= (int)numQty.Value;

                    
                    context.SubmitChanges();
                    this.Hide();
                    MessageBox.Show("Order successfully Placed.", "Purchase Successful",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }else
                {
                    MessageBox.Show("Insufficient credit balance to allow for this purchase.", "Purchase Canceled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            //recalculate total price when qty changed
            Double total = (int) numQty.Value * Double.Parse(txtPPU.Text);
            txtTotPrice.Text = String.Format("{0}", total);

        }
    }
}
