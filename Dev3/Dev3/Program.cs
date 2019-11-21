using System;

namespace Dev3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            myString = Console.ReadLine();
            TransliteManager str = new TransliteManager(myString);
            Console.WriteLine(str.Translit(myString));
        }
    }
}
