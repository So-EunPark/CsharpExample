using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//문제2) 메소드의 매개변수중에 값에 의한 전달 방식과 
//       참조에 의한 전달 방식의 차이를 설명하세요

namespace program2
{
    class Program
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        public static void refSwap(ref int a,ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }


        static void Main(string[] args)
        {

            int x = 3;
            int y = 4;

            Console.WriteLine("\n** 값에 의한 전달방식 **\n");
            Console.WriteLine(" 값에의한 전달방식의 결과 x의값과 y의값은 Swap되지 않음. \n");
            Console.WriteLine(" x:{0}, y:{1}", x, y);

            Swap(x, y);

            Console.WriteLine(" x:{0}, y:{1}", x, y);
            Console.WriteLine(" 그 이유는 매개변수가 전달될때 \"변수안의 데이터값만\"을 복사해서 가져가 메소드를 실행하기 때문이다.");


            //참조에 의한 전달
            Console.WriteLine("\n** 참조에 의한 전달방식 **\n");
            Console.WriteLine(" 참조에의한 전달방식의 결과 x의값과 y의값은 Swap됨. \n");
            Console.WriteLine(" x:{0}, y:{1}", x, y);

            refSwap(ref x,ref y);

            Console.WriteLine(" x:{0}, y:{1}", x, y);
            Console.WriteLine(" 그 이유는 매개변수가 전달될때 \"원본변수의 주소값\"을 전달하기 때문에, 메소드가 실행되면 원본 매개변수안의 데이터가 변경된다.\n");


        }
    }

}
