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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnfrmEmployees_Click(object sender, EventArgs e)
        {
            ctrlHome1.Visible = false;
            ctrlAttendances1.Visible = false;
            ctrlIssueSalary1.Visible = false;

            ctrlEmployees1.Visible = true;
        }

        private void btnfrmAttendance_Click(object sender, EventArgs e)
        {
            ctrlEmployees1.Visible = false;
            ctrlHome1.Visible = false;
            ctrlIssueSalary1.Visible = false;

            ctrlAttendances1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ctrlHome1.Visible = true;

            ctrlEmployees1.Visible = false;
            ctrlAttendances1.Visible=false;
            ctrlIssueSalary1.Visible=false;
        }

        private void btnfrmHome_Click(object sender, EventArgs e)
        {
            
            ctrlAttendances1.Visible = false;
            ctrlIssueSalary1.Visible = false;
            ctrlEmployees1.Visible = false;

            ctrlHome1.Visible = true;
        }

        private void btnfrmSalary_Click(object sender, EventArgs e)
        {
            ctrlHome1.Visible = false;
            ctrlEmployees1.Visible = false;
            ctrlAttendances1.Visible = false;

            ctrlIssueSalary1.Visible = true;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(1183, 594);
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(x, y);
        }
    }
}
