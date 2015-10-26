using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoConsole.events.handling
{
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
