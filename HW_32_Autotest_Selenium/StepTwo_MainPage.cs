using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StepTwoPageSemiAuto;

namespace StepTwoPageSemiAuto
{
    public class StepTwoMainPage
    {
        protected static IWebDriver driverTwo;


        public StepTwoMainPage(IWebDriver driverTwo)
        {
            StepTwoMainPage.driverTwo = driverTwo;
        }
    }
}
