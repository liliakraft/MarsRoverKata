using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    public class TestForwardCommand
    {
        [TestCase(0, 0, Direction.North, 0, 1, Direction.North)]
        [TestCase(4, 8, Direction.South, 4, 7, Direction.South)]
        [TestCase(4, 8, Direction.East, 5, 8, Direction.East)]
        [TestCase(4, 8, Direction.West, 3, 8, Direction.West)]
        [TestCase(100, 100, Direction.North, 100, 0, Direction.North)]
        [TestCase(100, 0, Direction.South, 100, 100, Direction.South)]
        [TestCase(100, 0, Direction.East, 0, 0, Direction.East)]
        [TestCase(0, 0, Direction.West, 100, 0, Direction.West)]
        public void ShouldUpdateCoordinatesByOneAccordingly(int xCoordinate, int yCoordinate, Direction direction, int expectedXCoordinate, int expectedYCoordinate, Direction expectedDirection)
        {
            var rover = new Rover(new Location(xCoordinate, yCoordinate, direction), null);
            var expectedLocation = new Location(expectedXCoordinate, expectedYCoordinate, expectedDirection);
            var forwardCommand = new ForwardCommand(rover, new Grid(100,100));

            forwardCommand.Move();

            Assert.That(rover.CurrentLocation, Is.EqualTo(expectedLocation));
        }
    }
}