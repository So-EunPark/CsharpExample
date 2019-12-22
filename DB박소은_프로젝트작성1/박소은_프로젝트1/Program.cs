using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;


namespace 박소은_프로젝트1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("행 수를 입력하세요. : ");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("\n0보다 작거나 같은 숫자는 입력할 수 없습니다.\n");
                Environment.Exit(0); //프로그램 종료

            }

            for (int i = 0; i < num; i++)
            {
                for (int j = 0 ; j<num-i-1 ; j++) //공백을 찍어준다
                    Console.Write(" ");
                
                for(int j=0; j<(2*i)+1 ; j++) // 별찍기
                    Console.Write("*");

                Console.WriteLine();//줄넘기기
            }
          
        }
    }
}
