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
        public string [] TextOfOrderList { get; set; }
    }

    class BulletedListText
    {
        public string [] TextOfBulletedList { get; set; }
    }
    class UserText
    {
        public ParagraphText ParagraphText { get; set; }
        public HeaderText HeaderText { get; set; }
        public OrderListText OrderListText { get; set; }
        public BulletedListText BulletedListText { get; set; }
        public UserText (string InputUserText)
        {
            string[] SplitUserString;
            if(InputUserText.Contains("<par>"))
            {
                this.ParagraphText = new ParagraphText();
                this.ParagraphText.TextOfParagraph = InputUserText.Replace("<par>", "");
            }
            else if (InputUserText.Contains("<Olist>"))
            {
                this.OrderListText = new OrderListText();
                //this.OrderListText.TextOfOrderList = InputUserText.Replace("<Olist>","");
                while (Console.ReadLine() != null || Console.ReadLine() != "")
                {
                    //this.OrderListText.TextOfOrderList += string.Concat(",", Console.ReadLine());
                    this.OrderListText.TextOfOrderList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }
            }
            else if(InputUserText.Contains("<Blist>"))
            {
                this.BulletedListText = new BulletedListText();
                //this.BulletedListText.TextOfBulletedList = InputUserText.Replace("<Blist>", "");
                while(Console.ReadLine() != null || Console.ReadLine() != "")
                {
                    //this.BulletedListText.TextOfBulletedList += string.Concat(",", Console.ReadLine());
                    this.BulletedListText.TextOfBulletedList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }
            }
            else 
            {
                this.HeaderText = new HeaderText();
                SplitUserString = InputUserText.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch(SplitUserString[0])
                {
                    case "<Hd1>": 
                        this.HeaderText.TextOfHeader1 = InputUserText.Replace("<Hd1>", "");
                        break;
                    case "<Hd2>":
                        this.HeaderText.TextOfHeader2 = InputUserText.Replace("<Hd2>", "");
                        break;
                    case "<Hd3>":
                        this.HeaderText.TextOfHeader3 = InputUserText.Replace("<Hd3>", "");
                        break;
                    case "<Hd4>":
                        this.HeaderText.TextOfHeader4 = InputUserText.Replace("<Hd4>", "");
                        break;
                    case "<Hd5>":
                        this.HeaderText.TextOfHeader5 = InputUserText.Replace("<Hd5>", "");
                        break;
                    case "<Hd6>":
                        this.HeaderText.TextOfHeader6 = InputUserText.Replace("<Hd6>", "");
                        break;
                    default:Console.WriteLine("Your text format is wrong!");
                        break;

                }
            }

        }
    }
}
