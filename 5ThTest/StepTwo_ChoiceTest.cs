using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace StepTwoChoice
{
    public class StepTwoChoiceTest
    {
        protected IWebDriver driverTwo;

        [SetUp]
        public void Setup()
        {
            driverTwo = new ChromeDriver();
            driverTwo.Manage().Window.Maximize();
            driverTwo.Navigate().GoToUrl("https://ibis.net.ua/ua/products/poluavtomaticheskoe/search/");
        }

        [Test]
        public void VerifyHeaderText()
        {
            StepTwoPageSemiAuto.StepTwoSemiAuto stepTwoPageSemiAuto = new StepTwoPageSemiAuto.StepTwoSemiAuto(driverTwo);
            var actualHeaderText = stepTwoPageSemiAuto.GetHeaderText();
            var expectedHeaderText = "НАПІВАВТОМАТИЧНА ЗБРОЯ";

            Assert.That(expectedHeaderText, Is.EqualTo(actualHeaderText), "Тексти не співпадають");
        }

        [TearDown]
        public void TearDown()
        {
            driverTwo.Close();
        }
    }
}