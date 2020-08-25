using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Track
{
    class User
    {
        public void CreateTranslator(TranslatorFacade facade)
        {
            facade.TranslateUserWord();
            facade.AddTranslateToDictionary();
            facade.ShowAllWords();
        }
    }
}
