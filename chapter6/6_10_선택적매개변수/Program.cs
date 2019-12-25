using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_10_선택적매개변수
{
    class Program
    {
        static void PrintProfile(string name, string phone="")
        {
            Console.WriteLine("Name:{0}, Phone:{1}", name, phone);

        }
        static void Main(string[] args)
        {
            PrintProfile("태연");
            PrintProfile("윤아","010-231232-3213123");
            PrintProfile(name:"박랄랄");
            PrintProfile(name:"박ㅇ오옹", phone: "010-3424234231233");
        }
    }
}
