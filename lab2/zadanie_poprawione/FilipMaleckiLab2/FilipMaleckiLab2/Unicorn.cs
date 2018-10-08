using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilipMaleckiLab2
{
    public class Unicorn : Horse
    {
        /// <summary>
        /// Maksymalna prędkość jednorożca
        /// </summary>
        static readonly int unicornMaxSpeed = 420;
        /// <summary>
        /// Kolor cekinów jednorożca
        /// </summary>
        public string ColorOfSequins { get; set; }
        /// <summary>
        /// Zmienna przechowująca informacje czy jednorożec posiada róg czy nie
        /// </summary>
        public bool Corner { get; set; }
        /// <summary>
        /// Konstruktor bezargumentowy jednorożca
        /// </summary>
        public Unicorn()
        {
            MaxSpeed = unicornMaxSpeed;
        }
        /// <summary>
        /// Konstruktor argumentowy jednorożca
        /// </summary>
        /// <param name="horseName">Nazwa jednorożca</param>
        /// <param name="numberOfLegs">Liczba nóg jednorożca</param>
        /// <param name="colorOfSequins">Kolor cekinów jednorożca</param>
        /// <param name="corner">Posiadanie przez jednorożca rogu</param>
        public Unicorn(string horseName, int numberOfLegs, string colorOfSequins, bool corner)
            : base(horseName, numberOfLegs)
        {
            ColorOfSequins = colorOfSequins;
            Corner = corner;
            MaxSpeed = unicornMaxSpeed;
        }
        /// <summary>
        /// Funkcja chodzenia po tęczy
        /// </summary>
        public void RunAlongTheRainbow()
        {
            Console.WriteLine("I'm walking on the rainbow!");
        }
        
    }
}
