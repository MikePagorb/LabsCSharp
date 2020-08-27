using System;

//Реалізувати завдання «Перекладач» з англійської мови на українську.
// Користувач вводить слово англійською мовою і в результаті отримує його переклад
//українською.Програмне забезпечення повинно мати можливість працювати зі словником
// раніше збережених слів (зберігати, завантажувати) з файлу.ПЗ повинно мати
// можливість додавати нові слова.

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
