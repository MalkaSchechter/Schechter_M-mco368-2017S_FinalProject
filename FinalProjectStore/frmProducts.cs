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
    public partial class frmProducts : Form
    {
        public int customerID;
        public frmProducts(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void grdProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //select prod id, but hide it.
            //grdProducts.CurrentRow.Cells["ProdID"]
            int prodID = Int32.Parse(grdProducts.CurrentRow.Cells["ProdID"].Value.ToString());
            using (StoreDataDataContext context = new StoreDataDataContext()) {
                var cstmr = context.Customers.Where(c => c.CustID == customerID).First();
                
                var prdct = context.Products.Where(o => o.ProdID == prodID).First();

                Customer cstmr2 = (Customer)cstmr;
                Product prdct2 = (Product)prdct;


                
                frmPurchase p = new frmPurchase(prdct2, cstmr2);
                this.Hide();
                p.ShowDialog();

                refreshData();                                
                this.Show();
            }
        }

        private void refreshData()
        {
            using (StoreDataDataContext context = new StoreDataDataContext())
            {
                var products = context.Products.Where(p => p.totAvail > 0).Select(p => new { p.ProdID, Description = p.Descr, p.PricePerUnit, InStock = p.totAvail });
                grdProducts.DataSource = products;
                
                foreach (DataGridViewColumn c in grdProducts.Columns)
                {
                    c.Width = 115;
                }
            }
        }
    }
}

