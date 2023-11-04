## MHConvert (to use this initialize MHConvert)
**Method 1**
```csharp
* double FahrenheitToCelsius(double fahrenheit)
```

**Example**
```csharp
using MHBasicMethods;

MHConvert mHConvert = new MHConvert();

Console.WriteLine("273 Fahrenheit is " + mHConvert.FahrenheitToCelsius(273) + " Celsius");

//Result: 273 Fahrenheit is 133.88888888888889 Celsius
```

**Method 2**
```csharp
* double CelsiusToFahrenheit(double celsius)
```
**Example**
```csharp
using MHBasicMethods;

MHConvert mHConvert = new MHConvert();

Console.WriteLine("273 Celsius is " + mHConvert.CelsiusToFahrenheit(212) + " Fahrenheit");

//Result: 273 Celsius is 413.6 Fahrenheit
```

## MHDate (to use this initialize MHDate)
    * int CalculateAge(DateTime birthdate)
    * List<DateTime> GetFirstAndLastDayOfMonth(DateTime date)
    * bool IsLeapYear(int year)
    * string FormatElapsedTime(DateTime startDate)
    * DateTime FindNextWeekday(DateTime startDate, DayOfWeek weekday)

## MHNumbers (to use this initialize MHNumbers)
    * string ConvertNumberToWords(int number)
    * List<int> FindPrimeNumbers(int n)
    * int CalculateFactorial(int n)
    * List<int> GenerateFibonacciSeries(int n)
    * int FindGCD(int a, int b)
    * double CalculatePower(double baseNumber, int exponent)
    * bool IsArmstrongNumber(int number)
    * int FindLCM(int a, int b)
    * bool IsPalindrome(int number)
    * bool IsPerfectNumber(int number)
    * double CalculateSquareRoot(double number)
    * string DecimalToBinary(int decimalNumber)
    * int BinaryToDecimal(string binaryNumber)
    * bool IsPowerOfTwo(int number)
    * int CountDigits(int number)
    * double CalculateExponentiation(double baseNumber, int exponent)
    * bool IsHappyNumber(int number)
    * bool IsHarshadNumber(int number)
    * List<int> GeneratePrimesInRange(int start, int end)

## MHRandom (to use this initialize MHRandom)
    * string GenerateRandomAlphanumeric(int length)
    * string GenerateRandomGuid()
    * string GenerateRandomUniqueCodeWithPrefix(string prefix, int length)
    * string GenerateRandomHexadecimal(int length)
    * string GenerateRandomPronounceablePassword(int length)
    * string GenerateRandomBase64String(int length)
    * string GenerateRandomString(int length, string customCharacterSet)
    * string GenerateRandomEmailAddress()
    * string GenerateRandomPhoneNumber()
    * DateTime GenerateRandomDate(DateTime startDate, DateTime endDate)
    * string GenerateRandomIPv4Address()
    * string GenerateRandomStringWithPrefixAndSuffix(string prefix, string suffix, int length)
    * string GenerateRandomNumber(int length)
    * string GenerateRandomKey(int length, bool includeNumbers, bool includeLowercase, bool includeUppercase, bool includeSpecialCharacters)

## MHEncryption (to use this initialize MHEncrypt)
    * string Encrypt(string plainText, string secretKey)
    * string Decrypt(string cipherText, string secretKey)