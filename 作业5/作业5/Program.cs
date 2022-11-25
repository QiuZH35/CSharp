using System;
using System.Threading;
namespace 作业5
{
    internal class Program
    {
       



        
        static void Main(string[] args)
        {

           
            Phone Myphone=new Phone();
           
            Console.WriteLine("开机按1");
            int change = Convert.ToInt32(Console.ReadLine());
            if (change == 1)
            {
                Myphone.show();
                Console.WriteLine("输入你的选择:");
                while (true)
                {

                    int changenum = Convert.ToInt32(Console.ReadLine());
                    switch (changenum)
                    {
                        case 1:
                            Myphone.MusicMenu();
                            Console.WriteLine("已显示所有音乐:\n");
                            break;
                        case 2:

                            Console.WriteLine("最大同时下载量5，输入下载数量:");
                            int num = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("输入需要下载的歌名:");

                            string[] musicLoad = new string[num];
                            for (; num > 0;)
                            {
                                musicLoad[num - 1] = Console.ReadLine();
                                num--;
                            }

                            Myphone.LoadMusic(musicLoad);
                            Console.WriteLine("下载完成:\n");
                            break;
                        case 3:
                            Console.WriteLine("输入歌名:");
                            string musicplay = Console.ReadLine();
                            Myphone.PlayMusic(musicplay);
                           
                            break;
                        case 4:
                            int charge = Convert.ToInt32(Console.ReadLine());
                            Myphone.Charge(charge);
                            Console.WriteLine("充电完成:\n");
                            break;
                        case 5:
                            Myphone.ShowCharge();
                            Console.WriteLine("已完成:\n");
                            break;
                        case 6:
                            Myphone.ShowCell();
                            Console.WriteLine("已完成:\n");
                            break;
                        case 0:
                            Console.WriteLine("正在关机:\n");
                            Thread.Sleep(3000);
                            goto guanji;
                            

                        default:
                            Console.WriteLine("输入错误,重新输入");
                            break;

                    }
                }
            guanji:
                Console.WriteLine("已关机:\n");
            }
           

            Console.ReadLine();
        }
    }
}
