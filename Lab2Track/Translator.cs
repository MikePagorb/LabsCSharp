using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Track
{
    class Translator
    {
        public void TranslateWord(string InputWord, Dictionary<string,string> WordAndTranslate)
        {
            int counter = 0;
            foreach(var keyValue in WordAndTranslate)
            {
                if (keyValue.Key.ToString().Contains(InputWord))
                {
                    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
                    break;
                }
                else
                {
                    counter++;
                }
            }
            if(counter == WordAndTranslate.Count)
            {
                Console.WriteLine("Этого слова нет в словаре");
            }
        }
    }
}
