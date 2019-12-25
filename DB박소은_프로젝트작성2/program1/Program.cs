using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//문제 1) for문 사용 1~100까지 숫자중에 짝수의 총합, 홀수의 총합, 소수의 갯수를 구하라

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        { 

            int i, j;
            int even=0, odd=0, prime=0;

            for( i = 1; i <= 100; i++)
            {
                if (i % 2 == 0) //나머지가 0 이면 짝수
                    even += i;
                else //아니면 홀수
                    odd += i;

                for ( j = 2; j <= i; j++) //2이상~i미만까지 약수가 있으면 break
                {
                    if (i % j == 0)
                        break;
                }
                //약수가 없고 j가 결국 i일때. 즉 1 제외한 약수가 i밖에없을때 prime++
                if (i == j) 
                    prime++;
            }

            Console.WriteLine("짝수의 총합:{0}, 홀수의 총합:{1}, 소수의 갯수:{2}", even, odd, prime);
        }
    }
}
