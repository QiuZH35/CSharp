using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗口_定时器使用
{
    public partial class Form1 : Form
    {
        private int seconds = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();  //定时器启动
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds+=1;
            textBox1.Text = seconds.ToString();
            if (seconds==15)
            {
                //timer1.Interval = 500;  
                this.timer1.Tick += new System.EventHandler(this.Myhander);  //创建一个定时器行为 
            }



        }

        private void Myhander(object sender, EventArgs e)
        {

            // MessageBox.Show(seconds.ToString());
            Console.WriteLine(seconds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seconds = 0;
            textBox1.Text = seconds.ToString();
        }
    }
}
