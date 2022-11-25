using System;

namespace 第二节课
{
    class Program
    {
        static void Main(string[] args)
        {
            float res = 80500.0F;
            Console.WriteLine("请输入岁数\n");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入一年的天数\n");
            int yearday = Convert.ToInt32(Console.ReadLine());

            float yearrun=res/year;
            float dayrun=res/year/yearday;

            Console.WriteLine("每年走{0:F2}公里 \n", yearrun);
            Console.WriteLine("每天走{0:F2}公里 \n", dayrun);
            Console.ReadKey();
        }
    }
}
