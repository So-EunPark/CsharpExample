﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace _4_9_2비트논리연산자
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 10;

            Console.WriteLine($"{a} & {b} :{ a & b }");
            Console.WriteLine($"{a} | {b} :{ a | b }");
            Console.WriteLine($"{a} ^ {b} :{ a ^ b }");

            int c = 255;
            Console.WriteLine("~{0}(0x{0:X8}) :{1}(0x{1:X8})",c,~c);
        }
    }
}
