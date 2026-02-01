using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }
        private void loadform(Form frm)
        {


            Mainpanel.Controls.Clear();   // Old form clear

            frm.TopLevel = false;         // IMPORTANT
                                          //  frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            Mainpanel.Controls.Add(frm);
            frm.Show();
        }


        private void studentform_Click(object sender, EventArgs e)
        {
            loadform(new frmStudentform());
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            loadform(new frmDashboard());
        }

        private void aCCDASHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new ACC_DASH());
        }
    }
}
