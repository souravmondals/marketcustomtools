using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionCalculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            

            if (!string.IsNullOrEmpty(tb_S.Text) && !string.IsNullOrEmpty(tb_K.Text) && !string.IsNullOrEmpty(tb_r.Text) && !string.IsNullOrEmpty(transactionDate.Text) && !string.IsNullOrEmpty(expirationdate.Text) && !string.IsNullOrEmpty(tb_v.Text))
            {
                DateTime transaction_Date = transactionDate.Value;
                DateTime expiration_date = expirationdate.Value;
                string tb_t = expiration_date.Subtract(transaction_Date).TotalDays.ToString();
                CallPutOptionPrice callPutOptionPrice = new CallPutOptionPrice(tb_S.Text, tb_K.Text, tb_r.Text, "0", tb_t, tb_v.Text);
                if (radioButton1.Checked)
                {
                    tb_Call.Text = callPutOptionPrice.callOptionPrice();
                }
                else
                {
                    tb_Call.Text = callPutOptionPrice.putOptionPrice();
                }
            }
            else
            {
                MessageBox.Show("Enter proper input!!!!");
            }
                       

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Left = this.Left;
            form2.Top = this.Top;
            form2.Size = this.Size;
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
