using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Track
{
    class HTMLFormatBuilder : FormatBuilder
    {
        public override void SetUserText()
        {
            this.TextFormat.Text = new UserText(Console.ReadLine());
        }
        public override void SetParagraph()
        {
            this.TextFormat.Paragraph = new Paragraph { TypeOfParagraph = "<p>" };
        }
        public override void SetHeader()
        {
            this.TextFormat.Header = new Header
            {
                HeaderFirstLevel = "<h1>",
                HeaderSecondLevel = "<h2>",
                HeaderThirdLevel = "<h3>",
                HeaderFourthLevel = "<h4>",
                HeaderFifthLevel = "<h5>",
                HeaderSixthLevel = "<h6>"
            };
        }
        public override void SetOrderList()
        {
            this.TextFormat.OrderList = new OrderList { TypeOfOrderList = "<ol>" };
        }
        public override void SetBulletedList()
        {
            this.TextFormat.BulletedList = new BulletedList { TypeOfBulletedList = "<ul>" };
        }
    }
}
