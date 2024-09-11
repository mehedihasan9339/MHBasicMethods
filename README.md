# Basic C# Methods (V 1.1.0)

## Package Info
https://www.nuget.org/packages/MHBasicMethods
```cmd
Install-Package MHBasicMethods -Version 1.1.0
```

## MHConvert (to use this initialize MHConvert)
#### _MHConvert mhConvert = new MHConvert()_
```csharp
01. double FahrenheitToCelsius(double fahrenheit)
02. double CelsiusToFahrenheit(double celsius)
03. double CentimetersToInches(double centimeters)
04. double InchesToCentimeters(double inches)
05. double FeetToMeters(double feet)
06. double MetersToFeet(double meters)
07. double PoundsToKilograms(double pounds)
08. double KilogramsToPounds(double kilograms)
09. double MilesToKilometers(double miles)
10. double KilometersToMiles(double kilometers)
11. double GallonsToLiters(double gallons)
12. double LitersToGallons(double liters)
18. double HoursToMinutes(double hours)
19. double MinutesToHours(double minutes)
20. double HoursToSeconds(double hours)
21. int BinaryToDecimal(string binary)
22. string DecimalToBinary(int decimalValue)
23. byte[] StringToByteArray(string input)
24. string ByteArrayToString(byte[] bytes)
```


## MHDate (to use this initialize MHDate)
#### _MHDate mhDate = new MHDate()_
```csharp
01. int CalculateAge(DateTime birthdate)
02. List<DateTime> GetFirstAndLastDayOfMonth(DateTime date)
03. bool IsLeapYear(int year)
04. string FormatElapsedTime(DateTime startDate)
05. DateTime FindNextWeekday(DateTime startDate, DayOfWeek weekday)
06. int CalculateDaysBetweenDates(DateTime startDate, DateTime endDate)
07. void CalculateAgeDetailed(DateTime birthDate, DateTime currentDate, out int days, out int hours, out int minutes, out int seconds)
```
    

## MHNumbers (to use this initialize MHNumbers)
#### _MHNumbers mhNumbers = new MHNumbers_
```csharp
01. string ConvertNumberToWords(int number)
02. List<int> FindPrimeNumbers(int n)
03. int CalculateFactorial(int n)
04. List<int> GenerateFibonacciSeries(int n)
05. int FindGCD(int a, int b)
06. double CalculatePower(double baseNumber, int exponent)
07. bool IsArmstrongNumber(int number)
08. int FindLCM(int a, int b)
09. bool IsPalindrome(int number)
10. bool IsPerfectNumber(int number)
11. double CalculateSquareRoot(double number)
12. string DecimalToBinary(int decimalNumber)
13. int BinaryToDecimal(string binaryNumber)
14. bool IsPowerOfTwo(int number)
15. int CountDigits(int number)
16. double CalculateExponentiation(double baseNumber, int exponent)
17. bool IsHappyNumber(int number)
18. bool IsHarshadNumber(int number)
19. List<int> GeneratePrimesInRange(int start, int end)
```

## MHRandom (to use this initialize MHRandom)
#### _MHRandom mhRandom = new MHRandom_
```csharp
01. string GenerateRandomAlphanumeric(int length)
02. string GenerateRandomGuid()
03. string GenerateRandomUniqueCodeWithPrefix(string prefix, int length)
04. string GenerateRandomHexadecimal(int length)
05. string GenerateRandomPronounceablePassword(int length)
06. string GenerateRandomBase64String(int length)
07. string GenerateRandomString(int length, string customCharacterSet)
08. string GenerateRandomEmailAddress()
09. string GenerateRandomPhoneNumber()
10. DateTime GenerateRandomDate(DateTime startDate, DateTime endDate)
11. string GenerateRandomIPv4Address()
12. string GenerateRandomStringWithPrefixAndSuffix(string prefix, string suffix, int length)
13. string GenerateRandomNumber(int length)
14. string GenerateRandomKey(int length, bool includeNumbers, bool includeLowercase, bool includeUppercase, bool includeSpecialCharacters)
```

## MHEncryption (to use this initialize MHEncrypt)
#### _MHEncryption mhEncryption = new MHEncryption_
```csharp
01. string Encrypt(string plainText, string secretKey)
02. string Decrypt(string cipherText, string secretKey)
```


