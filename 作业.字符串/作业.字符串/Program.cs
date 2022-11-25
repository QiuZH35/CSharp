using System;

namespace 作业.字符串
{
    internal class Program
    {
      
        public static string process(string str)
        {
            string[] strArray =new string[1024] ;
            string[] Symbol = new string[] { " " };
            foreach(string sy in Symbol)
            {
                 strArray = str.Split(sy.ToCharArray());
            }
             //根据空格分割字符串，并转化为Char类型的数组
            string outstr = string.Empty; //定义一个空字符串
            foreach (string str1 in strArray)   //遍历每个字符串
            {
                outstr += str1.Substring(0, 1).ToUpper() + str1.Substring(1) + " ";   //字符串连接 ， substring(0,1) 指定位置读取指定长度

                                                                                      //Substring(0, 1)，从零开始读取一个字符串首字母.ToUpper()转换为大写
                                                                                      //Substring(1) + " "末尾添加空格
            }
            return outstr;
        }
       
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("输入字符串\n");
            str = Console.ReadLine();
            string Outstr = process(str);       
            
            string[] result = Outstr.Split(' ');
            foreach (var word in result)
            {
                Console.Write(" " + word + " ");
                 
            }

            Console.Read();
        }
       
    }
}
