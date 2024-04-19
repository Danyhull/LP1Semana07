﻿using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(2, 7, 1),
                new MilitaryUnit(1, 3, 2),
                new MilitaryUnit(13, 4, 23),
                new SettlerUnit(),
            };

            

            (units[0] as MilitaryUnit).Attack(units[1]);
            (units[1] as MilitaryUnit).Attack(units[3]);

            foreach (Unit u in units)
            {                
                
                Console.WriteLine($" {u} movement- {u.Move()}");
            }
        }
    }
}