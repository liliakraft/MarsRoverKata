using System;

namespace MarsRoverKata
{
    public class LeftCommand
    {
        private readonly Rover rover;

        public LeftCommand(Rover rover)
        {
            this.rover = rover;
        }

        public void Turn()
        {
            switch (rover.CurrentLocation.Direction)
            {
                case Direction.North:
                    rover.CurrentLocation.UpdateDirection(Direction.West);
                    break;
                case Direction.South:
                    rover.CurrentLocation.UpdateDirection(Direction.East);
                    break;
                case Direction.West:
                    rover.CurrentLocation.UpdateDirection(Direction.South);
                    break;
                case Direction.East:
                    rover.CurrentLocation.UpdateDirection(Direction.North);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}