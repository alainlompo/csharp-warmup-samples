using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    /// <summary>
    /// This class is composed of an Action<T> component. 
    /// An Action<T> object is a delegate for void (T object) methods
    /// ie a delegate for methods that takes an input parameter and process it along with some
    /// business logic, but returns no particular value.
    /// </summary>
    class TextProcessingAction
    {
        public Action<TextDocument> Processor { get; set; }
        public TextProcessingAction(Action<TextDocument> processor)
        {
            Processor = processor;
        }
    }
}
