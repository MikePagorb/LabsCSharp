using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Track
{
    class Paragraph
    {
        public string TypeOfParagraph { get; set; }
    }
    class Header
    {
        public string HeaderFirstLevel { get; set; }
        public string HeaderSecondLevel { get; set; }
        public string HeaderThirdLevel { get; set; }
        public string HeaderFourthLevel { get; set; }
        public string HeaderFifthLevel { get; set; }
        public string HeaderSixthLevel { get; set; }

    }

    class OrderList
    {
        public string TypeOfOrderList { get; set; }
    }

    class BulletedList
    {
        public string TypeOfBulletedList { get; set; }
    }
    class TextFormat
    {
        public UserText Text { get; set; }
        public Paragraph Paragraph { get; set; }
        public Header Header { get; set; }
        public OrderList OrderList { get; set; }
        public BulletedList BulletedList { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Paragraph != null)
                sb.Append(Paragraph.TypeOfParagraph +);
            if (Salt != null)
                sb.Append("Соль \n");
            if (Additives != null)
                sb.Append("Добавки: " + Additives.Name + " \n");
            return sb.ToString();
        }
    }
}
