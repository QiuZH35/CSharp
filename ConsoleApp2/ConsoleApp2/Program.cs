using System;

using System.Text;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //string str1 = "";
            //if(string.IsNullOrEmpty(str1)) //判断字符串是否为空
            //{
            //    Console.WriteLine("字符串为空");
            //}
            //StringBuilder Sb = new System.Text.StringBuilder(10);
            //Sb.Append("123456789");//压入数据
            //Sb.AppendLine("xxxx");//压入数据，末尾有\0
            //Sb.Insert(4, "yyyy");//根据下标插入，下标从零开始
            //Sb.Replace("23", "32");//将某字符，替换为某字符


            //Console.WriteLine(Sb);
            //Console.Read();
            //Console.WriteLine("请输入身份证号：");
            //string  str1 = Convert.ToString(Console.ReadLine());
            //StringBuilder Sb = new System.Text.StringBuilder(10);
            //Sb.Append(str1);



            //Console.WriteLine("出生日期为:");
            //for (int i = 10; i < 14; i++)
            //{

            //    Console.Write(str1[i]);
            //    if(i%2==1)
            //    {
            //        Console.Write(" ");
            //    }
            //}



            //if ( str1[16]%2==0)
            //{
            //    Console.WriteLine("\n性别:女");
            //}
            //else
            //{
            //    Console.WriteLine("\n性别:男");
            //}

            //Console.WriteLine("\n"str1);

            //int i = 1;
            //int sum =0;
            //AAA:;
            //if(i<=10)
            //{
            //    Console.WriteLine("请输入一个数据：");
            //    int temp = Convert.ToInt32(Console.ReadLine());

            //    sum += temp;
            //    i++;
            //    goto AAA;
            //}
            //Console.WriteLine("  " + sum);

            float gl90 = 6.8F;
            float gl93 = 6.42F;
            float gl97 = 7.02F;
            float oil0 = 5.57F;

            float service1 = 0.1F;
            float service2 = 0.05F;
            Console.WriteLine("汽油类型：\n  90号6.8元/升按1，\n  93号6.42元/升按2,\n  97号7.02元/升按3以及0号柴油5.57元/升按4。\n\n服务等级：\n  人工优惠10%按1，\n  工作人员优惠5%按2。");
           
            Console.WriteLine("\n添加汽油类型：");
            int type= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("添加油量 /升：");
            int add = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("服务类型：");
            int grade= Convert.ToInt32(Console.ReadLine());
            float sum=0;

            float salary=0;
            float ser = 0;
            float moneyall = 0;

            switch (type)
            {
                case 1:
                    salary = 6.8F;
                    break;
                case 2:
                    salary = 6.42F;
                    break;
                case 3:
                    salary = 7.02F;

                    break;
                case 4:
                    salary = 5.57F;
                    break;
               
                default:
                    Console.WriteLine("请输入正确的类型\n");
                    break;
                  
            }
            switch(grade)
            {
                case 1:
                    ser = 0.1F;
                    break;
                case 2:
                    ser = 0.05F;
                    break;
                default:
                    Console.WriteLine("请输入正确的服务等级\n");
                    break;

            }
            

            switch(type)
            {
                case 1:
                    
                    switch(grade)
                    {
                        case 1:
                            sum = add * gl90;
                            sum = sum - sum * service1;
                            break;
                        case 2:
                            sum = add * gl90;
                            sum = sum - sum * service2;
                            break;
                    }
                    break;
                case 2:
                    switch (grade)
                    {
                        case 1:
                            sum = add * gl93;
                            sum = sum - sum * service1;
                            break;
                        case 2:
                            sum = add * gl93;
                            sum = sum - sum * service2;
                            break;
                    }
                    break;
                case 3:
                    switch (grade)
                    {
                        case 1:
                            sum = add * gl97;
                            sum = sum - sum * service1;
                            break;
                        case 2:
                            sum = add * gl97;
                            sum = sum - sum * service2;
                            break;
                    }
                    break;
                case 4:
                    switch (grade)
                    {
                        case 1:
                            sum = add * oil0;
                            sum = sum - sum * service1;
                            break;
                        case 2:
                            sum = add * oil0;
                            sum = sum - sum * service2;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("请输入正确的类型\n");
                    break;
            }

            moneyall = salary * add;
            moneyall -= moneyall * ser;

            Console.WriteLine("您需要付款{0:F2},{0:F2}元",sum,moneyall);







        }
    }
}
