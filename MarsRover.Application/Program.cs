using MarsRover.Application.Enums;
using MarsRover.Application.Models;
using System;
using System.Collections.Generic;

namespace MarsRover.Application
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Write plateau width and height: (like 5-5)");
            var plateau = Console.ReadLine().Split("-");
            Console.WriteLine("How many rover do you have?");
            var roverCount = Convert.ToInt32(Console.ReadLine());
            List<Rover> roverList = new List<Rover>();
            for (int i = 0; i < roverCount; i++)
            {
                Console.WriteLine("Now, lets assign the " + i + ". rover's location: (1 2 N)");
                var roverLoc = Console.ReadLine().Split(" ");

                Console.WriteLine("Then, time to write " + i + ". Rover's move. Like ('LMLMLMLMM')");
                var roverMove = Console.ReadLine();

                Plateau plateauOne = new Plateau(new Position(Convert.ToInt32(plateau[0]), Convert.ToInt32(plateau[1])));
                Rover Rover = new Rover();
                switch (roverLoc[2])
                {
                    case "N":
                        Rover = new Rover(plateauOne, new Position(Convert.ToInt32(roverLoc[0]), Convert.ToInt32(roverLoc[1])), Directions.N);
                        Rover.Do(roverMove);
                        break;
                    case "W":
                        Rover = new Rover(plateauOne, new Position(Convert.ToInt32(roverLoc[0]), Convert.ToInt32(roverLoc[1])), Directions.W);
                        Rover.Do(roverMove);
                        break;
                    case "E":
                        Rover = new Rover(plateauOne, new Position(Convert.ToInt32(roverLoc[0]), Convert.ToInt32(roverLoc[1])), Directions.E);
                        Rover.Do(roverMove);
                        break;
                    case "S":
                        Rover = new Rover(plateauOne, new Position(Convert.ToInt32(roverLoc[0]), Convert.ToInt32(roverLoc[1])), Directions.S);
                        Rover.Do(roverMove);
                        break;
                }
                roverList.Add(Rover);

            }

            Console.WriteLine();
            Console.WriteLine("Rover's locations:");
            Console.WriteLine();

            foreach (var rover in roverList)
            {
                var index = roverList.FindIndex(x => x == rover);
                Console.WriteLine(+(index + 1) + ". roverın yeri: " + rover.FeedClient());
            }

            Console.ReadLine();
        }
    }
}
