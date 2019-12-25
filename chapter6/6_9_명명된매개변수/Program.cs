using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_9_명명된매개변수
{
    class Program
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine("Name:{0}, Phone:{1}", name, phone);

        }
        static void Main(string[] args)
        {
            PrintProfile(name: "박소은", phone: "010-123-1233");
            PrintProfile( phone: "010-123-1233", name: "박소은");
            PrintProfile("박랄랄","01255475671233");
            PrintProfile("박ㅇ오옹", phone: "010-3424234231233");
        }
    }
}
