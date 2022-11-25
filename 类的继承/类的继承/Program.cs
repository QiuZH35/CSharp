using System;

namespace 类的继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Father p = new Father(120, "zhangsan", Sex.男);
            p.eat("白菜");
            p.Run();
            Console.WriteLine(p.tostrings());

            Sun s = new Sun(99, "lisi", Sex.女, 3000, "抓小偷");
            s.Run();
            
            Console.WriteLine(s.tostrings());

        }

        //static void Main(string [] args)
        //{
        //    interface实现 bird = new interface实现();
        //    bird.Eat("饭");
        //    bird.Sund();

        //}


    }
}
