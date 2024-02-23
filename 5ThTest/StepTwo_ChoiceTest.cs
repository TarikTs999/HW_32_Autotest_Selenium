using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepTwoPageSemiAuto;


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
                    StepTwoPageSemiAuto stepTwoPageSemiAuto = new StepTwoPageSemiAuto(driverTwo);
                    var actualHeaderText = stepTwoPageSemiAuto.GetHeaderText();
                    var expectedHeaderText = "Полуавтоматическое оружие модель оружия AR-15";

                    Assert.That(expectedHeaderText, Is.EqualTo(actualHeaderText), "Тексти не співпадають");
             }

             [TearDown]
             public void TearDown()
             {
                driverTwo.Close();
             }
        
    }
}
