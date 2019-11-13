using System;
using System.Collections.Generic;
using System.Text;

namespace StringProj
{
    class MyString
    {
        string str;

        public MyString(string str)
        {
            this.str = str;

        }
        public void AllRussian(string str)
        {
            foreach (char element in str)
            {
                if (element < 'А' || element > 'я')
                {

                    throw new AllLetterIsRussian("Exception");
                }
            }
        }
    }
    public static class StringExtension
    {
        public static int CharCountVowels(this string str, string vowels)
        {
            int count1 = 0;
            for (int i = 0; i < str.Length; ++i)
                for (int j = 0; j < vowels.Length; ++j)
                    if (str[i] == vowels[j])
                        count1++;
            return count1;
        }
        public static int CharCountConsonats(this string str, string consonants)
        {
            int count2 = 0;
            for (int i = 0; i < str.Length; ++i)
                for (int j = 0; j < consonants.Length; ++j)
                    if (str[i] == consonants[j])
                        count2++;
            return count2;

        }
    }
    public static class Revers
    {
        public static StringBuilder Reverse(this string str)
        {
            StringBuilder sb = new StringBuilder(str.Length);
            for (int i = 0; i < sb.Capacity; i++)
                sb.Insert(0, str[i]);
            return sb;
        }
    }
}

