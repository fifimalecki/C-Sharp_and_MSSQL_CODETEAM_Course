using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilipMaleckiLab2
{
    public class Unicorn : Horse
    {
        static readonly int unicornMaxSpeed = 420;

        protected string ColorOfSequins { get; set; }
        public bool Corner { get; set; }

        public Unicorn()
        {
            MaxSpeed = unicornMaxSpeed;
        }

        public Unicorn(string horseName, int numberOfLegs, string colorOfSequins, bool corner)
            : base(horseName, numberOfLegs)
        {
            ColorOfSequins = colorOfSequins;
            Corner = corner;
            MaxSpeed = unicornMaxSpeed;
        }

        public void RunAlongTheRainbow()
        {
            Console.WriteLine("I'm walking on the rainbow!");
        }
        
    }
}
