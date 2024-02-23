using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepTwoPageSemiAuto;


namespace StepTwoPageSemiAuto
{
    
    public class StepTwoPageSemiAuto : StepTwoMainPage
    {
        public StepTwoPageSemiAuto(IWebDriver driverTwo) : base(driverTwo) { }
        private IWebElement headerText => driverTwo.FindElement(By.XPath("//h1[@class='category_name category_name_inline']"));
        private IWebDriver driverTwo;

        public StepTwoPageSemiAuto(IWebDriver driverTwo)
        {
            this.driverTwo = driverTwo;
        }

        public string GetHeaderText()
        {
            Console.WriteLine($"headerText: {headerText}");
            return headerText.Text;
        }
    }
}
