using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _5ThTest
{
    public class MainTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ibis.net.ua/");
        }

        [TearDown] 
        public void TearDown() 
        {
            driver.Close();
        }
    }
}