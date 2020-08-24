using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Track
{
    /// <summary>
    /// Распорядитель по созданию формата текста
    /// </summary>
    class FormatDirector
    {
        public TextFormat CreateFormatingText (FormatBuilder Builder)
        {
            Builder.CreateFormat();
            Builder.SetUserText();
            Builder.SetHeader();
            Builder.SetParagraph();
            Builder.SetOrderList();
            Builder.SetBulletedList();
            return Builder.TextFormat;
        }
    }
}
