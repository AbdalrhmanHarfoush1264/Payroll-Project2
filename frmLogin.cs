using clsPayrollBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Project2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text)||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Some Boxes are Empty!", "Not Vailed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsUser.CheckUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim()))
            {
                MessageBox.Show("Wrong UserName or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(630, 367);
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(x, y);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
