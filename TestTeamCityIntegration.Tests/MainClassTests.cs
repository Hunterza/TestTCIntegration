using NUnit.Framework;

namespace TestTeamCityIntegration.Tests
{
    [TestFixture]
    public class MainClassTests
    {
        private MainClass manager;

        [SetUp]
        public void Setup()
        {
            manager = new MainClass();
        }

        [Test]
        public void Sum_Tests()
        {
            // Assert
            Assert.AreEqual(3, manager.Sum(1, 2));
        }
    }
}