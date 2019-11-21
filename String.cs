

namespace Dev2
{
    public class String
    {
        string myString;
        public String(string myString)
        {
            this.myString = myString;
        }
        public int GetMaximumNumberOfUnequalConsecutiveCharactersInAString(string myString)
        {
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < myString.Length - 1; i++)
            {
                if (myString[i] != myString[i + 1])
                {
                    count++;
                }
                else if (count > maxCount)
                {
                    maxCount = count;
                }
                else count = 0;
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            return ++maxCount;
        }
        public int GetMaximumNumberOfIdenticalConsecutiveDigitsInAString(string myString)
        {
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < myString.Length - 1; i++)
            {
                if (myString[i] == myString[i + 1]  && (myString[i] > 47 && myString[i] < 58))
                {
                    count++;
                }
                else if (count > maxCount)
                {
                    maxCount = count;
                }
                else count = 0;
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            return ++maxCount;
        }
        public int GetMaximumNumberOfIdenticalConsecutiveLatinCharactersInAString(string myString)
        {
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < myString.Length - 1; i++)
            {
                if (myString[i] == myString[i + 1] && (myString[i] > 96 && myString[i] < 122))
                {
                    count++;
                }
                else if (count > maxCount)
                {
                    maxCount = count;
                }
                else count = 0;
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            return ++maxCount;
        }
    }
}