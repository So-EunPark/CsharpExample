﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace _4_11Null병합연산자
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{ num ?? 0}");

            num = 99;
            Console.WriteLine($"{ num ?? 0}");

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");
        }
    }
}
