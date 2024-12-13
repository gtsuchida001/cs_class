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
            Dog dog = new Dog("ポチ", 5);
            cat.ShowProfile();
            dog.ShowProfile();
            cat.Sleep();
            dog.Run();
            cat.Speak();
            dog.Speak();
        }
    }
}