using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Track
{
    class MarkdownFormatBuilder : FormatBuilder
    {
        public override void SetUserText()
        {
            this.TextFormat.Text = new UserText(Console.ReadLine());
        }
        public override void SetParagraph()
        {
            this.TextFormat.Paragraph = new Paragraph { TypeOfParagraph = "" };
        }
        public override void SetHeader()
        {
            this.TextFormat.Header = new Header
            {
                HeaderFirstLevel = "#",
                HeaderSecondLevel = "##",
                HeaderThirdLevel = "###",
                HeaderFourthLevel = "####",
                HeaderFifthLevel = "#####",
                HeaderSixthLevel = "######"
            };
        }
        public override void SetOrderList()
        {
            this.TextFormat.OrderList = new OrderList { TypeOfOrderList = "ordlist" };
        }
        public override void SetBulletedList()
        {
            this.TextFormat.BulletedList = new BulletedList { TypeOfBulletedList = "bullist" };
        }
    }
}
