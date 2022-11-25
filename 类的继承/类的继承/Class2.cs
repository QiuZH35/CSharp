using System;
using System.Collections.Generic;
using System.Text;

namespace 类的继承
{
    internal class Sun : Father
    {
        private int salary { get; set; }
        private string pstion { get; set; }


        public override void Run()
        {
            Console.WriteLine("the Run is Sun");
        }

        public Sun()
        {

        }
        public Sun(int weiths,string str,Sex sexs) 
        {
            this.weight = weiths;
            this.name = str;
            this.sex = sexs;

        }
        public Sun(int weight, string name, Sex sex, int salary, string pstion) : base (weight,name,sex )//使用父类的变量
        {
            this.salary = salary;
            this.pstion = pstion;

        }
        public override string tostrings()
        {

            return "Sun:" + name + "sex= " + sex + "weith= " + weight + "salary= " + salary;
        }
       
    }
}
