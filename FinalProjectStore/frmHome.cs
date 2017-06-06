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
    public partial class frmHome : Form
    {
        public int customerID;
        public frmHome()
        {
            InitializeComponent();
        }
        
        private void frmHome_Shown(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            l.ShowDialog();
            customerID = l.customerID;

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            l.ShowDialog();
            customerID = l.customerID;
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts p = new frmProducts(customerID);
            p.ShowDialog();
        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount a = new frmAccount(customerID);
            a.ShowDialog();
        }
    }
    }
