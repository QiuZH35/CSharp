using System;

namespace 作业2
{
    class Program
    {
        static void Main(string[] args)
        {
           // string str="hello world hello C#";
          string str = Console.ReadLine();
           for(int i=str.Length-1;i>=0;i--)
            {
                Console.Write(str[i]);    
            }

           // string str1 = string.Concat(str.Reverse());
           // Console.WriteLine(str1);

            Console.ReadLine();
        }
    }
}
