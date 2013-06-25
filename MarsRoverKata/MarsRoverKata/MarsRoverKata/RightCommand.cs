using System;

namespace MarsRoverKata
{
    public class RightCommand
    {
        private readonly Rover rover;

        public RightCommand(Rover rover)
        {
            this.rover = rover;
        }

        public void Turn()
        {
            var currentDirection = rover.CurrentLocation.Direction;
            switch (currentDirection)
            {
                case Direction.North:
                    rover.CurrentLocation.UpdateDirection(Direction.East);
                    break;
                case Direction.East:
                    rover.CurrentLocation.UpdateDirection(Direction.South);
                    break;
                case Direction.South:
                    rover.CurrentLocation.UpdateDirection(Direction.West);
                    break;
                case Direction.West:
                    rover.CurrentLocation.UpdateDirection(Direction.North);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}