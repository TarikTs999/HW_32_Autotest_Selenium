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


        [Test]
        public void VerifyHeaderText()
        {
            SearchPage searchPage = new SearchPage(driver);
            var actualHeaderText = searchPage.GetHeaderText();
            var expectedHeaderText = "Полуавтоматическое оружие модель оружия AR-15";

            Assert.That(expectedHeaderText, Is.EqualTo(actualHeaderText), "Тексти не співпадають");
        }

 
    }
}
