using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11_로컬함수
{
    class Program
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }
            //입력받은 string을 한자씩 한자씩 아스키값을 가지고 대문자를 소문자로 변경
            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) //
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }
    

    
        static void Main(string[] args)
        {

            Console.WriteLine(ToLowerString("Hello"));
            Console.WriteLine(ToLowerString("GOOD MORNING"));
            Console.WriteLine(ToLowerString("This is C#"));
            
        }
    }
}
