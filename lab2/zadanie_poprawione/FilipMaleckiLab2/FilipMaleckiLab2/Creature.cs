using System;

namespace FilipMaleckiLab2
{
    public abstract class Creature
    {
        /// <summary>
        /// Nazwa stworzenia
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Liczba nóg stworzenia
        /// </summary>
        public int NumberOfLegs { get; set; }
        /// <summary>
        /// Maksyalna prędkość stworzenia
        /// </summary>
        public int MaxSpeed { get; set; }
        /// <summary>
        /// Funkcja robiąca coś
        /// </summary>
        public virtual void DoSomething()
        {
            Console.WriteLine("I'm doing something.");
        }
        /// <summary>
        /// Funkcja zwracająca bieżącą prędkość stworzenia
        /// </summary>
        /// <returns>Bierząca prędkość</returns>
        protected double GetCurrentSpeed()
        {
            Random random = new Random();
            return random.NextDouble() * MaxSpeed;
        }
    }
}
