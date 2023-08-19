using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacare
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 

        private void btnSignIN_Click_1(object sender, EventArgs e)
        {

            query = "select * from users";
            ds = fn.getData(query);
            if(ds.Tables[0].Rows.Count==0)
            {
                if(txtUsername.Text=="admin" && txtPassword.Text=="admin")
                {
                    Adminstrator admin = new Adminstrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username = '" + txtUsername.Text + "' and pass='" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count!=0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if(role =="Adminstrator")
                    {
                        Adminstrator admin =new Adminstrator(txtUsername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if(role =="Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }















            /*if (txtUsername.Text == "uname" && txtPassword.Text == "pass")
            {
                Adminstrator am = new Adminstrator();
                am.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
