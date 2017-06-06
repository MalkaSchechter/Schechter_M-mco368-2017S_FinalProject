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
    public partial class frmAccount : Form
    {
        public int customerID;
        public frmAccount(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            using (StoreDataDataContext context = new StoreDataDataContext())
            {
                grdInvoices.DataSource = context.Invoices.Where(i => i.CustID == customerID).Select(i => new { Date = i.orderDate, Invoice = i.InvoiceID, Product = i.Product.Descr, i.Qty, UnitPrice = i.Product.PricePerUnit, Total = i.TotalBal });

                Customer cstmr = context.Customers.Where(c => c.CustID == customerID).First();
                setFields(cstmr);
            }

        }

        private void setFields(Customer cstmr)
        {
            txtBal.Text = cstmr.Balance.ToString();
            txtLimit.Text = cstmr.CreditLimit.ToString();
            txtAvail.Text = (cstmr.CreditLimit - cstmr.Balance).ToString();
            txtAmt.Text = "";
            dpLow.Value = DateTime.Parse("01-01-1900");
            dpHi.Value = DateTime.Today;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtAmt.Text == "")
            {
                MessageBox.Show("Dollar Amount Must Be Entered.", "No Amount Specified", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                decimal amt = decimal.Parse(txtAmt.Text);
                using (StoreDataDataContext context = new StoreDataDataContext())
                {
                    Customer cstmr = context.Customers.Where(c => c.CustID == customerID).First();

                    cstmr.Balance -= amt;


                    context.SubmitChanges();

                    setFields(cstmr);
                }
            }
        }

        private void dpLow_ValueChanged(object sender, EventArgs e)
        {
            filterByDate();
        }

        private void filterByDate()
        {
            using (StoreDataDataContext context = new StoreDataDataContext())
            {

                grdInvoices.DataSource = context.Invoices.Where(i => i.CustID == customerID && i.orderDate >= dpLow.Value && i.orderDate <= dpHi.Value).Select(i => new { Date = i.orderDate, Invoice = i.InvoiceID, Product = i.Product.Descr, i.Qty, UnitPrice = i.Product.PricePerUnit, Total = i.TotalBal });

            }
        }

        private void dpHi_ValueChanged(object sender, EventArgs e)
        {
            filterByDate();
        }

        private void txtPriceLow_TextChanged(object sender, EventArgs e)
        {
            filterByPrice();
        }

        private void txtPriceHi_TextChanged(object sender, EventArgs e)
        {
            filterByPrice();
        }

        private void filterByPrice() {
            decimal hiVal, lowVal;

            if (txtPriceHi.Text == "")
            {
                hiVal = (decimal) int.MaxValue;
            }
            else
            {
                hiVal = Decimal.Parse(txtPriceHi.Text);
            }


            if (txtPriceLow.Text == "")
            {
                lowVal = 0;
            }
            else
            {
                lowVal = Decimal.Parse(txtPriceLow.Text);
            }

            using (StoreDataDataContext context = new StoreDataDataContext())
            {

                grdInvoices.DataSource = context.Invoices.Where(i => i.CustID == customerID && i.TotalBal >= lowVal && i.TotalBal <= hiVal).Select(i => new { Date = i.orderDate, Invoice = i.InvoiceID, Product = i.Product.Descr, i.Qty, UnitPrice = i.Product.PricePerUnit, Total = i.TotalBal });

            }
        }
    }
}
