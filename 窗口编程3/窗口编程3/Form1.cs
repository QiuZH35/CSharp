using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace 窗口编程3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text= ""; //清除文本框内容


        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();  //创建保存文件框信息对象
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                String text = textBox1.Text;
                string filename = dialog.FileName;
                using (StreamWriter writer=new StreamWriter(filename) )  //System.IO流中的读取流
                {
                    writer.Write(text);

                }


            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();//打开文件对话框
            if(dialog.ShowDialog()==DialogResult.OK)
            {

                string fileName = dialog.FileName;
                using (StreamReader reader = new StreamReader(fileName)) //StreamReader读取文件流
                {
                    string text = reader.ReadToEnd();
                    textBox1.Text = text;
                }

            }
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();//撤销
        }

    }
}
