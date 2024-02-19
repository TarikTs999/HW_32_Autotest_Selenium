using OpenQA.Selenium;

namespace HW_32_Autotest_Selenium
{
    public class MainPageObject
    {
        
        protected static IWebDriver driver;


        public MainPageObject(IWebDriver driver)
        {
            MainPageObject.driver = driver;
        }
        
    }
}
