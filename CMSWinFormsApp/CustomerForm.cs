﻿using System;
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
            if (flag == false)
                return;
            else
            {
                sqlDataAdapter1.Update(customerDataSet11);
                MessageBox.Show("Database updated!");
            }
        }

        private void BtnEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            customerDataSet11.Clear();                                                                                                                                                                                                                                                                                                       
            sqlDataAdapter1.Fill(customerDataSet11);
            CurrentPoisition();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnNext.BindingContext[customerDataSet11, "tblCustomer"].Position += 1;
            CurrentPoisition();
        }
        private void CurrentPoisition()
        {
            int currentPosition, ctr;
            ctr = this.BindingContext[customerDataSet11, "tbCustomer"].Count;
            if(ctr == 0)
            {
                textBox5.Text = "No Records";


            }
            else
            {
                currentPosition=this.BindingContext[customerDataSet11, "tblCustomer"].Position + 1;
                textBox5.Text=currentPosition.ToString()+"of"+ctr.ToString();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnPrevious.BindingContext[customerDataSet11,"tblCustomer"].Position-= 1;
            CurrentPoisition();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            customerDataSet11.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
