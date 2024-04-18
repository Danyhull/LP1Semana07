using System;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public int Health { get; set; }
        public abstract float Cost { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine($"A unit with {movement} movement has moved.");
        }
    }
}
