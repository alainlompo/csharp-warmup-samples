using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.events.handling
{
    /// <summary>
    /// A subclass of EventArgs is used to manage some events that are usefull for the
    /// handling of a particular event (such as the cartesian coordinate of the place
    /// on the screen where a click event occured)
    /// </summary>
    class ButtonClickEventArgs:EventArgs
    {
        public double X { get; set; }
        public double Y { get; set; }

        /// <summary>
        /// This particular EventArgs store the position (x, y) where the button was clicked!
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public ButtonClickEventArgs(double x, double y)
        {
            X = x;
            Y = y;

        }
    }
}
