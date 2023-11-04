using System;
using System.Collections.Generic;
using System.Text;

namespace MHBasicMethods
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

        public double CentimetersToInches(double centimeters)
        {
            double inches = centimeters / 2.54;
            return inches;
        }

        public double InchesToCentimeters(double inches)
        {
            double centimeters = inches * 2.54;
            return centimeters;
        }




        public double FeetToMeters(double feet)
        {
            double meters = feet * 0.3048;
            return meters;
        }




        public double MetersToFeet(double meters)
        {
            double feet = meters * 3.28084;
            return feet;
        }




        public double PoundsToKilograms(double pounds)
        {
            double kilograms = pounds * 0.453592;
            return kilograms;
        }




        public double KilogramsToPounds(double kilograms)
        {
            double pounds = kilograms * 2.20462;
            return pounds;
        }




        public double MilesToKilometers(double miles)
        {
            double kilometers = miles * 1.60934;
            return kilometers;
        }



        public double KilometersToMiles(double kilometers)
        {
            double miles = kilometers / 1.60934;
            return miles;
        }




        public double GallonsToLiters(double gallons)
        {
            double liters = gallons * 3.78541;
            return liters;
        }


        public double LitersToGallons(double liters)
        {
            double gallons = liters / 3.78541;
            return gallons;
        }



        public double HoursToMinutes(double hours)
        {
            double minutes = hours * 60;
            return minutes;
        }



        public double MinutesToHours(double minutes)
        {
            double hours = minutes / 60;
            return hours;
        }




        public double HoursToSeconds(double hours)
        {
            double seconds = hours * 3600;
            return seconds;
        }




        public int BinaryToDecimal(string binary)
        {
            int decimalValue = Convert.ToInt32(binary, 2);
            return decimalValue;
        }



        public string DecimalToBinary(int decimalValue)
        {
            string binary = Convert.ToString(decimalValue, 2);
            return binary;
        }








        public byte[] StringToByteArray(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            return bytes;
        }




        public string ByteArrayToString(byte[] bytes)
        {
            string input = Encoding.UTF8.GetString(bytes);
            return input;
        }

    }
}
