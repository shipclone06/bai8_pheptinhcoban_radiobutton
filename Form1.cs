using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8_pheptinhcoban_radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(textBox1.Text);
            double so2 = double.Parse(textBox2.Text);
            if (RDcong.Checked)
            {
                textBox3.Text = (so1 + so2).ToString();
            }
            if (RDtru.Checked)
            {
                textBox3.Text = (so1 - so2).ToString();
            }
            if (RDnhan.Checked)
            {
                textBox3.Text = (so1 * so2).ToString();
            }
            if (RDchia.Checked)
            {
                if(so2==0)
                {
                    textBox3.Text = "lỗi chia 0";
                }
            else
                {
                    textBox3.Text = (so1 / so2).ToString();
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
