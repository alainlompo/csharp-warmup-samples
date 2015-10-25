using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFunctional
{
    class TemperatureConverter
    {
        public Func<Double, Double> Converter { get; set; }

        public void DoConversionDemo()
        {
            Console.WriteLine("Input the celsius temperature's value: ");
            Double celsius = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input the type of conversion: 1 ==> Farenheit and 2 ==> Kelvin");
            int conversionType = int.Parse(Console.ReadLine());


            if (1 == conversionType)
            {
                Converter = ToFarenheit;                        // The magic takes place here
            }

            else if (2 == conversionType)
            {
                Converter = ToKelvin;

            }

            else
            {
                Console.WriteLine("Incorrect conversion type....");
                return;
            }

            double conversionResult = Converter(celsius);                        // Doing the call through the Func<T, TResult> delegate
            Console.WriteLine("The result of the conversion is ...." + conversionResult);
            Console.ReadKey();

        }

        public double ToFarenheit(double celsius)
        {
            return celsius * 1.8 + 32;

        }

        public double ToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

    }
}
