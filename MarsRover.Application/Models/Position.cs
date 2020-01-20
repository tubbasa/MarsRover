using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Application.Models
{
    public class Position
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Position(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }
    }
}
