using System;

namespace Dev3
{
   public class TransliteManager /// Class which transliterates string from russian to latin and backward
    {
        string str;
        public string Translit(string str)  /// Method which transliterates string from russian to latin and backward
        {
            int NUMBEROFLETTER = 32;
            string[] lat_up = { "A", "B", "V", "G", "D", "E", "Yo", "Zh", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "Kh", "Ts", "Ch", "Sh", "Shch", "\"", "Y", "'", "E", "Yu", "Ya" };
            string[] lat_low = { "a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "shch", "\"", "y", "'", "e", "yu", "ya" };
            string[] rus_up = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
            string[] rus_low = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            for (int i = 0; i <= NUMBEROFLETTER; i++)
            {
                foreach (char ch in str)
                {
                    if ((ch > 64 && ch < 91) || (ch > 96 && ch < 123))
                    {

                        str = str.Replace(lat_up[i], rus_up[i]);
                        str = str.Replace(lat_low[i], rus_low[i]);
                    }
                    else
                    {

                        str = str.Replace(rus_up[i], lat_up[i]);
                        str = str.Replace(rus_low[i], lat_low[i]);


                    }

                }
            }
            return str;
        }
    }
}
