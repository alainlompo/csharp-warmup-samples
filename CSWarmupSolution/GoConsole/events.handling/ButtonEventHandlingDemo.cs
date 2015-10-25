using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.events.handling
{
    class ButtonEventHandlingDemo
    {
        public void DoButtonEventHandlingDemo()
        {
            Button btn = new Button();
            btn.Click += ButtonClickHandler;
            btn.Clicked += ButtonClickedHandler;

            Button.DoClickAndAfter(btn);

        }

        public void ButtonClickHandler(Object sender, EventArgs e)
        {
            Console.WriteLine("Currently handling the click event....");
            if (e is ButtonClickEventArgs)
            {
                ButtonClickEventArgs ev = (ButtonClickEventArgs)e;
                Console.WriteLine("The button was click at coordinates (x, y) = (" + ev.X + "," + ev.Y + ")");

            }

            Console.WriteLine("We do the appropriate processing here....");

        }

        public void ButtonClickedHandler(Object sender, EventArgs e)
        {
            Console.WriteLine("Do some other processing after the button click is handled (handling the clicked event ....)");
        }
    }
}
