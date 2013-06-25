using NUnit.Framework;

namespace MarsRoverKata.Tests
{
    [TestFixture]
    public class TestGrid
    {
        [Test]
        public void ShouldSetSize()
        {
            var grid = new Grid(100, 100);
            Assert.That(grid.Width, Is.EqualTo(100));
            Assert.That(grid.Height, Is.EqualTo(100));
        }
    }
}
