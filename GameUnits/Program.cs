using System;

namespace TestGameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the required arguments.");
                return;
            }

            try
            {
                // Test SettlerUnit
                SettlerUnit settler = new SettlerUnit();
                string settlerMoveResult = settler.Move();
                Console.WriteLine($"SettlerUnit: {settlerMoveResult}, Health: {settler.Health}, Cost: {settler.Cost}");

                // Test MilitaryUnit
                MilitaryUnit military = new MilitaryUnit(1, 3, 5);
                string militaryMoveResult = military.Move();
                Console.WriteLine($"MilitaryUnit: {militaryMoveResult}, Health: {military.Health}, Cost: {military.Cost}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}