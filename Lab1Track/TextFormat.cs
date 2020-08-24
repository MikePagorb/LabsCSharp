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

            if (Text.HeaderText != null && Header != null)
            {
                if (Text.HeaderText.TextOfHeader1 != null)
                    sb.Append(Header.HeaderFirstLevel + " " + Text.HeaderText.TextOfHeader1 + "\n" + "\n");
                if (Text.HeaderText.TextOfHeader2 != null)
                    sb.Append(Header.HeaderSecondLevel + " " + Text.HeaderText.TextOfHeader2 + "\n" + "\n");
                if (Text.HeaderText.TextOfHeader3 != null)
                    sb.Append(Header.HeaderThirdLevel + " " + Text.HeaderText.TextOfHeader3 + "\n" + "\n");
                if (Text.HeaderText.TextOfHeader4 != null)
                    sb.Append(Header.HeaderFourthLevel + " " + Text.HeaderText.TextOfHeader4 + "\n" + "\n");
                if (Text.HeaderText.TextOfHeader5 != null)
                    sb.Append(Header.HeaderFifthLevel + " " + Text.HeaderText.TextOfHeader5 + "\n" + "\n");
                if (Text.HeaderText.TextOfHeader6 != null)
                    sb.Append(Header.HeaderSixthLevel + " " + Text.HeaderText.TextOfHeader6 + "\n" + "\n");
            }
            if (Text.ParagraphText != null && Paragraph != null)
                sb.Append(Paragraph.TypeOfParagraph +" " + Text.ParagraphText.TextOfParagraph + "\n" + "\n");
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
            return sb.ToString();
        }
    }
}
