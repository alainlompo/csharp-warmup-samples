using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class TextDocument
    {
        public string Text { get; set; }
        public int Size { get; set; }
        public Boolean UpperCased { get; set; }
        public List<String> Words { get; set; }

        public TextDocument(String text)
        {
            Text = text;
        }
    }
}
