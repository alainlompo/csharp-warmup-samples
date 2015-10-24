using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole
{
    class ActionTDemo
    {
        static String workString;

        public static void ApplyUpperCase(TextDocument document)
        {
            workString = document.Text.ToUpper();
            document.Text = workString;
            document.UpperCased = true;
        }

        public static void GetTheSizeOf(TextDocument document)
        {
            int size = document.Text.Length;
            document.Size = size;
        }

        public static void GetTheWords(TextDocument document)
        {
            String[] elements = document.Text.Split(new string[]{" "}, StringSplitOptions.RemoveEmptyEntries);
            document.Words = new List<string>();
            foreach (string s in elements)
            {
                document.Words.Add(s);
            }

        }

        public static void PrintString(List<String> strings)
        {
            foreach (String s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public static void DoDemo()
        {
            TextDocument document = new TextDocument("This is a text we will use to see how Action<T> works. We will process it many times and store the result");
            TextProcessingRegistry registry = new TextProcessingRegistry();
            registry.init()
                .add(new TextProcessingAction(ApplyUpperCase))
                .add(new TextProcessingAction(GetTheSizeOf))
                .add(new TextProcessingAction(GetTheWords))
                .apply(document);

            Console.WriteLine("The results of applying the processing actions ....");
            Console.WriteLine("The text is now: " + document.Text);
            Console.WriteLine("The size of the text : " + document.Size);
            Console.WriteLine("Is it uppercased ? : " + document.UpperCased);
            Console.WriteLine("The list of the words : " );
            PrintString(document.Words);

            Console.ReadKey();


                

        }
    }
}
