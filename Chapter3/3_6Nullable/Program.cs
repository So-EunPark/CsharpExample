using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;

            Console.WriteLine(a.HasValue); //값을 갖고있는가? -> false출력
            Console.WriteLine(a != null);  //null이 아닌가? -> false출력(null이기 때문에)

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a);
        }
    }
}
