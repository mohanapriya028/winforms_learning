using Student_Management_System;

namespace Student_Management_System
{
    public partial class StudentLoginForm : Form
    {
        public StudentLoginForm()

        {
            InitializeComponent();
            txtusename.Select();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtusename.Text == "ADMIN" || txtpass.Text == "123")
            {
                frmMainForm form = new frmMainForm();
                form.Show();
                this.Hide();


            }

            else
            {
                MessageBox.Show("Invalid UserName Or Password");
                txtusename.Focus();
            }
        }

        private void txtusename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.Focus();
            }
        }

        private void StudentLoginForm_KeyDown(object sender, KeyEventArgs e)
        {
       
        }
    }
}
