using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗口_EF框架操作数据库
{
    public partial class Form1 : Form
    {

        //testEntities Setdb = new testEntities();//构造对象
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //添加数据
        {
            using (testEntities SetdbAdd = new testEntities())
            {
                Student student = new Student();
                student.id = Convert.ToInt32(textBox1.Text);
                student.name = textBox2.Text;
                student.java = Convert.ToInt16(textBox3.Text);
                student.csharp = Convert.ToInt16(textBox4.Text);

                SetdbAdd.Students.Add(student);//添加数据
                SetdbAdd.SaveChanges();//保存
                MessageBox.Show("添加成功", "提示");
            }
            clearall();
        }

        private void button2_Click(object sender, EventArgs e)  //删除数据
        {
            using (testEntities SetdbDel = new testEntities())
            {
                int id = 0;
                int java = 0;
                int csharp = 0;
                string strname = "";

                if(textBox1.Text !="")
                {
                    id = Convert.ToInt32(textBox1.Text);
                }
                if (textBox2.Text != "")
                {
                    strname = (textBox2.Text);
                }
                if (textBox3.Text !="")
                {
                    java = Convert.ToInt16(textBox3.Text);
                }
                if (textBox4.Text !="")
                {
                    csharp = Convert.ToInt16(textBox4.Text);
                }

                SetdbDel.Students.Remove(SetdbDel.Students.Where(x => x.id == id || x.name==strname ||x.java==java || x.csharp==csharp).FirstOrDefault());
                SetdbDel.SaveChanges();
                MessageBox.Show("删除成功", "提示");
                clearall();
            }
        }

        private void button4_Click(object sender, EventArgs e)  //显示数据
        {
            textBox5.Text = "";
            using (testEntities SetdbShow = new testEntities())
            {
                string strdata = "";
                foreach(Student s in SetdbShow.Students)
                {

                    strdata += s.id + "\t" + s.name + "\t" + s.java + "\t" + s.csharp + "\r\n";
                }
                textBox5.Text = strdata;
                SetdbShow.SaveChanges();
            }
        }

        private void button3_Click(object sender, EventArgs e)  //修改数据
        {
            using (testEntities SetdbSet =new testEntities())
            {
                int id = 0;
                int java = 0;
                int csharp = 0;
                string strname = "";

                if (textBox1.Text != "")
                {
                    id = Convert.ToInt32(textBox1.Text);
                }
                if (textBox2.Text != "")
                {
                    strname = (textBox2.Text);
                }
                if (textBox3.Text != "")
                {
                    java = Convert.ToInt16(textBox3.Text);
                }
                if (textBox4.Text != "")
                {
                    csharp = Convert.ToInt16(textBox4.Text);
                }
                Student student = SetdbSet.Students.Where(x => x.id == id || x.name == strname || x.java == java || x.csharp == csharp).FirstOrDefault();
                if(student !=null)
                {
                    if (textBox9.Text != "")
                    {
                       student. id = Convert.ToInt32(textBox9.Text);
                        
                    }
                    if (textBox8.Text != "")
                    {
                        student.name = (textBox8.Text);
                        
                    }
                    if (textBox7.Text != "")
                    {
                        student.java = Convert.ToInt16(textBox7.Text);
                        
                    }
                    if (textBox6.Text != "")
                    {
                        student.csharp = Convert.ToInt16(textBox6.Text);
                        
                    }
                    
                    SetdbSet.SaveChanges();
                    MessageBox.Show("修改成功", "提示");
                }

                clearall();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (testEntities SetdbDels=new testEntities())
            {
                int id = 0;
                int java = 0;
                int csharp = 0;
                string strname = "";

                if (textBox1.Text != "")
                {
                    id = Convert.ToInt32(textBox1.Text);
                }
                if (textBox2.Text != "")
                {
                    strname = (textBox2.Text);
                }
                if (textBox3.Text != "")
                {
                    java = Convert.ToInt16(textBox3.Text);
                }
                if (textBox4.Text != "")
                {
                    csharp = Convert.ToInt16(textBox4.Text);
                }

                SetdbDels.Students.RemoveRange(SetdbDels.Students.Where(x => x.id == id || x.name == strname || x.java == java || x.csharp == csharp));
                SetdbDels.SaveChanges();
                MessageBox.Show("删除成功", "提示");

                clearall();
            }
        }

        public  void clearall()  //清空
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
        }
    }
}
