using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗口_数据库操作
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            string connectting = "Server=DESKTOP-TTG0AN1; User Id=sa;Password=123456;DataBase=test";
            connection = new SqlConnection(connectting);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connectting = "Server=DESKTOP-TTG0AN1; User Id=sa;Password=123456;DataBase=test";
            //connection = new SqlConnection(connectting);

            connection.Open();
            if(connection.State==ConnectionState.Open)
            {
                

                SqlCommand cmd = new SqlCommand(textBox1.Text);
                //connection = new SqlConnection(textBox1.Text);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("数据库连接失败");

            }
            connection.Close();//关闭数据库
        }

        private void button2_Click(object sender, EventArgs e)
        {

            connection.Open();
            string str = "select * from student;";
            SqlCommand cmd = new SqlCommand(str);
            cmd.Connection = connection;
            //cmd.ExecuteNonQuery();

            SqlDataReader der = cmd.ExecuteReader();
            string Result = "";
            try
            {
                if(der.HasRows)     //判断SqlDataReader对象是否有数据
                while (der.Read())
                {
                    String temp = der[0].ToString() + "\t" + der[1].ToString() + "\t" + der[2].ToString() + "\t" + der[3].ToString() + "\r\n";
                    Result += temp;
                }
            }
            catch (SqlException ex) //捕获数据库异常
            {
                MessageBox.Show(ex.ToString());//输出异常信息
            }
            
            der.Close();//关闭SqlDataReader对象
            connection.Close(); //关闭数据库
            

            textBox2.Text = Result;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from sys.tables where name='" + textBox4.Text+"';";   //sql语句，查询表的存在

            string cmdoldstr = "select * from sys.tables where name='" + textBox3.Text + "';";  //判断要复制的表是否存在
            connection.Open();//连接数据库打开

            SqlCommand _GOldcmd = new SqlCommand(cmdoldstr, connection);
            SqlDataReader Reader_Old = _GOldcmd.ExecuteReader();
            if (Reader_Old.HasRows) {

                Reader_Old.Close();// 执行多个SqlCommand对象，需要关闭上一个命令链接


                SqlCommand _Gcmd = new SqlCommand(cmdstr, connection);//创建数据库命令
                SqlDataReader reader = _Gcmd.ExecuteReader();//读取数据
                if (reader.HasRows == false)  //表不存在，创建表
                {
                    reader.Close();
                    string strcmd = "select * into  " + textBox4.Text + " from " + textBox3.Text + ";";  //根据旧表创建新表
                    SqlCommand cmd = new SqlCommand(strcmd);
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                    string strsqlcmd = "select * from " + textBox3.Text + ";";
                    SqlDataAdapter sqldata = new SqlDataAdapter(strsqlcmd, connection);  //实例化数据库桥接器对象
                    DataSet myds = new DataSet();//实例化数据集对象
                    sqldata.Fill(myds, textBox4.Text);
                    dataGridView1.DataSource = myds.Tables[textBox4.Text];//为datagridView指定数据源


                    connection.Close(); //关闭数据库连接

                }
                else
                {

                    reader.Close();


                    string strcmp = "drop table " + textBox4.Text + ";";  //如果表存在则删除表
                    SqlCommand cmddrop = new SqlCommand(strcmp);
                    cmddrop.Connection = connection;
                    cmddrop.ExecuteNonQuery();

                    //最快捷的覆盖就是删除，重建
                    string strcmd = "select * into  " + textBox4.Text + " from " + textBox3.Text + ";";  //创建新表
                    SqlCommand cmd = new SqlCommand(strcmd);
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();

                    string strsqlcmd = "select * from " + textBox3.Text + ";";


                    SqlDataAdapter sqldata = new SqlDataAdapter(strsqlcmd, connection);  //实例化数据库桥接器对象
                    DataSet myds = new DataSet();//实例化数据集对象
                    sqldata.Fill(myds, textBox4.Text);//填充数据到 textBox4.Text 中
                    dataGridView1.DataSource = myds.Tables[textBox4.Text];//为datagridView指定数据源

                    connection.Close();
                }
            }
            else
            {
                Reader_Old.Close();
                connection.Close();
                string mestext = textBox3.Text + " 不存在!";
                MessageBox.Show(mestext);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            String adddata = "insert into student values ("+textBox5.Text+",'"+textBox8.Text+"',"+textBox7.Text+","+textBox6.Text+");";

            connection.Open();
            SqlCommand cmdadd = new SqlCommand(adddata, connection);
           

            cmdadd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
