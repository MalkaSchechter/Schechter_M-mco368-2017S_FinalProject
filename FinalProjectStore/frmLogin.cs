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
    public partial class frmLogin : Form
    {
        public int customerID;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernm = txtUsrnm.Text;
            string pwd = txtPwd.Text;
            if (usernm == "" || pwd == "")
            {
                lblError.Text = "Invalid Username or Password.";
            }
            else
            {
                using (StoreDataDataContext context = new StoreDataDataContext())
                {
                    var u = context.Customers.Where(c => c.userid == usernm && c.pword == pwd);

                    if (u.Count() == 1)
                    {
                        var user = u.First();
                        // lblError.Text = "Successful!";
                        customerID = user.CustID;
                        this.Close();
                    }
                    else
                    {
                        lblError.Text = "User not found.\nWrong username/password combination.";
                    }

                }
            }
        }
    }
}
