using System;

namespace Lab2Track
{
    class Program
    {
        static void Main(string[] args)
        {
            Translator translator = new Translator();
            Dictionary dictionary = new Dictionary();
            Spliter spliter = new Spliter();
            UI ui = new UI();

            TranslatorFacade translateEnvironment = new TranslatorFacade(dictionary, translator, spliter, ui);

            User user = new User();
            user.CreateTranslator(translateEnvironment);

        }
    }
}
