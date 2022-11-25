
using System;
//Convert.To+类型


//类型.Parse


namespace 数据类型转换
{
    class Program
    {
       
    static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数据: ");

            String onestring = Console.ReadLine();
            //double one = Convert.ToDouble(onestring);
            double one = double.Parse(onestring);


            Console.WriteLine("请输入第二个数据: ");
            String twostring = Console.ReadLine();
            //double two = Convert.ToDouble(twostring);
            double two;//double.Parse(twostring);
            //double num1 = 0.0;
            

            double sum = one + two;
            Console.WriteLine("两数之和是:"+sum);

           


            unsafe
            {

                int num = 12;

         
                void* p = &num;
                Console.WriteLine("{0:x}",(int)p);

            }






            Console.ReadKey();
        }
    }
}
