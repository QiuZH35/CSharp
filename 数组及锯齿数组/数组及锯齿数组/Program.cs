using System;

namespace 数组及锯齿数组
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int[][]a= new int[3][];
            for (int i = 0; i < 3; i++)
            {
                a[i] = new int[i+1];
                for (int j = 0; j < i+1; j++)
                {
                    a[i][ j] = i+j;
                    Console.Write(" " +a[i][j]);
                }
                Console.WriteLine();
            }
            int sum = 0;
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<i+1;j++)
                {
                    sum += a[i][j];
                }
            }


            Console.WriteLine(" " + sum);



            Console.WriteLine("Hello World!");
        }
        static unsafe void sorta(int []a)
        {
            for (int i = 0; i < 9 - 1; i++)
            {
                for (int j = 0; j < 9 - 1 - i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;


                    }


                }


            }


        }
        static void Main(string[]args)
        {
            int[] a = new int[9] { 1, 2, 9, 6, 7, 8, 4, 5, 3 };



            sorta(a);
            
            //for(int i=0;i<9-1;i++)
            //{
            //    for(int j=0;j<9-1-i;j++)
            //    {
            //        if(a[j]<a[j+1])
            //        {
            //            int temp = a[j];
            //            a[j] = a[j + 1];
            //            a[j + 1] = temp;


            //        }


            //    }


            //}
            foreach(int arr in a)
            {
                Console.Write(" " + arr);
            }



        }


    }
}
