﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_5_ref_return
{

    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        { return ref price; }

        public void PrintPrice()
        {
            Console.WriteLine($"Price:{price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");
        }
    }
}
