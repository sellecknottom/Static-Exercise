using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelcius(double tempF)
        {
            return ((tempF - 32) * 5) / 9;
        }
        public static double CelciusToFahrenheit(double tempC)
        {
            return ((tempC * 9) / 5) + 32;
        }
    }
}
