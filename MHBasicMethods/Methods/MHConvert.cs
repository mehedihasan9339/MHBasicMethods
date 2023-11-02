using System;
using System.Collections.Generic;
using System.Text;

namespace MHBasicMethods.Methods
{
    public class MHConvert
    {
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }



        public double CelsiusToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

    }
}
