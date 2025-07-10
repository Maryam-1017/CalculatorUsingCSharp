using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienctificCalculator
{
    public partial class Form1 : Form
    {
        double enterfirstvalue, entersecondvalue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if(txtResult.Text=="0")
                txtResult.Text = "";
            {
                if(num.Text==".")
                {
                    if (!txtResult.Text.Contains(".")) 
                    {
                        txtResult.Text = txtResult.Text + num.Text;
                    }
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterfirstvalue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";

        }
    


           
        private void btnEquals_Click_1(object sender, EventArgs e)
        {
            entersecondvalue = Convert.ToDouble(txtResult.Text);


            switch (op)
            {
                case "+":
                    txtResult.Text = (enterfirstvalue + entersecondvalue).ToString();
                    break;

                case "-":
                    txtResult.Text = (enterfirstvalue - entersecondvalue).ToString();
                    break;

                case "*":
                    txtResult.Text = (enterfirstvalue * entersecondvalue).ToString();
                    break;

                case "/":
                    txtResult.Text = (enterfirstvalue / entersecondvalue).ToString();
                    break;

                default:
                    break;

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            string f, s;
            f = Convert.ToString(enterfirstvalue);
            s = Convert.ToString(entersecondvalue);
            f = " ";
            s = " ";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text=="")
            {
                txtResult.Text = "0";
            }

        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.14159765849";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg =Math.Log10(logg);
            txtResult.Text= Convert.ToString(logg);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(txtResult.Text);
            sqrt = Math.Sqrt(sqrt);
            txtResult.Text = Convert.ToString(sqrt);

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnsq_click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            double results = sq * sq;
            txtResult.Text = Convert.ToString(results);

        }

        private void btncube_Click(object sender, EventArgs e)
        {
            double cube = Convert.ToDouble(txtResult.Text);
            double results = cube*cube*cube;
            txtResult.Text = Convert.ToString(results);

        }

        private void btnSinh_click(object sender, EventArgs e)
        {
            double sinh = Convert.ToDouble(txtResult.Text);
            sinh= Math.Sinh(sinh);
            txtResult.Text = Convert.ToString(sinh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {

            double sin = Convert.ToDouble(txtResult.Text);
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);

        }

        private void btnCosh_Click(object sender, EventArgs e)
        {

            double cosh = Convert.ToDouble(txtResult.Text);
            cosh = Math.Cosh(cosh);
            txtResult.Text = Convert.ToString(cosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {

            double cos = Convert.ToDouble(txtResult.Text);
            cos = Math.Sinh(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txtResult.Text);
            tanh = Math.Tanh(tanh);
            txtResult.Text = Convert.ToString(tanh);

        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtResult.Text);
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {

        }

        private void btndiviX_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtResult.Text);
            double results = 1/x ;
            txtResult.Text = Convert.ToString(results);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
