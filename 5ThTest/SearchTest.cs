using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HW_32_Autotest_Selenium_PageObjects;
using OpenQA.Selenium.DevTools.V119.CSS;

namespace _5ThTest
{
    public class SearchTest : MainTest
    {
        [Test]
        public void SearchForProduct()
        {
           
            SearchPage initPage = new SearchPage(driver);
            var searchPage = new SearchPage(driver);
            searchPage.PerformSearch("AR-15");

        }
<<<<<<< HEAD

        
=======
>>>>>>> eca910d9545db8a580dc1161f94c228dd64f862a
 
    }
}
