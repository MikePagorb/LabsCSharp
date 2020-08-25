using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab2Track
{
    class Dictionary
    {
        public string ReadDictionary()
        {
            string path = @"E:\Visual Studio saves\LabsCSharp\Lab2Track\Dictionary\Dictionary.txt";
            string WordsOfDictionary = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    WordsOfDictionary = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return WordsOfDictionary;
        }

        public void AddNewWordsToDictionary()
        {
            string writePath = @"E:\Visual Studio saves\LabsCSharp\Lab2Track\Dictionary\Dictionary.txt";
            string newEngWord = "";
            string newTranslate = "";
            try
            {
                
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    string check = "";
                    while(check != "n") 
                    {

                        Console.WriteLine("Введите новое слово на английском:");
                        newEngWord = Console.ReadLine();
                        Console.WriteLine("Введите перевод:");
                        newTranslate = Console.ReadLine();
                        sw.Write("\n" + newEngWord + " - " + newTranslate +";");
                        Console.Write("Хотите добавить ещё перевод?(y - да, n - нет): ");
                        check = Console.ReadLine();
                    }

                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
