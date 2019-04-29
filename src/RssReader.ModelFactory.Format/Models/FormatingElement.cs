using RssReader.ModelFactory.Format.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RssReader.ModelFactory.Format.Models
{
    public class FormatingElement : IModelFactoryFormatingElement
    {
        private const string P_OPPEN_ELEMENTS = "<p>";
        private const string P_CLOSE_ELEMENTS = "</p>";
        private const string STRONG_OPEN_ELEMENTS = "<strong>";
        private const string STRONG_CLOSE_ELEMENTS = "</strong>";

        public string[] FormatElements = {
            P_OPPEN_ELEMENTS,
            P_CLOSE_ELEMENTS,
            STRONG_OPEN_ELEMENTS,
            STRONG_CLOSE_ELEMENTS
        };

        string[] IModelFactoryFormatingElement.FormatElements
        {
            get
            {
                return FormatElements;
            }
        }
    }
}