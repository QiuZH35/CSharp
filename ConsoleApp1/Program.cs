using System;

namespace ConsoleApp1
{
    class Program
    {
        enum Mydate
        {
            Sun,
            Mon,
            Tue,
            Wed,
            Thu,
            Fir,
            Sat
        }
        static void Main(string[] args)
        {
            int k = (int)Mydate.Tue;
            switch(k)
            {
                case (int)Mydate.Sun:
                    Console.WriteLine("今天是星期日");
                    break;
                case (int)Mydate.Mon:
                    Console.WriteLine("今天是星期一");
                    break;
                case (int)Mydate.Tue:
                    Console.WriteLine("今天是星期二");
                    break;
                case (int)Mydate.Wed:
                    Console.WriteLine("今天是星期三");
                    break;
                case (int)Mydate.Thu:
                    Console.WriteLine("今天是星期四");
                    break;
                case (int)Mydate.Fir:
                    Console.WriteLine("今天是星期五");
                    break;
                case (int)Mydate.Sat:
                    Console.WriteLine("今天是星期六");
                    break;
            }

            Console.ReadKey();



        }
    }
}
