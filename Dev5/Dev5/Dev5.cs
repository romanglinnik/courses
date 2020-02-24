using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Dev5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Go to Yandex to send message to Mail

            IWebDriver driver1 = new ChromeDriver();

            driver1.Navigate().GoToUrl("https://passport.yandex.by/auth/add?origin=home_desktop_by&retpath=https%3A%2F%2Fmail.yandex.by%2F&backpath=https%3A%2F%2Fyandex.by");

            var wait1 = new WebDriverWait(driver1, new TimeSpan(0, 0, 30));

            var loginYandex = wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("passp-field-login")));

            loginYandex.SendKeys("dev5.dev5" + Keys.Enter);

            var passwordYandex = wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("passp-field-passwd")));

            passwordYandex.SendKeys("password123" + Keys.Enter);

            var newMessageLog = wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("mail-ComposeButton-Text")));

            newMessageLog.Click();

            var sendTo = wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='js-compose-field mail-Bubbles']")));

            sendTo.SendKeys("webdriverdev4@mail.ru");

            var sendText = wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='cke_wysiwyg_div cke_reset cke_enable_context_menu cke_editable cke_editable_themed cke_contents_ltr cke_show_borders']")));

            sendText.SendKeys("reply" + (Keys.Control + Keys.Enter));



            

            //Go to mail to reply Yandex message

            IWebDriver driver2 = new ChromeDriver();

            driver2.Manage().Window.Maximize();

            driver2.Navigate().GoToUrl("https://mail.ru/");


            var wait2 = new WebDriverWait(driver2, new TimeSpan(0, 0, 30));

            var loginMail = wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mailbox:login")));           

            loginMail.SendKeys("webdriverdev4" + Keys.Enter);

            var passwordMail = wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mailbox:password")));           

            passwordMail.SendKeys("246_531" + Keys.Enter);

            var replyMessageLog = wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='llc__item llc__item_date']")));

            replyMessageLog.Click();

            var reply = wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@title='Ответить']")));

            reply.Click();

            var replyText = wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("cke_widget_editable")));

            replyText.SendKeys("Hi HI hI" + (Keys.Control + Keys.Enter));

            driver2.Quit();

            //Go to Yandex to watch is message sended and check the time     

            var refresh = wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='mail-ComposeButton js-main-action-compose']")));

            refresh.SendKeys(Keys.F9);

            var messageTime = wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("mail-MessageSnippet-Item_dateText")));

            Console.WriteLine(messageTime.Text);

            driver1.Quit();

        }
    }
}
