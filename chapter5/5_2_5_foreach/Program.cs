﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_5_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach(int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}