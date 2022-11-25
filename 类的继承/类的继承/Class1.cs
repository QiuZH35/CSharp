using System;
using System.Collections.Generic;
using System.Text;

namespace 类的继承
{
    internal class Father
    {

        public string name { get; set; }
        public Sex sex { get; set; }
        protected int weight { get; set; }

        public virtual void Run()
        {
            Console.WriteLine(" the run  is Father" );
        }

        public void eat(string eatting)
        {
            Console.WriteLine("吃" + eatting);
        }

        public Father()
        {



        }
        public Father(int weith)
        {
            this.weight = weith;

        }
        public Father(int weith,string str,Sex sexs)
        {
            this.weight = weith;
            this.name = str;
            this.sex = sexs;
        }
        public virtual string tostrings()
        {

            return "Father:" + name + " " + sex + " " + weight;
        }

    }
    public enum Sex
    {
        男,
        女
    }

}
