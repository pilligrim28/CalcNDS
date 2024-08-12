using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalcNDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
           char ch = e.KeyChar;
            if (!Char.IsDigit(ch)&& ch !=8 && (ch !='.' || textBox1.Text.Contains(".")))
            {
                e.Handled = true;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e, textBox1);
        }

        private void button1_Click(object sender, EventArgs e, System.Windows.Forms.TextBox textBox1)
        {
            double InputWithNds;
            double InputPriceWithNDS;
            int ProcNDS;

            InputPriceWithNDS = Convert.ToDouble(textBox1.Text.ToString(), NumberFormatInfo.InvariantInfo);
            ProcNDS = Convert.ToInt32(maskedTextBox1.Text);
            InputWithNds = (InputPriceWithNDS - (InputPriceWithNDS * ProcNDS) / 100)% 2;
          
            label1.Text = Math.Round(InputWithNds, 2) .ToString();
            label2.Text = InputWithNds .ToString();

        }
    }
}
