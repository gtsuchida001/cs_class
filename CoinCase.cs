using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_class
{
    internal class CoinCase
    {
        private int count500 = 0;
        private int count100 = 0;
        private int count50 = 0;
        private int count10 = 0;
        private int count5 = 0;
        private int count1 = 0;
        public void AddCoins(int coins, int count)
        {
            switch (coins)
            {
                case 500:
                    count500 += count;
                    break;
                case 100:
                    count100 += count;
                    break;
                case 50:
                    count50 += count;
                    break;
                case 10:
                    count10 += count;
                    break;
                case 5:
                    count5 += count;
                    break;
                case 1:
                    count1 += count;
                    break;
            }
        }
        public int GetCount(int kind)
        {
            switch (kind)
            {
                case 500:
                    return count500;
                case 100:
                    return count100;
                case 50:
                    return count50;
                case 10:
                    return count10;
                case 5:
                    return count5;
                case 1:
                    return count1;
            }
            return 0;
        }
        public int GetAmount()
        {
            return count500 * 500 + count100 * 100 + count50 * 50 + count10 * 10 + count5 * 5 + count1;
        }
        public int GetCount()
        {
            return count500 + count100 + count50 + count10 + count5 + count1;
        }
        public int GetAmount(int kind)
        {
            switch (kind)
            {
                case 500:
                    return count500 * 500;
                case 100:
                    return count100 * 100;
                case 50:
                    return count50 * 50;
                case 10:
                    return count10 * 10;
                case 5:
                    return count5 * 5;
                case 1:
                    return count1;
            }
            return 0;
        }
        public void Display()
        {
            Console.WriteLine("500円は" + count500 + "枚");
            Console.WriteLine("500円は" + GetAmount(500) + "円");
            Console.WriteLine("100円は" + count100 + "枚");
            Console.WriteLine("100円は" + GetAmount(100) + "円");
            Console.WriteLine("50円は" + count50 + "枚");
            Console.WriteLine("50円は" + GetAmount(50) + "円");
            Console.WriteLine("10円は" + count10 + "枚");
            Console.WriteLine("10円は" + GetAmount(10) + "円");
            Console.WriteLine("5円は" + count5 + "枚");
            Console.WriteLine("5円は" + GetAmount(5) + "円");
            Console.WriteLine("1円は" + count1 + "枚");
            Console.WriteLine("1円は" + GetAmount(1) + "円");
            Console.WriteLine("総額は" + GetAmount() + "円");
            Console.WriteLine("総枚数は" + GetCount() + "枚");
        }
    }
}
