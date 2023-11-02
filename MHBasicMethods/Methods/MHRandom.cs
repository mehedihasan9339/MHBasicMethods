using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MHBasicMethods.Methods
{
    public class MHRandom
    {
        public string GenerateRandomAlphanumeric(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }



        public string GenerateRandomGuid()
        {
            return Guid.NewGuid().ToString();
        }





        public string GenerateRandomUniqueCode(string prefix, int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string randomString = new string(Enumerable.Repeat(chars, length - prefix.Length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return prefix + randomString;
        }




        public string GenerateRandomHexadecimal(int length)
        {
            const string chars = "0123456789ABCDEF";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }





        public string GenerateRandomPronounceablePassword(int length)
        {
            const string consonants = "bcdfghjklmnpqrstvwxyz";
            const string vowels = "aeiou";
            Random random = new Random();

            StringBuilder password = new StringBuilder();
            for (int i = 0; i < length; i += 2)
            {
                password.Append(consonants[random.Next(consonants.Length)]);
                password.Append(vowels[random.Next(vowels.Length)]);
            }

            return password.ToString();
        }




        public string GenerateRandomBase64String(int length)
        {
            byte[] buffer = new byte[length];
            new Random().NextBytes(buffer);
            return Convert.ToBase64String(buffer);
        }






        public string GenerateRandomString(int length, string customCharacterSet)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(customCharacterSet, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }






        public string GenerateRandomEmailAddress()
        {
            string[] domains = { "gmail.com", "yahoo.com", "hotmail.com", "outlook.com", "example.com" };
            Random random = new Random();
            string username = GenerateRandomString(8, "abcdefghijklmnopqrstuvwxyz0123456789");
            string domain = domains[random.Next(domains.Length)];
            return $"{username}@{domain}";
        }




        public string GenerateRandomPhoneNumber()
        {
            Random random = new Random();
            string areaCode = random.Next(100, 1000).ToString("D3");
            string firstPart = random.Next(100, 1000).ToString("D3");
            string secondPart = random.Next(1000, 10000).ToString("D4");
            return $"({areaCode}) {firstPart}-{secondPart}";
        }



        public DateTime GenerateRandomDate(DateTime startDate, DateTime endDate)
        {
            Random random = new Random();
            int range = (endDate - startDate).Days;
            return startDate.AddDays(random.Next(range));
        }




        public string GenerateRandomIPv4Address()
        {
            Random random = new Random();
            return $"{random.Next(256)}.{random.Next(256)}.{random.Next(256)}.{random.Next(256)}";
        }



        public string GenerateRandomStringWithPrefixAndSuffix(string prefix, string suffix, int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            string middlePart = new string(Enumerable.Repeat(chars, length - prefix.Length - suffix.Length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return $"{prefix}{middlePart}{suffix}";
        }




        public string GenerateRandomStringWithSeparators(int length, string separators, int separatorInterval)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                if (i > 0 && i % separatorInterval == 0)
                {
                    result.Append(separators[random.Next(separators.Length)]);
                }
                else
                {
                    result.Append(chars[random.Next(chars.Length)]);
                }
            }

            return result.ToString();
        }





        public string GenerateRandomNumber(int length)
        {
            Random random = new Random();
            int min = (int)Math.Pow(10, length - 1);
            int max = (int)Math.Pow(10, length) - 1;
            int randomValue = random.Next(min, max);

            string randomNumber = randomValue.ToString().PadLeft(length, '0');

            return randomNumber;
        }

        public string GenerateRandomKey(int length, bool includeNumbers, bool includeLowercase, bool includeUppercase, bool includeSpecialCharacters)
        {
            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numberChars = "0123456789";
            const string specialChars = "!@#$%^&*()-_+=<>?";

            StringBuilder keyBuilder = new StringBuilder();
            Random random = new Random();

            string allChars = "";
            if (includeLowercase) allChars += lowercaseChars;
            if (includeUppercase) allChars += uppercaseChars;
            if (includeNumbers) allChars += numberChars;
            if (includeSpecialCharacters) allChars += specialChars;

            if (allChars.Length == 0)
            {
                Console.WriteLine("Error: No character set selected.");
                return null;
            }

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(0, allChars.Length);
                keyBuilder.Append(allChars[index]);
            }

            return keyBuilder.ToString();
        }





    }
}
