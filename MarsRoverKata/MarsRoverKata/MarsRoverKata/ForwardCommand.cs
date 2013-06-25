using System;
using System.Collections.Generic;

namespace MarsRoverKata
{
    public class ForwardCommand
    {
        private readonly Rover rover;
        private readonly Grid grid;
        private readonly IDictionary<Direction, Action> directionMappings;

        public ForwardCommand(Rover rover, Grid grid)
        {
            this.rover = rover;
            this.grid = grid;

            directionMappings = new Dictionary<Direction, Action>
                {
                    {Direction.North, () => rover.CurrentLocation.IncreaseYCoordinate(grid.Height)},
                    {Direction.South, () => rover.CurrentLocation.DecreaseYCoordinate(grid.Height)},
                    {Direction.East, () => rover.CurrentLocation.IncreaseXCoordinate(grid.Width)},
                    {Direction.West, () => rover.CurrentLocation.DecreaseXCoordinate(grid.Width)},
                };
        }

        public void Move()
        {
            var action = directionMappings[rover.CurrentLocation.Direction];
            action();
        }
    }
}