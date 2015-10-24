using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class SimpleWordInterop
    {
        public static String DoInteropDemo(String filePath)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc =
                wordApp.Documents.Open(filePath, ReadOnly: true);
            dynamic docProperties = doc.BuiltInDocumentProperties;
            string authorName = docProperties["Author"].Value;
            doc.Close(SaveChanges: false);
            return authorName;
        }

    }
}
