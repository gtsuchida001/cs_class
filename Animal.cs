using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Animal
{
    public string Name = "";    // 名前
    public int Age = 0;         // 年齢

    public void ShowProfile()
    {
        Console.WriteLine(Name + "," + Age + "歳");
    }
}
