using HW_32_Autotest_Selenium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW_32_Autotest_Selenium_PageObjects
{
    public class SearchPage : MainPageObject
    {
        public SearchPage(IWebDriver driver) : base(driver) { }

        private IWebElement searchField => driver.FindElement(By.XPath("//input[@type='text']"));
        
        
        public void PerformSearch(string searchTerm)
        {

            searchField.Click();
            Thread.Sleep(5000);
            searchField.SendKeys(searchTerm);
            searchField.Submit();
            Thread.Sleep(5000);

        }
        public void OpenSearchPage() { }
        

    }
}
