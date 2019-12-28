using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_12_오버라이딩봉인
{
    class Base
    {
        public virtual void SealMe()
        {
        }
    }

    class Derived : Base
    {
        public sealed override void SealMe()
        {
        }
    }

    class WantToOverride : Derived
    {
        public override void SealMe() //컴파일 하지 않아도 오류
        {
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
        }
    }
}
