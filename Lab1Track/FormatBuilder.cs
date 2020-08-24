using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Lab1Track
{
    abstract class FormatBuilder
    {
        public TextFormat TextFormat { get; private set; }
        public void CreateFormat()
        {
            TextFormat = new TextFormat();
        }
        public abstract void SetUserText();
        public abstract void SetParagraph();
        public abstract void SetHeader();
        public abstract void SetOrderList();
        public abstract void SetBulletedList();
    }
}
