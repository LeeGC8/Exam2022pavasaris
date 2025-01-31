using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace WindowsFormsApp1
{
    public class EbaySearcher
    {
        private IWebDriver driver;

        public EbaySearcher()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://www.ebay.com");
        }

        public void Search(string searchTerm)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement searchBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("gh-ac")));
            searchBox.SendKeys(searchTerm);

            IWebElement searchButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@id='gh-btn']")));
            searchButton.Click();
        }

        public string GetSearchResultUrl()
        {
            return driver.Url;
        }

        public void NavigateBack()
        {
            driver.Navigate().Back();
        }

        public void Close()
        {
            driver.Quit();
        }
    }
}
