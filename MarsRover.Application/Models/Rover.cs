using MarsRover.Application.Classes;
using MarsRover.Application.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Application.Models
{
    public class Rover : Abilities
    {
        public Plateau Plateau { get; set; }
        public Position Position { get; set; }
        public Directions Direction { get; set; }

        public Rover()
        {

        }
        public Rover(Plateau _Plateau, Position _Position, Directions _Direction)
        {
            Plateau = _Plateau;
            Position = _Position;
            Direction = _Direction;
        }

        public override void Do(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        break;
                }
            }
        }

        public override void TurnLeft()
        {
            if ((Direction - 1) < Directions.N)
            {
                Direction = Directions.W;
            }
            else
            {
                Direction = Direction - 1;
            }
        }

        public override void TurnRight()
        {
            if ((Direction + 1) > Directions.W)
            {
                Direction = Directions.N;
            }
            else
            {
                Direction = Direction + 1;
            }
        }

        public override void Move()
        {
            if (Direction == Directions.N)
            {
                Position.YCoordinate++;
            }
            else if (Direction == Directions.E)
            {
                Position.XCoordinate++;
            }
            else if (Direction == Directions.S)
            {
                Position.YCoordinate--;
            }
            else if (Direction == Directions.W)
            {
                Position.XCoordinate--;
            }
        }

        public override string FeedClient()
        {
            return string.Format("{0} {1} {2}", Position.XCoordinate, Position.YCoordinate, Direction);
        }
    }
}
