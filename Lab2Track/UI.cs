using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Track
{
    class UI
    {
        public void Input()
        {
            Console.WriteLine("Введите слово для перевода:");
        }
        public void InputQuestion()
        {
            Console.WriteLine("Хотите перевести слово?(y - да, n - нет)");
        }

        public void AddWordUi()
        {
            Console.WriteLine("Чтобы завершить запись нажмите \"q\"");
            Console.WriteLine("Записываю новые слова:");
        }
        public void AddWordQuestion()
        {
            Console.WriteLine("Хотите добавить слово в словарь?(y - да, n - нет)");
        }
        public void AllWordsUi()
        {
            Console.WriteLine("Все слова в словаре:");
        }
        public void AllWordsQuestion()
        {
            Console.WriteLine("Хотите все слова в словаре?(y - да, n - нет)");
        }
    }
}
