using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowsFormsApp1.Tests
{
    [TestFixture]
    public class EbaySearcherTests
    {
        private IWebDriver driver;
        private EbaySearcher searcher;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            searcher = new EbaySearcher();
        }

        [Test]
        public void Test1_field()
        {
            searcher.OpenHomePage();
            IWebElement searchBox = driver.FindElement(By.Id("gh-ac"));
            Assert.IsNotNull(searchBox);
        }cd

        [Test]
        public void Test2_search()
        {
            searcher.OpenHomePage();
            IWebElement searchButton = driver.FindElement(By.Id("gh-btn"));
            Assert.IsNotNull(searchButton);
        }

        [TearDown]
        public void TearDown()
        {
            searcher.Close();
            driver.Quit();
        }
    }
}
