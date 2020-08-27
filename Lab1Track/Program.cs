using System;

//Необхідно реалізувати додаток, що дозволяє перетворювати текст в
//спеціальному дивному форматі в кілька(не менше двох) інших форматів.Наприклад,
//в html і markdown. Формат вихідного тексту.Текст складається з абзаців,
//розділених одним або декількома пустими рядками. Кожен абзац починається з
//ключового слова, за яким слід один пробіл.Далі йде смисловий текст.
//Ключові слова:
//p - звичайний текст.
//h1 - заголовок першого рівня.
//h2 - заголовок другого рівня.
//h3 - заголовок третього рівня.
//ordlist - нумерований список. Далі кожен рядок вважається одним елементом списку.Символи початкового рядка (яка містить ключове слово ordlist) ігноруються.
//bullist - маркований список.
//Абзаци, що починаються з невідомого ключового слова (або без ключового слова), не включаються до підсумкового текст.

namespace Lab1Track
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводить текст соответственно формату:\n" +
                "<par> - ключевое слово для абзаца\n" +
                "<Hd1>,<Hd2>,<Hd3>,<Hd4>,<Hd5>,<Hd6> - заголовки с 1 по 6 уровень\n" +
                "<Olist> - нумерованный список\n" +
                "<Blist> - маркированный список\n" +
                "Нажмите \"q\" чтобы выйти из списка\n" +
                "Введите \"translate\" чтобы перевести в другой формат\n");

            FormatDirector formatDirector = new FormatDirector();

            Console.WriteLine("Введите текст для перевода в формат HTML");
            FormatBuilder builderHTML = new HTMLFormatBuilder();
            TextFormat textFormatHTML = formatDirector.CreateFormatingText(builderHTML);
            Console.WriteLine();
            Console.WriteLine("Перевод в HTML: \n");
            Console.WriteLine(textFormatHTML.ToString());

            Console.WriteLine();

            Console.WriteLine("Введите текст для перевода в формат Markdown");
            FormatBuilder builderMark = new MarkdownFormatBuilder();
            TextFormat textFormatMark = formatDirector.CreateFormatingText(builderMark);
            Console.WriteLine();
            Console.WriteLine("Перевод в Markdown: \n");
            Console.WriteLine(textFormatMark.ToString());

        }
    }
}
