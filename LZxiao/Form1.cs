using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LZxiao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "+";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp1 = this.textBox1.Text.ToString();
            String temp2 = this.textBox2.Text.ToString();
            for(int i=0;i<temp1.Length;i++)
            {
                byte tempnum1 = Convert.ToByte(temp1[i]);
                if(tempnum1<48||tempnum1>57)
                {
                    this.textBox3.Text = "error,nonstandard";
                    return;
                }
            }
            for (int i = 0; i < temp2.Length; i++)
            {
                byte tempnum2 = Convert.ToByte(temp2[i]);
                if (tempnum2 < 48 || tempnum2 > 57)
                {
                    this.textBox3.Text = "error,nonstandard";
                    return;
                }
            }
            Double num1 = Convert.ToDouble(this.textBox1.Text.ToString());
            Double num2 = Convert.ToDouble(this.textBox2.Text.ToString());   
            string ch = this.comboBox1.Text;
            string Result = "";
            switch (ch)
            {
                case "+":
                    Result = (num1 + num2).ToString();
                    this.textBox3.Text = Result;
                    break;
                case "-":
                    Result = (num1 - num2).ToString();
                    this.textBox3.Text = Result;
                    break;
                case "*":
                    Result = (num1 * num2).ToString();
                    this.textBox3.Text = Result;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        this.textBox3.Text = "error,nonstandard";
                        return;
                    }
                    Result = (num1 / num2).ToString();
                    this.textBox3.Text = Result;
                    break;
                default:
                    break;
            }
        }
     


        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
