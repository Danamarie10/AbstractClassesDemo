using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle

    {
        public bool HasSideCart { get; set; }

        public Motorcycle() 
        {
            HasSideCart = false;
        }
        public override void DriveAbstract()
        {
            Console.WriteLine("Driving the motorcycle. ");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Driving the motorcycle with an override");
        }
    }
}
