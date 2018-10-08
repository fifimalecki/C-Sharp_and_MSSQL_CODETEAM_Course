using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilipMaleckiLab2
{
    public class Horse : Creature, IMovable
    {
        static readonly int horseMaxSpeed = 42;



        public Horse()
        {
            MaxSpeed = horseMaxSpeed;
        }

        public Horse(string horseName, int numberOfLegs)
        {
            Name = horseName;
            NumberOfLegs = numberOfLegs;
            MaxSpeed = horseMaxSpeed;
        }

        public void Move()
        {
            Console.WriteLine($"I'm gracefully running with speed {GetCurrentSpeed()}!");
        }

    }
}
