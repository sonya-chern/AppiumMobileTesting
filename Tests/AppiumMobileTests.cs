using AppiumMobileTestProject.DriverUtils;

namespace AppiumMobileTestProject.Tests
{
    public class AppiumMobileTests
    {
        [SetUp]
        public void Setup()
        {
            AppiumDriver.Instance.Quit();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}