using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace 调查问卷
{
    public partial class 调查 : Form
    {
        private string name;
        private string age;
        private Sex sex;
        private string birthadree;//出生地
        private string birthdate ;//出生日期
        private string result;
        private string hobbieslist;
        public 调查()
        {
            InitializeComponent();
            age = "";
            name = "";
            sex=0;
            birthadree="";
            birthdate="";
            hobbieslist="";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                textresult.Text ="";
                name = (textBoxname.Text);//Trim() 去除两端空格
                age = (Convert.ToString(textBoxage.Text));

                result = "\r"+"  姓名: " + name + "\r\n" + "  年龄: " + age + "\r\n" + "  性别: " + sex + "\r\n" + "  出生地: " + birthadree + "\r\n" + "  出生日期: " + birthdate + "\r\n" + "  爱好: "+ hobbieslist + "\r\n";

           
                textresult.Text = result;
                age = "";
                name = "";
                sex = 0;
                birthadree = "";
                birthdate = "";
                hobbieslist = "";
                result = "";
            textBoxname.Text = "";
            textBoxage.Text = "";

        }
       
        //选中按钮
        private void man_CheckedChanged(object sender, EventArgs e)
        {
            if(man.Checked==true)
            {
                sex=(Sex.男);
            }
            else
            {
                sex=(Sex.女);
            }
           
        }

        private void men_CheckedChanged(object sender, EventArgs e)
        {
            if (men.Checked == true)
            {
                sex=(Sex.女);
            }
            else
            {
                sex=(Sex.男);
            }
        }

        //下拉框，选择
        private void 籍贯_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthadree=(籍贯.Text);
            
        }

        //日期选择
        private void dateTimebirth_ValueChanged(object sender, EventArgs e)
        {
            birthdate=((Convert.ToString(dateTimebirth.Text)));
           
        }

        private void checkbasketball_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbasketball.Checked)
            {
                
                    hobbieslist+=(" 篮球 ");
 
            }
            else
            {
               
            }
        }

        private void checksoccer_CheckedChanged(object sender, EventArgs e)
        {
            if (checksoccer.Checked)
            {
                
                    hobbieslist+=(" 足球 ");
                
            }
            else
            {
                
                   
              
            }
        }

        private void checkbadminton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbadminton.Checked)
            {
                
                    hobbieslist+=(" 羽毛球 ");
               
            }
            else
            {
                
               
            }
        }

        private void checktabletennis_CheckedChanged(object sender, EventArgs e)
        {
            if (checktabletennis.Checked)
            {
                   hobbieslist+=(" 乒乓球 ");
                
            }
            else
            {
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxname.Text = "";
            textBoxage.Text = "";
            age = "";
            name = "";
            sex = 0;
            birthadree = "";
            birthdate = "";
            hobbieslist = "";
        }
  
    }
    public enum Sex
    {
        男,女
    }
}
