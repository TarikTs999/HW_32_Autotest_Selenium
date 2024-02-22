﻿using HW_32_Autotest_Selenium;
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
        //private IWebElement searchNatoRem => driver.FindElement(By.XPath("//a[@class='adv_search_variant_name' and @href='/ua/products/poluavtomaticheskoe/search/223-rem-sw8/']"));

        private IWebElement headerText = driver.FindElement(By.XPath("//h1[@class='category_name category_name_inline']"));

        public void PerformSearch(string searchTerm)
        {

            searchField.Click();
            Thread.Sleep(5000);
            searchField.SendKeys(searchTerm);
            searchField.Submit();
            Thread.Sleep(5000);

        }

        public string GetHeaderText()
        {
            Console.WriteLine($"headerText: {headerText}");
            return headerText.Text;
        }
        public void OpenSearchPage() { }

        


    }
}
