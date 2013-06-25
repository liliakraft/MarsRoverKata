using System;
using System.Collections.Generic;

namespace MarsRoverKata
{
    public class BackwardCommand
    {
        private readonly Rover rover;
        private readonly Grid grid;
        private readonly IDictionary<Direction, Action> directionMapping;

        public BackwardCommand(Rover rover, Grid grid)
        {
            this.rover = rover;
            this.grid = grid;
            directionMapping = new Dictionary<Direction, Action>
                                   {
                                       {Direction.North, () => rover.CurrentLocation.DecreaseYCoordinate(grid.Height)},
                                       {Direction.South, () => rover.CurrentLocation.IncreaseYCoordinate(grid.Height)},
                                       {Direction.East, () => rover.CurrentLocation.DecreaseXCoordinate(grid.Width)},
                                       {Direction.West, () => rover.CurrentLocation.IncreaseXCoordinate(grid.Width)},
                                   };
        }

        public void Move()
        {
            var action = directionMapping[rover.CurrentLocation.Direction];
            action();
        }
    }
}