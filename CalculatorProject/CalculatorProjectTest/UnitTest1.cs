using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;




namespace CalkulyatorProj
{
    public class TestCalkulyator
    {



        [TestClass]
        public class CalkulyatorTest
        {

            public IWebDriver Driver { get; set; }
            public WebDriverWait Wait { get; set; }
            public Invoker invoker { get; set; }
            public CalkulyatorPage calkulpage { get; set; }




            [ClassInitialize]
            public static void SetupClass(TestContext testContext)
            {
                IWebDriver Driver = new ChromeDriver();
                WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
                CalkulyatorPage calkulpage = new CalkulyatorPage(Driver);

                calkulpage.Navigate();
                calkulpage.Init();

            }

            [TestInitialize]
            public void SetupTest()
            {
                this.invoker = new Invoker(calkulpage);
            }


            [TestMethod]
            public void TEST1()
            {

                Assert.AreEqual("9", invoker.GetResult("c 3 * 3 ="));
            }

            [TestMethod]
            public void TEST2()
            {

                Assert.AreEqual("2", invoker.GetResult("c 4 Sqrt"));
            }



            [TestMethod]
            public void TEST4()
            {
                Assert.AreEqual("3", invoker.GetResult("c 9 Sqrt"));
            }


        }
    }
}