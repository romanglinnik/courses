using System;


namespace CalkulyatorProj
{
    public class Invoker
    {

        CalkulyatorPage calkulyator { get; set; }


        public Invoker(CalkulyatorPage calkulyator)
        {
            this.calkulyator = calkulyator;


        }


        public string GetResult(string str)
        {
            string[] ButtonsNames = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ButtonsName in ButtonsNames)
            {
                CalkulyatorPage.buttons[ButtonsName].Click();

            }
            return CalkulyatorPage.buttons["display"].Text;


        }
    }
}
