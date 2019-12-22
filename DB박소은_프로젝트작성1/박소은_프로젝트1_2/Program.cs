using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 박소은_프로젝트1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int kor, eng, math, scty, sci, total;
            double avg;
            string gp;

            Console.Write("국어점수를 입력하시오. (0~100사이의 정수를 입력하세요): ");
            kor = int.Parse(Console.ReadLine());
            Console.Write("영어점수를 입력하시오. (0~100사이의 정수를 입력하세요): ");
            eng = int.Parse(Console.ReadLine());
            Console.Write("수학점수를 입력하시오. (0~100사이의 정수를 입력하세요): ");
            math = int.Parse(Console.ReadLine());
            Console.Write("사회점수를 입력하시오. (0~100사이의 정수를 입력하세요): ");
            scty = int.Parse(Console.ReadLine());
            Console.Write("과학점수를 입력하시오. (0~100사이의 정수를 입력하세요): ");
            sci = int.Parse(Console.ReadLine());

            total = kor + eng + math + scty + sci;
            avg = total / 5.0;

            switch ((int)avg/10)
            {
                case 10:
                    gp="A+";
                    break;
                case 9:
                    gp = "A";
                    break;
                case 8:
                    gp = "B";
                    break;
                case 7:
                    gp = "C";
                    break;
                case 6:
                    gp = "D";
                    break;
                default:
                    gp = "F";
                    break;
            }

            Console.WriteLine("평균점수:{0}\t 학점:{1}\t",avg, gp);

        }
    }
}
