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
            Animal[] animals = new Animal[4];
            animals[0] = new Dog("ポチ",1);
            animals[1] = new Cat("タマ",2);
            animals[2] = new Dog("イヌ",3);
            animals[3] = new Cat("キキ",4);
            foreach (Animal animal in animals)
            {
                animal.ShowProfile();
                animal.Speak();
            }
        }
    }
}