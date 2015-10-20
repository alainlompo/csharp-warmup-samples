using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.EnterpriseServices;

namespace GoConsole
{
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
        public int HandleHotTemperature()
        {
            return -1;
        }

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
