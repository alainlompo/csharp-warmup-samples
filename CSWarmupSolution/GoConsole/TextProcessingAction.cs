using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class TextProcessingAction
    {
        public Action<TextDocument> Processor { get; set; }
        public TextProcessingAction(Action<TextDocument> processor)
        {
            Processor = processor;
        }
    }
}
