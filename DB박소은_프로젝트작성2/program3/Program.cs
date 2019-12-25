using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//문제3) 1부터 100까지의 총합을 구하는 메소드를 
//①값에 의한 전달 방식과 
//②참조에 의한 전달 방식 두가지 방식으로 작성하세요.

namespace program3
{
    class Program
    {

        public static void sum1(int total1)
        {
            for (int i = 1; i <= 100; i++)
            { 
                total1 += i;
            }
        }
    
        public static void sum2(ref int total2)
        {
            for (int i = 1; i <= 100; i++)
            {
                total2 += i;
            }
        }
    
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            sum1(a);
            sum2(ref b);

            Console.WriteLine("값에의한 전달방식 a : {0}, 참조에의한 전달 방식 b: {1}",a,b);
        }
    }
}

//문제를 정확히 이해하지 못해서 이렇게 하면 되는건지 잘 모르겠습니다..ㅎㅎ