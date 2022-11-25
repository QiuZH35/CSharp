using System;
using System.Collections.Generic;
using System.Text;

namespace 类的继承
{
    internal class interface实现 : myInterface   //实现接口
    {
        public void Eat(string name)
        {
            Console.WriteLine("鸟吃" + name);

        }
        public void Sund()
        {
            Console.WriteLine("唧唧咋咋");

        }

    }
}
