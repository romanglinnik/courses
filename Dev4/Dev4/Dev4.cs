using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Dev4
{
    class NumberOfUnreadMessages //This class shows the number of undread messages on mail.ru account
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://mail.ru/");

            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));

            var element1 = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("mailbox:login")));

            IWebElement login = driver.FindElement(By.Id("mailbox:login"));

            login.SendKeys("webdriverdev4" + Keys.Enter);

            var element2 = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("mailbox:password")));

            IWebElement password = driver.FindElement(By.Id("mailbox:password"));

            password.SendKeys("246_531" + Keys.Enter);

            var element3 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[6]/div/div[1]/div[1]/div/div[2]/div[1]/div/div/div[1]/div[2]/div/div[1]/nav/a[1]/div/div[3]/span/span")));

            var unreadmessage = driver.FindElement(By.XPath("/html/body/div[6]/div/div[1]/div[1]/div/div[2]/div[1]/div/div/div[1]/div[2]/div/div[1]/nav/a[1]/div/div[3]/span/span"));

            Console.WriteLine(unreadmessage.GetAttribute("innerText"));

            driver.Quit();
        }

    }
}
