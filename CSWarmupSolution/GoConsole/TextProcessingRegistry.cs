using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class TextProcessingRegistry
    {
        public  List<TextProcessingAction> Processors { get; set; }
        public  TextProcessingRegistry init()
        {
            Processors = new List<TextProcessingAction>();
            return this;
        }

        public  TextProcessingRegistry add(TextProcessingAction processor)
        {
            Processors.Add(processor);
            return this;
        }

        public void apply(TextDocument document)
        {
            foreach (TextProcessingAction tPA in Processors)
            {
                tPA.Processor(document);

            }

        }
    }
}
