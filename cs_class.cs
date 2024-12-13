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
            int limit = 10;
            CoinCase MyCase = new CoinCase();
            for (int i = 0; i < limit; i++)
            {
                Console.Write("硬貨:");
                string? input = Console.ReadLine();
                int.TryParse(input, out int Coins);
                Console.Write("枚数:");
                input = Console.ReadLine();
                int.TryParse(input, out int Count);
                MyCase.AddCoins(Coins, Count);
            }
            MyCase.Display();
        }
    }
}