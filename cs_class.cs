using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_class
{
    class cs_class
    {
        static void Main(string[] args)
        {
            Dog Pochi = new Dog("Akita Inu");
            Dog coco = new Dog("Maltese");
            Pochi.Name = "ポチ";
            Pochi.Ald = 3;
            coco.Name = "ココ";
            coco.Ald = 5;
            Pochi.ShowProfile();
            coco.ShowProfile();
        }
    }
}