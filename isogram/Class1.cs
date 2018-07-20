using System;
using System.Collections.Generic;

namespace isogram
{
    public class Class1
    {
        public static bool CheckIsogram(string text)
        {
            HashSet<char> letters = new HashSet<char>();
            int symbolsCount = 0;
            foreach (char character in text)
            {
                if(!('a' <= character && character <= 'z') || ('A' <= character && character <= 'Z'))
                {
                    symbolsCount++;
                    continue;
                }
                letters.Add(character);
            }
            if ((letters.Count + symbolsCount) != text.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool isogram(string v)
        {
            throw new NotImplementedException();
        }
    }
}
