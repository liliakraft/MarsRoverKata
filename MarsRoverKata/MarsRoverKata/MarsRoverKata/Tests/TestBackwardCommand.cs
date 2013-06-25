using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    public class TestBackwardCommand
    {
        [TestCase(Direction.North, 4, 8, Direction.North,4, 7)]
        [TestCase(Direction.South, 4, 8,  Direction.South,4, 9)]
        [TestCase(Direction.East,4, 8,  Direction.East, 3, 8)]
        [TestCase(Direction.West,4, 8, Direction.West,5, 8)]
        [TestCase(Direction.North,0,0,Direction.North,0,100)]
        [TestCase(Direction.South,0,100,Direction.South,0,0)]
        [TestCase(Direction.East,0,0,Direction.East,100,0)]
        [TestCase(Direction.West,100,0,Direction.West,0,0)]
        public void ShouldUpdateCoordinatesByOneAccordingly(Direction initialDirection, int initialXCoordinate, int initialYCoordinate, Direction expectedDirection, int expectedXCoordinate, int expectedYCoordinate)
        {
            var expectedLocation = new Location(expectedXCoordinate,expectedYCoordinate,expectedDirection);
            var rover = new Rover(new Location(initialXCoordinate, initialYCoordinate, initialDirection), null);
            var backwardCommand = new BackwardCommand(rover, new Grid(100,100));

            backwardCommand.Move();
            
            Assert.That(rover.CurrentLocation, Is.EqualTo(expectedLocation));
        }
    }
}
