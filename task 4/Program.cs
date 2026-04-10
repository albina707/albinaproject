﻿//1

int[] numbers = { 3, 7, 2, 9, 5, 1 };
int sum = 0;

foreach(int number in numbers)
{
    sum = sum + number;
}

Console.WriteLine(sum);

//2

int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
Array.Sort(temps);
int minSort = temps[0];
int maxSort = temps[temps.Length - 1];

int minMath = temps.Min();
int maxMath = temps.Max();
Console.WriteLine($"Min: {minSort}, Max: {maxSort}\nMin: {minMath}, Max: {maxMath}");

//3

string[] words = { "apple", "banana", "cherry", "date" };
Array.Reverse(words);
Console.WriteLine(string.Join(" ", words));

string[] words2 = { "apple", "banana", "cherry", "date" };
string[] reversed = new string[words.Length];

for (int i = 0; i < words2.Length; i++)
{
    reversed[i] = words2[words2.Length - 1 - i];
}

Console.WriteLine(string.Join(" ", reversed));
//4

int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };

int even = 0;
int odd = 0;

foreach (int num in data)
{
    if (num % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}

Console.WriteLine($"Even: {even}, Odd: {odd}");

//5

int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };
List<int> unique = new List<int>();

foreach (int num in raw) { 

    if (!unique.Contains(num))
    {
        
        unique.Add(num);
    }
}

int[] result = unique.ToArray();
Console.WriteLine(string.Join(" ", result));

//6

int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;

int[] result2 = RotateLeft(arr, k);
static int[] RotateLeft(int[] arr, int k)
{
    int n = arr.Length;
    if (n == 0) return arr;
    k = k % n;

    int[] rotated = new int[n];

    for (int i = 0; i < n; i++)
    {
        rotated[i] = arr[(i + k) % n];
    }
    return rotated;
}

Console.WriteLine($"Result: {string.Join(", ", result)}");

//7

string[] testWords = { "madam", "hello", "racecar", "Level", "world" };

Console.WriteLine("Palindrome:");
foreach (string word in testWords)
{
    bool result3 = IsPalindrome(word);
    Console.WriteLine($"{word}: {result3}");
}

    static bool IsPalindrome(string text)
{
    if (string.IsNullOrEmpty(text)) return false;
    string cleanedText = text.ToLower();

    int leftPointer = 0;
    int rightPointer = cleanedText.Length - 1;
    while (leftPointer < rightPointer)
    {
        if (cleanedText[leftPointer] != cleanedText[rightPointer])
        {
            return false;
        }
        leftPointer++;
        rightPointer--;
    }

    return true;
}

//8

int[] numbersToTest = { 5, 7, 0, 10 };

foreach (int number in numbersToTest)
{
    long result4 = CalculateFactorial(number);
    Console.WriteLine($"Factorial {number}: {result4}");
}

    static long CalculateFactorial(int targetNumber)
{
    if (targetNumber < 0) return 0;

    long factorialResult = 1;

    for (int i = 1; i <= targetNumber; i++)
    {
        factorialResult *= i;
    }

    return factorialResult;
}

//9

Console.WriteLine("FizzBuzz (1-20)");

for (int currentStep = 1; currentStep <= 20; currentStep++)
{
    string displayValue = GetFizzBuzzResult(currentStep);
    Console.WriteLine($"{currentStep} -> {displayValue}");
}


    static string GetFizzBuzzResult(int numberToProcess)
{
    if (numberToProcess % 3 == 0 && numberToProcess % 5 == 0)
    {
        return "FizzBuzz";
    }
    else if (numberToProcess % 3 == 0)
    {
        return "Fizz";
    }
    else if (numberToProcess % 5 == 0)
    {
        return "Buzz";
    }
    else
    {
        return numberToProcess.ToString();
    }
}

//10

double[] celsiusMeasurements = { 0, 20, 37, 100, -40 };

foreach (double celsiusValue in celsiusMeasurements)
{
    double fahrenheitResult = ConvertToFahrenheit(celsiusValue);
    Console.WriteLine($"{celsiusValue,5}°C : {fahrenheitResult,6:F1}°F");
}
    static double ConvertToFahrenheit(double celsius)
{
    return (celsius * 9.0 / 5.0) + 32;
}
static double ConvertToCelsius(double fahrenheit)
{
    return (fahrenheit - 32) * 5.0 / 9.0;
}