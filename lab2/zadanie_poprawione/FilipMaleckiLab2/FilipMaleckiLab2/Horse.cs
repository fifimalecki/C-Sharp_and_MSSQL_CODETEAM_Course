using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilipMaleckiLab2
{
    public class Horse : Creature, IMovable
    {
        /// <summary>
        /// Prędkość maksymalna konia
        /// </summary>
        static readonly int horseMaxSpeed = 42;
        /// <summary>
        /// Konstruktor bezargumentowy konia
        /// </summary>
        public Horse()
        {
            MaxSpeed = horseMaxSpeed;
        }
        /// <summary>
        /// Konstruktor argumentowy konia
        /// </summary>
        /// <param name="horseName">Nazwa konia</param>
        /// <param name="numberOfLegs">Liczba nóg konia</param>
        public Horse(string horseName, int numberOfLegs)
        {
            Name = horseName;
            NumberOfLegs = numberOfLegs;
            MaxSpeed = horseMaxSpeed;
        }
        /// <summary>
        /// Poruszanie się konia
        /// </summary>
        public void Move()
        {
            Console.WriteLine($"I'm gracefully running with speed {GetCurrentSpeed()}!");
        }

    }
}
