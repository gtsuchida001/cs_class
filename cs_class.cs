using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace cs_class
{
    class cs_class
    {
        static void Main()
        {
            Cat cat = new Cat("タマ", 3);
            cat.ShowProfile();
            cat.Sleep();
        }
    }
}