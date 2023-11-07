using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class product
    {
        public int ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public override string ToString()
        {
            return $"{ProductPrice} {ProductQuantity}";
        }

        public void MonthlyPay()
        {
            double starter = 1000;

            double pay = starter / 5 + 10;

            Console.WriteLine($"Starter Price was {starter}");
            Console.WriteLine($"Payment was {pay}");
            Console.WriteLine("Would you like to pay in advance");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                   Console.WriteLine($"new payment {starter += starter * 0.1}");
                    break;

              case 2:
                    Console.WriteLine("Cancelled");
                    break;
            }
        }
        }
  }
