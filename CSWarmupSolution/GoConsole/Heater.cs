using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.EnterpriseServices;

namespace GoConsole
{
    /// <summary>
    /// This class illustrates the use of C# delegates in order to raise and handle events
    /// The HandleTemperature delegate allows us to handle either hot temperature or cool temperature
    /// (an even is raised when it's too hot or when it's too cool) triggering a process reversal
    /// </summary>
    [Transaction(TransactionOption.Supported)]
    class Heater
    {
        private int currentTemperature = 15;
        private int currentIncrement = +1;
        private int minTemperature = 5;
        private int maxTemperature = 37;
        public delegate int HandleTemperature();
        event HandleTemperature handler;

        HandleTemperature coolTemperatureHandler;
        HandleTemperature hotTemperatureHandler;

        /// <summary>
        /// When it's too hot then let's reverse the air conditioning and cool the place
        /// </summary>
        /// <returns></returns>
        public int HandleHotTemperature()
        {
            return -1;
        }
        
        /// <summary>
        /// When it's too cool then let's reverse the air conditioning and heat the place
        /// </summary>
        /// <returns></returns>
        public int HandleCoolTemperature()
        {
            return +1;
        }

        public void StartConditionningTheAir()
        {
            coolTemperatureHandler = new HandleTemperature(HandleCoolTemperature);
            hotTemperatureHandler = new HandleTemperature(HandleHotTemperature);

            handler += coolTemperatureHandler;
            while (true)
            {
                Console.WriteLine("Current temperature " + currentTemperature);
                currentTemperature += currentIncrement;

                if (currentTemperature >= maxTemperature)
                {
                    Console.WriteLine("Alert!!! We've reached maximum heat .... cooling process triggered....");
                    handler -= coolTemperatureHandler;
                    handler += hotTemperatureHandler;
                    currentIncrement = handler();

                }

                if (currentTemperature <= minTemperature)
                {
                    Console.WriteLine("Alert!!! We've reached minimum temperature.... heating process triggered ....");
                    handler -= hotTemperatureHandler;
                    handler += coolTemperatureHandler;
                    currentIncrement = handler();

                }

                System.Threading.Thread.Sleep(200);

            }
        }
    }
}
