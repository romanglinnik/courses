using System;

namespace hw1
{
    class Finder
    {
        static void Main()
        {
            string str = "asdfrtttsssssrtf";
            int count = 0; //counter
            char maxSymbol = ' ';
            char preSymbol = ' ';
            int maxNumberSymbols = 0;

            foreach (char ch in str) //checking symbol
            {
                foreach (char cha in str) // next checking symbol

                    if (cha == preSymbol && cha == ch)

                    {
                        count++;

                        if (maxNumberSymbols < count)
                        {
                            maxNumberSymbols = count;
                            maxSymbol = ch;
                        }
                    }

                    else
                    {
                        count = 0;
                    }

                count = 0;
                preSymbol = ch;
            }
            Console.WriteLine("Символ встречающийся максимальное колличество раз подрят {0} = {1}", maxSymbol, maxNumberSymbols);
        }
    }
}
