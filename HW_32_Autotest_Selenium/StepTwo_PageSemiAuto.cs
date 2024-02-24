using OpenQA.Selenium;
using StepTwoPageSemiAuto;

namespace StepTwoPageSemiAuto
{
    public class StepTwoSemiAuto : StepTwoMainPage
    {
        private IWebElement headerText => driverTwo.FindElement(By.XPath("//h1[@class='category_name category_name_inline']"));

        public StepTwoSemiAuto(IWebDriver driverTwo) : base(driverTwo)
        {
        }

        public string GetHeaderText()
        {
            Console.WriteLine($"headerText: {headerText}");
            Thread.Sleep(5000);
            return headerText.Text;
        }
    }
}
