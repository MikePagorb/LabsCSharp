using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Track
{
    class Spliter
    {
        public Dictionary<string, string> SplitDictionary (string WordsOfDictionary)
        {
            string [] pairsOfWords = WordsOfDictionary.Split(";", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> DcWords = new Dictionary<string, string>();
            string[] WordPlusTranslate;
            for(int i = 0; i < pairsOfWords.Length; i++)
            {
                WordPlusTranslate = pairsOfWords[i].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                DcWords.Add(WordPlusTranslate[0], WordPlusTranslate[1]);
            }
            return DcWords;
        }
    }
}
