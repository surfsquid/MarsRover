using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau marsPlateau = new Plateau();
            while (!marsPlateau.IsInitialized)
            {
                Console.WriteLine("Enter plateau size:");
                string plateauInput = Console.ReadLine();
                Console.WriteLine(marsPlateau.Initialize(plateauInput));
            }

            bool gettingRovers = true;

            while (gettingRovers)
            {
                Console.WriteLine("Enter rover position:");
                string positionInput = Console.ReadLine();
                Console.WriteLine("Enter Rover instructions:");
                string instructionInput = Console.ReadLine();
                Rover rover = new Rover();
                if (rover.Initialize(positionInput, instructionInput))
                {
                    marsPlateau.Rovers.Add(rover);
                }
                Console.WriteLine("Add another rover? (enter Y to add another, anything else to finish)");
                string addAnother = Console.ReadLine();
                if (addAnother.ToUpper() != "Y")
                {
                    gettingRovers = false;
                }
            }

            foreach (Rover rover in marsPlateau.Rovers)
            {
                rover.Move();
                Console.WriteLine(rover.GetLocation());
            }

            Console.ReadLine(); 
        }
    }
}
