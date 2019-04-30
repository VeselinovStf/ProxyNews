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
        private const string ESCAPE_SIGHN1 = "&nbsp;";
        private const string ESCAPE_SIGHN2 = "&ndash;";
        private const string ESCAPE_SIGHN3 = "&quot;";
        private const string ESCAPE_SIGHN4 = "&bdquo;";

        public string[] FormatElements = {
            P_OPPEN_ELEMENTS,
            P_CLOSE_ELEMENTS,
            STRONG_OPEN_ELEMENTS,
            STRONG_CLOSE_ELEMENTS,
            ESCAPE_SIGHN1,
            ESCAPE_SIGHN2,
            ESCAPE_SIGHN3,
            ESCAPE_SIGHN4
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