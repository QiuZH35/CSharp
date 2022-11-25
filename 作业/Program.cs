using System;

namespace 作业
{
    class Program
    {
        static void Main(string[] args)
        {
            // string str = "hello world,hello C#";
            string str = Convert.ToString(Console.ReadLine());
            string[] resstr = str.Split(new char[] { ' ' });
            
           foreach (string s in resstr)
           {
                Console.Write(s);
           }
            

            Console.ReadKey();
        }
    }
}
