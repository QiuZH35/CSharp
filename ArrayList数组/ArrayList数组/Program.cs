using System;
using System.Collections;


namespace ArrayList数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();   //动态数组
            list.Add("huanghui");                  //添加单个 
            list.Add("wangwu");
            String[] str = new string[] { "zhangsan", "黄辉", "xxxx" };
            list.AddRange(str);      //添加多个元素
            foreach (string str1 in list.GetRange(1, 3))    //GetRange 指定位置读取指定长度
            {
                Console.WriteLine (str1);
            }



            Console.WriteLine("Hello World!");
        }
    }
}
