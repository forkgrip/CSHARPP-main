using System;
using System.Globalization;
using System.Security;

namespace SampleConsole
{
    class Program
    {



        static int JIHANKI (int num)
        {
            int price = 0;

            if(num == 1)
            {
                Console.WriteLine("ソーダを購入");
                price = 200;
            }

            else if(num == 2)
            {
                Console.WriteLine("コーラを購入");
                price = 300;
            }

            else
            {
                Console.WriteLine("１か２の値を入れてください");
                price = 0;
            }

            return price;

        }

        static void Main(string[] args)
        {
        int money = 600;
        Console.WriteLine("現在" + money +"円です");
        int price = JIHANKI(1);
        money = money - price;
        Console.WriteLine("現在" + money +"円です");
        }

    }
}
