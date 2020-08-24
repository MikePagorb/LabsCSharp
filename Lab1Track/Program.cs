using System;

namespace Lab1Track
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            UserText userText = new UserText(Console.ReadLine());
            //Console.WriteLine(userText.HeaderText.TextOfHeader1);
            Console.WriteLine(userText.ParagraphText.TextOfParagraph);

        }
    }
}
