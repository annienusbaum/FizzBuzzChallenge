using System;

public class FizzBuzz
{
    public static string GetFizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (number % 3 == 0)
        {
            return "Fizz";
        }
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return number.ToString();
        }
    }

    public static void Main()
    {
        for (int i = 1; i <= 15; i++)
        {
            Console.WriteLine(GetFizzBuzz(i));
        }
    }
}


/*
Write a public method that accepts a number. 
Main method: Demonstrates how to use the GetFizzBuzz method in a loop.
This method takes an integer (number) as input and applies the FizzBuzz logic to determine the appropriate result-
 and is returned as a string.
-  when the number is divisible by 3 return the word fizz 
(FizzBuzz class: Contains the logic for the FizzBuzz rules.)
-  when the number is divisible by 5 return the word buzz (GetFizzBuzz method: 
// Implements the FizzBuzz rules and returns the appropriate string.)
-  when the number is divisible by both, return the word fizzbuzz
*/
