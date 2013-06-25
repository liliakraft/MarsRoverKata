using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    public class TestRightCommand
    {
        [TestCase(Direction.East, Direction.North)]
        [TestCase(Direction.South, Direction.East)]
        [TestCase(Direction.West, Direction.South)]
        [TestCase(Direction.North, Direction.West)]
        public void ShouldChangeDirectionAccordingly(Direction expectedDirection, Direction initialDirection)
        {
            var rover = new Rover(new Location(0,0, initialDirection), null);
            var expectedLocation = new Location(0, 0, expectedDirection);
            var rightCommand = new RightCommand(rover);

            rightCommand.Turn();

            Assert.That(rover.CurrentLocation, Is.EqualTo(expectedLocation));
        }
    }
}
