using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle 
    {
        public bool HasTrunk { get; set; }

        public Car()
        {
            HasTrunk = true;
        }
        public override void DriveAbstract()
        {
            Console.WriteLine("Driving the car.");
        }
    }

}
