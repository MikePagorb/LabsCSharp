using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Track
{
    class TranslatorFacade
    {
        Dictionary dictionary;
        Translator translator;
        Spliter spliter;
        UI ui;
        
        public TranslatorFacade(Dictionary dc, Translator tr, Spliter sp, UI ui)
        {
            this.dictionary = dc;
            this.translator = tr;
            this.spliter = sp;
            this.ui = ui;
        }

        public void TranslateUserWord()
        {
            ui.InputQuestion();
            string question = Console.ReadLine();
            if (question == "y")
            {
                ui.Input();
                translator.TranslateWord(Console.ReadLine(), spliter.SplitDictionary(dictionary.ReadDictionary()));
            }
        }

        public void AddTranslateToDictionary()
        {
            ui.AddWordQuestion();
            string question = Console.ReadLine();
            if (question == "y")
            {
                ui.AddWordUi();
                dictionary.AddNewWordsToDictionary();
            }
        }

        public void ShowAllWords()
        {
            ui.AllWordsQuestion();
            string question = Console.ReadLine();
            if (question == "y")
            {
                ui.AllWordsUi();
                Console.WriteLine(dictionary.ReadDictionary());
            }
        }
    }
}
