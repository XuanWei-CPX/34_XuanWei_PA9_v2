using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34_XuanWei_PA9_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            if (rb_USD.Checked == false)
                if (rb_Yen.Checked == false)
                    //if (rb_Ringgit.Checked == false)
                    txt_Amount.Text = "Choose anyone of the currency.";


            if (rb_USD.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 0.74M;
                    txt_Converted.Text = "$" + converted_amount.ToString();
                    txt_Amount.Text = "";
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
                    txt_Amount.Text = "Invalid Input.";
                }
            }
            else if (rb_Yen.Checked)
            {
                try
                {
                    decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
                    decimal converted_amount = amount * 81.97M;
                    txt_Converted.Text = converted_amount.ToString() + " Yen";
                    txt_Amount.Text = "";
                }
                catch (FormatException)
                {
                    txt_Amount.Clear();
                    txt_Converted.Clear();
                    txt_Amount.Text = "Invalid Input.";
                }
            }
            //else if (rb_Ringgit.Checked)
            //{
            //    try
            //    {
            //        decimal amount = System.Convert.ToDecimal(txt_Amount.Text);
            //        decimal converted_amount = amount * 3.01M;
            //        txt_Converted.Text = "$" + converted_amount.ToString();
            //        label4.Text = "";
            //    }
            //    catch (FormatException)
            //    {
            //        txt_Amount.Clear();
            //        txt_Converted.Clear();
            //        label4.Text = "Invalid Input.";
            //    }
        }
    }
}
