using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.events.handling
{
    class Button
    {
        // The Button class defines to events of type EventHandler
        // They are delegate for method of signature void (Object sender, EventArgs e)
        public EventHandler Click { get; set; }
        public EventHandler Clicked { get; set; }


        /// <summary>
        /// Illustrating the standard C# approach to raising events (via OnEvent(...) like methods)
        /// </summary>
        /// <param name="button"></param>
        public static void DoClickAndAfter(Button button)
        {
            EventArgs e = new ButtonClickEventArgs(100.5, 200.25);
            button.OnClick(e);
            Console.WriteLine("Now that the click is done the clicked event is also raised....");
            button.OnClicked(e);
            Console.WriteLine("The clicked event has also been handled...");
            Console.ReadKey();
            
            


        }

        public void OnClick(EventArgs e)
        {
            if (Click != null)
            {
                Click(this, e);
            }

        }

        public void OnClicked(EventArgs e)
        {
            if (Clicked != null)
            {
                Clicked(this, e);
            }

        }

    }
}
