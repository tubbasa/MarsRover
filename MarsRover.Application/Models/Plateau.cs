using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Application.Models
{
    public class Plateau
    {
        public Position PositiononPlateau { get; private set; }

        public Plateau(Position position)
        {
            PositiononPlateau = position;
        }
    }
}
