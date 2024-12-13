using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_class
{
    internal class Cat : Animal
    {
        private string sleep = "";    // 猫種

        public string sleepinfo
        {
            get { return sleep; }
            set { sleep = value; }
        }

        public void Sleep()
        {
            Console.WriteLine("スースー");
        }

    }
}
