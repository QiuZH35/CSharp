using System;

namespace Stringarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string stra ="C:C# \\string";
            string strb = @"C:C# \string";
            Console.WriteLine(stra);
            Console.WriteLine(strb);
            Console.WriteLine("C:C# \\string"); //转义字符
            Console.WriteLine(@"C:C# \string");  //两者等价




            char[] array = { 'a', 'b', 'c', 'd', 'e' };





            string str = new string(array); //新建一个string，存放array 
            string str2 = new string('g', 20); //创建一个string,里面有二十个g
            string str3 = new string(array, 2, 2);//从array中的第二个元素开始读取两位
            Console.WriteLine(str3);
            Console.WriteLine(str2);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
