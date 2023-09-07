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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Left = this.Left;
            form1.Top = this.Top;
            form1.Size = this.Size;
            form1.Closed += (s, args) => this.Close();
            form1.Show();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_S.Text) && !string.IsNullOrEmpty(tb_K.Text) && !string.IsNullOrEmpty(tb_r.Text) && !string.IsNullOrEmpty(transactionDate.Text) && !string.IsNullOrEmpty(expirationdate.Text) && !string.IsNullOrEmpty(tb_v.Text))
            {
                DateTime transaction_Date = transactionDate.Value;
                DateTime expiration_date = expirationdate.Value;
                string tb_t = expiration_date.Subtract(transaction_Date).TotalDays.ToString();
                CallPutOptionPrice callPutOptionPrice;
                if (radioButton1.Checked)
                {
                    if (!string.IsNullOrEmpty(s1.Text))
                    {
                        callPutOptionPrice = new CallPutOptionPrice(s1.Text, tb_K.Text, tb_r.Text, "0", tb_t, tb_v.Text);
                        sl.Text = callPutOptionPrice.callOptionPrice();
                    }
                    if (!string.IsNullOrEmpty(r1.Text))
                    {
                        callPutOptionPrice = new CallPutOptionPrice(r1.Text, tb_K.Text, tb_r.Text, "0", tb_t, tb_v.Text);
                        t1.Text = callPutOptionPrice.callOptionPrice();
                    }
                    if (!string.IsNullOrEmpty(r2.Text))
                    {
                        callPutOptionPrice = new CallPutOptionPrice(r2.Text, tb_K.Text, tb_r.Text, "0", tb_t, tb_v.Text);
                        t2.Text = callPutOptionPrice.callOptionPrice();
                    }
                    if (!string.IsNullOrEmpty(r3.Text))
                    {
                        callPutOptionPrice = new CallPutOptionPrice(r3.Text, tb_K.Text, tb_r.Text, "0", tb_t, tb_v.Text);
                        t3.Text = callPutOptionPrice.callOptionPrice();
                    }

                    if (!string.IsNullOrEmpty(sl.Text))
                    {
                        s1.Text = getcallValue(sl.Text, tb_K.Text, tb_r.Text, tb_t, tb_v.Text);
                    }

                    if (!string.IsNullOrEmpty(t1.Text))
                    {
                        r1.Text = getcallValue(t1.Text, tb_K.Text, tb_r.Text, tb_t, tb_v.Text);
                    }
                    if (!string.IsNullOrEmpty(t2.Text))
                    {
                        r2.Text = getcallValue(t2.Text, tb_K.Text, tb_r.Text, tb_t, tb_v.Text);
                    }
                    if (!string.IsNullOrEmpty(t3.Text))
                    {
                        r3.Text = getcallValue(t3.Text, tb_K.Text, tb_r.Text, tb_t, tb_v.Text);
                    }


                    callPutOptionPrice = new CallPutOptionPrice(s1.Text, SP2.Text, tb_r.Text, "0", tb_t, SP2iv.Text);
                    string SP2_SL = callPutOptionPrice.callOptionPrice();
                    callPutOptionPrice = new CallPutOptionPrice(r1.Text, SP2.Text, tb_r.Text, "0", tb_t, SP2iv.Text);
                    string SP2_T1 = callPutOptionPrice.callOptionPrice();
                    callPutOptionPrice = new CallPutOptionPrice(r2.Text, SP2.Text, tb_r.Text, "0", tb_t, SP2iv.Text);
                    string SP2_T2 = callPutOptionPrice.callOptionPrice();
                    callPutOptionPrice = new CallPutOptionPrice(r3.Text, SP2.Text, tb_r.Text, "0", tb_t, SP2iv.Text);
                    string SP2_T3 = callPutOptionPrice.callOptionPrice();
                    string buyprice = (Convert.ToDouble(SP2_SL) + 30).ToString();
                    string message = "BUY " + S_name.Text + " " + SP2.Text + "CE @ " + buyprice + " SL " + SP2_SL + " TGT " + SP2_T1 + "-" + SP2_T2 + "-" + SP2_T3;

                    calldetail.Text = message;


                }
                else
                {
                    if (s1.Text != null)
                    {
                        callPutOptionPrice = new CallPutOptionPrice(s1.Text, tb_K.Text, tb_r.Text, "0", tb_t, tb_v.Text);
                        sl.Text = callPutOptionPrice.putOptionPrice();
                    }
                    if (r1.Text != null)
                    {
                        callPutOptionPrice = new CallPutOptionPrice(r1.Text, tb_K.Text, tb_r.Text, "0", tb_t, tb_v.Text);
                        t1.Text = callPutOptionPrice.putOptionPrice();
                    }
                    if (r2.Text != null)
                    {
                        callPutOptionPrice = new CallPutOptionPrice(r2.Text, tb_K.Text, tb_r.Text, "0", tb_t, tb_v.Text);
                        t2.Text = callPutOptionPrice.putOptionPrice();
                    }
                    if (r3.Text != null)
                    {
                        callPutOptionPrice = new CallPutOptionPrice(r3.Text, tb_K.Text, tb_r.Text, "0", tb_t, tb_v.Text);
                        t3.Text = callPutOptionPrice.putOptionPrice();
                    }

                    if (sl.Text != null)
                    {
                        s1.Text = getputValue(sl.Text, tb_K.Text, tb_r.Text, tb_t, tb_v.Text);
                    }

                    if (t1.Text != null)
                    {
                        r1.Text = getputValue(t1.Text, tb_K.Text, tb_r.Text, tb_t, tb_v.Text);
                    }
                    if (t2.Text != null)
                    {
                        r2.Text = getputValue(t2.Text, tb_K.Text, tb_r.Text, tb_t, tb_v.Text);
                    }
                    if (t3.Text != null)
                    {
                        r3.Text = getputValue(t3.Text, tb_K.Text, tb_r.Text, tb_t, tb_v.Text);
                    }


                    callPutOptionPrice = new CallPutOptionPrice(s1.Text, SP2.Text, tb_r.Text, "0", tb_t, SP2iv.Text);
                    string SP2_SL = callPutOptionPrice.putOptionPrice();
                    callPutOptionPrice = new CallPutOptionPrice(r1.Text, SP2.Text, tb_r.Text, "0", tb_t, SP2iv.Text);
                    string SP2_T1 = callPutOptionPrice.putOptionPrice();
                    callPutOptionPrice = new CallPutOptionPrice(r2.Text, SP2.Text, tb_r.Text, "0", tb_t, SP2iv.Text);
                    string SP2_T2 = callPutOptionPrice.putOptionPrice();
                    callPutOptionPrice = new CallPutOptionPrice(r3.Text, SP2.Text, tb_r.Text, "0", tb_t, SP2iv.Text);
                    string SP2_T3 = callPutOptionPrice.putOptionPrice();
                    string buyprice = (Convert.ToDouble(SP2_SL) + 30).ToString();
                    string message = "BUY " + S_name.Text + " " + SP2.Text + "PE @ " + buyprice + " SL " + SP2_SL + " TGT " + SP2_T1 + "-" + SP2_T2 + "-" + SP2_T3;

                    calldetail.Text = message;

                }
            }
            else
            {
                MessageBox.Show("Enter proper input!!!!");
            }
        }

        public string getcallValue(string price, string tb_K, string tb_r, string tb_t, string tb_v)
        {
            CallPutOptionPrice callPutOptionPrice;
            double ExpectedPrice = Convert.ToDouble(price);
            double StrikePrice = Convert.ToDouble(tb_K);
            while (true)
            {
                callPutOptionPrice = new CallPutOptionPrice(StrikePrice.ToString(), tb_K, tb_r, "0", tb_t, tb_v);
                double returnprice = Convert.ToDouble(callPutOptionPrice.callOptionPrice());
                if (returnprice < ExpectedPrice)
                {
                    StrikePrice++;
                }
                else if (returnprice >= ExpectedPrice && returnprice < (ExpectedPrice + 1))
                {
                    break;
                }
                else
                {
                    StrikePrice--;
                }
            }

            return StrikePrice.ToString();

        }

        public string getputValue(string price, string tb_K, string tb_r, string tb_t, string tb_v)
        {
            CallPutOptionPrice callPutOptionPrice;
            double ExpectedPrice = Convert.ToDouble(price);
            double StrikePrice = Convert.ToDouble(tb_K);
            while (true)
            {
                callPutOptionPrice = new CallPutOptionPrice(StrikePrice.ToString(), tb_K, tb_r, "0", tb_t, tb_v);
                double returnprice = Convert.ToDouble(callPutOptionPrice.putOptionPrice());
                if (returnprice < ExpectedPrice)
                {
                    StrikePrice++;
                }
                else if (returnprice >= ExpectedPrice && returnprice < (ExpectedPrice + 1))
                {
                    break;
                }
                else
                {
                    StrikePrice--;
                }
            }

            return StrikePrice.ToString();

        }
    }
}
