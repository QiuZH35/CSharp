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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Queue<int> queue = new Queue<int>();  //创建队列
        private Random random = new Random(new DateTime().Millisecond); //随机数

        private int count = 20;

        Series series = new Series("温度");
        Series series2 = new Series("湿度");
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<count;i++)
            {
                int temp = random.Next(100);//一百以内的随机数
                queue.Enqueue(temp);//随机数填入

            }
            displary();
            this.timer1.Start();  //启动定时器
            timer1.Interval = 400;
            series.ChartType = SeriesChartType.Spline;//设置图形类型为折线
            series2.ChartType = SeriesChartType.Spline;//设置图形类型为折线
            chart1.Series.Add(series); //添加曲线
            chart1.Series.Add(series2); //添加曲线
        }

        private void displary()
        {
            String str = "";
            foreach (int i in queue)
            {
                str += " " + i; 

            }
            textBox1.Text = str;

            series.Points.Clear();//清空原有数据
            series2.Points.Clear();//清空原有数据
            foreach (int i in queue)
            {
                series.Points.Add(i);//添加数据
                series2.Points.Add(i-10);//添加数据
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            queue.Enqueue(random.Next(100));
            queue.Dequeue();
            displary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            series.Points.Clear();//清空原有数据
            series2.Points.Clear();//清空原有数据
           

            
        }
    }
}
