using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CalkulyatorProj
{

    public class CalkulyatorPage
    {
        readonly IWebDriver driver;
        private readonly string url = @"http://calkulyator.ru/";



        public CalkulyatorPage(IWebDriver browser)
        {
            this.driver = browser;
            this.driver.Manage().Window.Maximize();
            PageFactory.InitElements(browser, this);

        }

        static public Dictionary<string, IWebElement> buttons = new Dictionary<string, IWebElement>();
        static public Dictionary<string, By> knopki = new Dictionary<string, By>
        {
            {"+", By.Id("nmr_22")},
            {"-", By.Id("nmr_17")},
            {"*", By.Id("nmr_16")},
            {"/", By.Id("nmr_10")},
            {"=", By.Id("nmr_23")},
            {"0", By.Id("nmr_25")},
            {"1", By.Id("nmr_19")},
            {"2", By.Id("nmr_20")},
            {"3", By.Id("nmr_21")},
            {"4", By.Id("nmr_13")},
            {"5", By.Id("nmr_14")},
            {"6", By.Id("nmr_15")},
            {"7", By.Id("nmr_7")},
            {"8", By.Id("nmr_8")},
            {"9", By.Id("nmr_9")},
            {"%", By.Id("nmr_11")},
            {"xY", By.Id("nmr_5")},
            {"Sqrt", By.Id("nmr_4")},
            {"MC", By.Id("nmr_0")},
            {"MR", By.Id("nmr_1")},
            {"M+", By.Id("nmr_2")},
            {"M-", By.Id("nmr_3")},
            {"c", By.Id("nmr_24")},

            {"display", By.Id("display")}

        };

        public void Navigate()
        {
            this.driver.Navigate().GoToUrl(this.url);
        }
        public void Init()
        {
            //Dictionary<string, IWebElement> buttons = new Dictionary<string, IWebElement>();

            foreach (var button in knopki)
            {
                buttons.Add(button.Key, driver.FindElement(button.Value));
            }

        }
    }
}



