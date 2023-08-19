using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacare.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        string query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtMediId.Text!="" && txtMediName.Text!="" &&  txtMediNumber.Text!= "" && txtMediComposition.Text != "" && txtQuantity.Text != "" && txtPricePerUnit.Text != "")
            {
                String mid = txtMediId.Text;
                String mname = txtMediName.Text;
                String mnumber = txtMediNumber.Text;
                String mdate = txtManufacturingDate.Text;
                String mComposition = txtMediComposition.Text;
                String edate = txtExpiryDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPricePerUnit.Text);

                query = "insert into medic(mid,mname,mnumber,mDate,mComposition,eDate,quantity,perUnit) values('"+mid+ "','" + mname + "','" + mnumber + "','" + mdate + "','" + mComposition + "','" + edate + "','" + quantity + "','" + perunit + "')";
                fn.setData(query, "Medicine Added To Database.");
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();   
        }

        public void clearAll()
        {
            txtMediId.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
            txtMediComposition.Clear();
            txtManufacturingDate.ResetText();
            txtExpiryDate.ResetText();
        }
    }
}
