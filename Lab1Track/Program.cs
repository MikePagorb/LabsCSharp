using System;

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
            Console.WriteLine(textFormatHTML.ToString());

            Console.WriteLine();

            Console.WriteLine("Введите текст для перевода в формат Markdown");
            FormatBuilder builderMark = new MarkdownFormatBuilder();
            TextFormat textFormatMark = formatDirector.CreateFormatingText(builderMark);
            Console.WriteLine();
            Console.WriteLine(textFormatMark.ToString());

        }
    }
}
