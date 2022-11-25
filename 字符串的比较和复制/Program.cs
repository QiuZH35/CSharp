using System;

namespace 字符串的比较和复制
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abcde";
            string str2 = "fghij";
            string strcat1 = string.Concat(str1, str2); //字符串拼接
            int strcompare = string.Compare(str1, str2);//字符串比较，相同0，大于1，小于-1
            bool strtrue = string.Equals(str1, str2);   //   字符串比较。相同true,不同false                                                                                         




            Console.WriteLine(" " + strtrue);


            Console.WriteLine(strcat1);
            Console.WriteLine("strconmpare = "+strcompare);
            Console.ReadKey();
        }
    }
}
