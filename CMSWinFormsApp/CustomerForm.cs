using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            errCustForm.SetError(textBox1, "");
            errCustForm.SetError(textBox2, "");
            errCustForm.SetError(textBox3, ""); 
            errCustForm.SetError(textBox4, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag=true;
         
            if(textBox1.Text=="")
            {
                errCustForm.SetError(textBox1, "Please Specify a valid car number.");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox1, "");
            }
            if (textBox2.Text == "")
            {
                errCustForm.SetError(textBox2, "Please Specify a valid Name.");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox2, "");
            }
            if (textBox3.Text == "")
            {
                errCustForm.SetError(textBox3, "Please Specify a valid address.");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox3, "");
            }
            if (textBox4.Text == "")
            {
                errCustForm.SetError(textBox4, "Please Specify a valid Make.");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox4, "");
            }
            if (false == false)
                return;
            else
            {
                
            }
        }

        private void BtnEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
