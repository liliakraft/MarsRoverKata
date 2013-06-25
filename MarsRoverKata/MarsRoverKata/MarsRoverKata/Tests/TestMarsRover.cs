using Moq;
using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    public class TestMarsRover
    {
        private Mock<IAmCommandController> commandController;

        [SetUp]
        public void SetUp()
        {
            commandController = new Mock<IAmCommandController>();
        }

        [Test]
        public void RoverShouldHaveAInitialLocation()
        {
            var location = new Location(0,0,Direction.North);
            var rover = new Rover(new Location(0,0,Direction.North), commandController.Object);
            Assert.That(rover.CurrentLocation, Is.EqualTo(location));
        }

        [Test]
        public void RoverShouldBeAbleToReceiveArrayOfCommands()
        {
            var commands = new[] { 'r', 'b'};
            var rover = new Rover(new Location(1, 2, Direction.South), commandController.Object);
            rover.Move(commands);

            commandController.Verify(c => c.ParseCommands(commands), Times.Once());
        }
    }
}
