using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    public class TestLeftCommand
    {
        [TestCase(Direction.North, Direction.West)]
        [TestCase(Direction.West, Direction.South)]
        [TestCase(Direction.South, Direction.East)]
        [TestCase(Direction.East, Direction.North)]
        public void ShouldChangeDirectionAccordingly(Direction initialDirection, Direction expectedDirection)
        {
            var rover = new Rover(new Location(1,1, initialDirection), null);
            var expectedLocation = new Location(1,1, expectedDirection);
            var leftCommand = new LeftCommand(rover);
            
            leftCommand.Turn();
            
            Assert.That(rover.CurrentLocation, Is.EqualTo(expectedLocation));
        }
    }
}
