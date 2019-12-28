using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_10_오버라이딩
{
   
        class ArmorSuite //부모클래스
        {
            public virtual void Initialize() //버츄얼로 선언
            {
                Console.WriteLine("Armored");
            }
        }

        class IronMan : ArmorSuite
        {
            public override void Initialize() //오버라이드 라는 한정자 사용
            {
                base.Initialize();
                Console.WriteLine("Repulsor Rays Armed");
            }
        }

        class WarMachine : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Double-Barrel Cannons Armed");
                Console.WriteLine("Micro-Rocket Launcher Armed");
            }
        }

        class MainApp
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Creating ArmorSuite...");
                ArmorSuite armorsuite = new ArmorSuite();
                armorsuite.Initialize();

                Console.WriteLine("\nCreating IronMan...");
                ArmorSuite ironman = new IronMan();
                ironman.Initialize();

                Console.WriteLine("\nCreating WarMaching...");
                ArmorSuite warmachine = new WarMachine();
                warmachine.Initialize();
            }
        }
    }


