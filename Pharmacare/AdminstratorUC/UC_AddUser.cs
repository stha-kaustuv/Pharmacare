using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacare.AdminstratorUC
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String pass = txtPassword.Text;

            try
            {
                query = "insert into users (userRole,name,dob,mobile,email,username,pass) values('"+role+"', '"+name+"', '"+dob+"', "+mobile+", '"+email+"', '"+username+"', '"+pass+"')";
                fn.setData(query, "Sign Up Successful.");
            }
            catch(Exception)
            {
                MessageBox.Show("Username Already Exist.","Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='"+txtUsername.Text+"'";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count==0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;

                if (!string.IsNullOrEmpty(txtUsername.Text))
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                }
            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }
    }
}
