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

            if (Text.ParagraphText != null && Paragraph != null)
                sb.Append(Paragraph.TypeOfParagraph +" " + Text.ParagraphText.TextOfParagraph);
            if (Text.OrderListText != null && OrderList != null)
            {
                sb.Append(OrderList.TypeOfOrderList + "\n");
                foreach(string str in Text.OrderListText.TextOfOrderList)
                {
                    sb.Append(str + "\n");
                }
            }
            if (Text.BulletedListText != null && BulletedList != null)
            {
                sb.Append(BulletedList.TypeOfBulletedList + "\n");
                foreach (string str in Text.BulletedListText.TextOfBulletedList)
                {
                    sb.Append(str + "\n");
                }
            }
            if (Text.HeaderText != null && Header != null)
            {
                sb.Append(Header.HeaderFirstLevel + " " +Text.HeaderText.TextOfHeader1);
                sb.Append(Header.HeaderSecondLevel + " " + Text.HeaderText.TextOfHeader2);
                sb.Append(Header.HeaderThirdLevel + " " + Text.HeaderText.TextOfHeader3);
                sb.Append(Header.HeaderFourthLevel + " " + Text.HeaderText.TextOfHeader4);
                sb.Append(Header.HeaderFifthLevel + " " + Text.HeaderText.TextOfHeader5);
                sb.Append(Header.HeaderSixthLevel + " " + Text.HeaderText.TextOfHeader6);
            }
            return sb.ToString();
        }
    }
}
