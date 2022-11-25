using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 窗体_Queue队列实现
{
    public partial class Form1 : Form
    {

        private Queue<int> queue = new Queue<int>();//定义一个队列，队列属于泛型
        private int count = 10;//循环次数
        private Random random = new Random(new DateTime().Millisecond);

        Series series1 = new Series("温度");

        
        public Form1()
        {
            InitializeComponent();
           
            
           // queue.Clear();//清除当前数据

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                int temp = random.Next(100);
                queue.Enqueue(temp);  //填入数据
            }
            displary();
            timer1.Start();

            chart1.ChartType = SeriesChartType.Spline;
;
        }
        private void displary()
        {
            string strqueue = "";
            foreach(int i in queue)
            {
                strqueue += " " + i;
            }
            textBox1.Text = strqueue;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            queue.Enqueue(random.Next(100));
            queue.Dequeue();
            displary();


        }
    }
}
