using System;
using System.Collections.Generic;
using System.Text;

namespace 作业5
{

    internal class Cell
    {
        private int  BatteryCapacity=20;  //电量
        private string brand = "超威";//电池品牌
        public void Charge(int charge)
        {
            BatteryCapacity += charge;
            if ((BatteryCapacity )>=100)
            {
                BatteryCapacity = 100;
            }
            
        }

        
        public void ShowCell()
        {
            Console.WriteLine("\n电池品牌：" + brand);
            Console.WriteLine("电量为:" + BatteryCapacity);
        }
        
        public void ShowCharge()
        {
            Console.WriteLine("当前电量为:" + BatteryCapacity);
        }

    }
    internal class Phone :Cell
    {

        private string []_Music;


        public void show()
        {
            Console.Write("功能菜单:  \n");
            Console.Write("  音乐菜单--1\n");
            Console.Write("  下载音乐--2\n");
            Console.Write("  播放音乐--3\n");
            Console.Write("  充电--4\n");
            Console.Write("  显示电量--5\n");
            Console.Write("  电池品牌--6\n");
            Console.Write("  关机--0\n ");
        }
      


        public void LoadMusic(string []NewMusic) //下载音乐
        {
            _Music = NewMusic;
        }

        public void MusicMenu()  //音乐列表
        {
            Console.WriteLine("我的下载:");
            if (_Music != null)
            {
                foreach (string i in _Music)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("空\n");
            }

        }

        public void PlayMusic(string playmusic)
        {
            if (_Music != null)
            {
               
                for (int i = _Music.Length - 1; i >= 0; i--)
                {


                    if (i >= 0 && i <= _Music.Length - 1)
                    {
                        if (_Music[i] == playmusic)
                        {
                            Console.WriteLine("正在为您播放：" + _Music[i]);

                        }

                    }
                }
            }

            else
            {
                Console.WriteLine("无音乐,请下载\n");
            }

         
        }
       

    }
    


}
