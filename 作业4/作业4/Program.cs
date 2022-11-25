using System;


namespace 作业4
{
    internal class Program
    {

        static void bigtosmallsort(double [] a)
        {
            for(int i=0;i<a.Length-1;i++)
            {
                for(int j=0;j< a.Length - 1-i;j++)
                {
                    if(a[j]< a[j+1])
                    {
                        double temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void smalltobigsort(double[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        double temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            double[] chinese = new double[6];
            double[] math = new double[6];
            double[] english = new double[6];
            Console.WriteLine("请输入5人的语文成绩:");
           for(int i=0;i<5;i++)
            {
                chinese[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("请输入5人的数学成绩:");
            for (int i = 0; i < 5; i++)
            {
                math[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("请输入5人的英语成绩:");
            for (int i = 0; i < 5; i++)
            {
                english[i] = Convert.ToDouble(Console.ReadLine());
            }
            double sum = 0.0;
            bigtosmallsort(chinese);
            smalltobigsort(math);
            for(int i=0;i<6;i++)
            {
                sum += english[i];
            }
            sum /= 5;
            Console.WriteLine("\n语文最高分的两个成绩为"+chinese[0]+" "+chinese[1]);
            Console.WriteLine("\n数学最低分的两个成绩为" + math[1] + " " + math[2]);
            Console.WriteLine("\n英语平均分为"+sum);
           
        }
    }
}
