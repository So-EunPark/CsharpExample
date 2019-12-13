using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class HelloWorld
    {
        //프로그램 실행이 시작되는곳
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("사용법:HelloWorld.exe <이름>");//메소드
                return;
            }

            WriteLine("Hello,{0}!", args[0]);
        }

    }
}
