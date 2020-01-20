using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Application.Classes
{
    public abstract class Abilities
    {
        public abstract void Do(string commands);

        public abstract void TurnLeft();

        public abstract void TurnRight();

        public abstract void Move();

        public abstract string FeedClient();
    }
}
