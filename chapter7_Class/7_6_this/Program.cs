﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_6_this
{
    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
            //필드네임 = 네임매개변수

        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tigger = new Employee();
            tigger.SetName("tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");

        }
    }
}
