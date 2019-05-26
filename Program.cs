using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Match
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = double.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var sum =0.00;
            var raz=0.00;
            if (s=="VIP")
            {
                if (n <= 4)
                {
                    sum = m * 75 / 100; raz = m - sum - (n * 499.99);
                    {
                        if (raz >= 0)
                        { Console.WriteLine("Yes! You have {0:f2} leva left.", raz); }
                        else { raz = Math.Abs(raz); Console.WriteLine("Not enough money! You need {0:f2} leva.", raz); }
                    }
                }
                else if (n <= 9)
                {
                    sum = m * 6 / 10; raz = m - sum - n * 499.99;
                    {
                        if (raz >= 0)
                        { Console.WriteLine("Yes! You have {0:f2} leva left.", raz); }
                        else { raz = Math.Abs(raz); Console.WriteLine("Not enough money! You need {0:f2} leva.", raz); }
                    }
                }
                else if (n <= 24)
                {
                    sum = m * 5 / 10; raz = m - sum - n * 499.99;
                    {
                        if (raz >= 0)
                        { Console.WriteLine("Yes! You have {0:f2} leva left.", raz); }
                        else { raz = Math.Abs(raz); Console.WriteLine("Not enough money! You need {0:f2} leva.", raz); }
                    }
                }
                else if (n <= 49)
                {
                    sum = m * 4 / 10; raz = m - sum - n * 499.99;
                    {
                        if (raz >= 0)
                        { Console.WriteLine("Yes! You have {0:f2} leva left.", raz); }
                        else { raz = Math.Abs(raz); Console.WriteLine("Not enough money! You need {0:f2} leva.", raz); }
                    }
                }
                else
                {
                    sum = m * 25 / 100; raz = m - sum - n * 499.99;
                    {
                        if (raz >= 0)
                        { Console.WriteLine("Yes! You have {0:f2} leva left.", raz); }
                        else { raz = Math.Abs(raz); Console.WriteLine("Not enough money! You need {0:f2} leva.", raz); }
                    }
                } 
            }
            else
            {
                if (n <= 4)
                {
                    sum = m * 75 / 100; raz = m - sum - (n * 249.99);
                    {
                        if (raz >= 0)
                        { Console.WriteLine("Yes! You have {0:f2} leva left.", raz); }
                        else { raz = Math.Abs(raz); Console.WriteLine("Not enough money! You need {0:f2} leva.", raz); }
                    }
                }
                else if (n <= 9)
                {
                    sum = m * 6 / 10; raz = m - sum - n * 249.99;
                    {
                        if (raz >= 0)
                        { Console.WriteLine("Yes! You have {0:f2} leva left.", raz); }
                        else { raz = Math.Abs(raz); Console.WriteLine("Not enough money! You need {0:f2} leva.", raz); }
                    }
                }
                else if (n <= 24)
                {
                    sum = m * 5 / 10; raz = m - sum - n * 249.99;
                    {
                        if (raz >= 0)
                        { Console.WriteLine("Yes! You have {0:f2} leva left.", raz); }
                        else { raz = Math.Abs(raz); Console.WriteLine("Not enough money! You need {0:f2} leva.", raz); }
                    }
                }
                else if (n <= 49)
                {
                    sum = m * 4 / 10; raz = m - sum - n * 249.99;
                    {
                        if (raz >= 0)
                        { Console.WriteLine("Yes! You have {0:f2} leva left.", raz); }
                        else { raz = Math.Abs(raz); Console.WriteLine("Not enough money! You need {0:f2} leva.", raz); }
                    }
                }
                else
                {
                    sum = m * 25 / 100; raz = m - sum - n * 249.99;
                    {
                        if (raz >= 0)
                        { Console.WriteLine("Yes! You have {0:f2} leva left.", raz); }
                        else { raz = Math.Abs(raz); Console.WriteLine("Not enough money! You need {0:f2} leva.", raz); }
                    }
                }
            }
            

        }
    }
}
