using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_class
{
    internal class Cat : Animal
    {
        private string sleep = ""; // 猫種

        public string SleepInfo
        {
            get { return sleep; }
            set { sleep = value; }
        }

        public Cat(string name, int age) : base(name, age)
        {
        }
        public void Sleep()
        {
            Console.WriteLine("スースー");
        }
        public override void Speak()
        {
            Console.WriteLine("ニャー");
        }
    }
}
