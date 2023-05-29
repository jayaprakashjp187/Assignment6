using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Temparature
    {
        public static void CelsiusToFahrenheit(double temp)
        {
            double F = (temp * 9 / 5) + 32;
            Console.WriteLine(temp + "°C in Fahrenheit is: " + F + "°F");
        }

        public static void FahrenheitToCelsius(double temp)
        {
            double C = (temp - 32) * 5 / 9;
            Console.WriteLine(temp + "°F in Celsius is: " + C + "°C");
        }
    }
}
