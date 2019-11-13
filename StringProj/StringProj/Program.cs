using System;
using System.Text;

namespace StringProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "ёуеыаоэяию";//гласные
            string consonants = "цкнгшщзхфвпрлджчсмтб";//согласные
            string a = "бац";
            int x = a.CharCountConsonats(consonants);
            int y = a.CharCountVowels(vowels);
            Console.WriteLine(x);
            Console.WriteLine(y);
            StringBuilder m = a.Reverse();
            Console.WriteLine(m);
           
            try
            {
                MyString str = new MyString(a);
                str.AllRussian(a);
            }
            catch (AllLetterIsRussian ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
