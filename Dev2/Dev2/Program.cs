using System;

namespace Dev2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            myString = Console.ReadLine();
            String str = new String(myString);
            Console.WriteLine(str.GetMaximumNumberOfUnequalConsecutiveCharactersInAString(myString));
            Console.WriteLine(str.GetMaximumNumberOfIdenticalConsecutiveDigitsInAString(myString));
            Console.WriteLine(str.GetMaximumNumberOfIdenticalConsecutiveLatinCharactersInAString(myString));
        }
    }
}
