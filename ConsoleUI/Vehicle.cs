using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2021";
        public string Make { get; set; } = "Generic";
        public string Model { get; set; } = "Generic";

        public Vehicle()
        {
            Year = "Unknown";
            Make = "Unknown";
            Model = "Unknown";
        }
        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is virtual method in Vehicle class");
        }
    }
}
