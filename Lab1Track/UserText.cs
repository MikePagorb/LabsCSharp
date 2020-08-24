using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Track
{
    class ParagraphText
    {
        public string TextOfParagraph { get; set; }
    }
    class HeaderText
    {
        public string TextOfHeader1 { get; set; }
        public string TextOfHeader2 { get; set; }
        public string TextOfHeader3 { get; set; }
        public string TextOfHeader4 { get; set; }
        public string TextOfHeader5 { get; set; }
        public string TextOfHeader6 { get; set; }

    }

    class OrderListText
    {
        public string TextOfOrderList { get; set; }
    }

    class BulletedListText
    {
        public string TextOfBulletedList { get; set; }
    }
    class UserText
    {
        public ParagraphText ParagraphText { get; set; }
        public HeaderText HeaderText { get; set; }
        public OrderListText OrderListText { get; set; }
        public BulletedListText BulletedListText { get; set; }
        public UserText (string InputUserText)
        {
            if(InputUserText.Contains("<par>"))
            {
                this.ParagraphText.TextOfParagraph = InputUserText.Replace("<par>", "");
            }
            else if (InputUserText.Contains("<Olist>"))
            {
                this.OrderListText.TextOfOrderList = InputUserText.Replace("<Olist>","");
                while (Console.ReadLine() != null || Console.ReadLine() != "")
                {
                    this.OrderListText.TextOfOrderList += Console.ReadLine();
                }
            }
            else if(InputUserText.Contains("<Blist>"))
            {
                this.BulletedListText.TextOfBulletedList = InputUserText.Replace("<Blist>", "");
                while(Console.ReadLine() != null || Console.ReadLine() != "")
                {
                    this.BulletedListText.TextOfBulletedList += Console.ReadLine();
                }
            }
        }
    }
}
