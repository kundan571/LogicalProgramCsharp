using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalProgram;

public class Solution
{
    // Fibonacci series method finding fibonacci series till n.
    public void FibonacciSeries()
    {
        int firstTerm = 0;
        int secondTerm = 1;
        Console.WriteLine("Enter a number:");
        String userInput = Console.ReadLine();
        int number = Convert.ToInt32(userInput);
        Console.WriteLine(firstTerm + "\n" + secondTerm);
        for (int i = 1; i <= number - 2; i++)
        {
            int nextTerm = firstTerm + secondTerm;
            Console.WriteLine(nextTerm);
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
    // Perfect Number method checking a number is perfect or not.
    public void PerfectNumber(int number)
    {
        int divisiorSum = 0;
        for (int i = 1; i < number; i++)
        {
            if(number % i == 0)
            {
                Console.WriteLine(i + " ");
                divisiorSum += i;
            }
        }
        if(divisiorSum == number )
        {
            Console.WriteLine($"{ number} is a perfect number: ");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect number: ");
        }
    }
    // checking a number is prime or not
    public void PrimeNumber(int number)
    {
        if( number == 0  || number == 1)
        {
            Console.WriteLine(number + " is not a prime number ");
            return;
        }

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(number + " is not a prime number");
                return;
            }
        }
        Console.WriteLine(number + " is prime number");
    }
    // Reverse number Method
    public void ReverseNumber(int number)
    {
        if(number < 10)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.Write(number % 10);
            ReverseNumber(number / 10);
        }
    }
    // Coupon Number method
    public void CouponNumber()
    {
        char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789".ToCharArray();
        Random random = new Random();
        for (int i = 0; i < 4; i++) 
        {
            int couponCode = random.Next(chars.Length);
            Console.Write(chars[couponCode]);
        }  
    }
}
    class StopwatchExample
{
    public void StopwatchTimer()
    {
        Console.WriteLine("Enter any key to Start timer..");
        Console.ReadKey();
         
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.WriteLine("Stopwatch started.. press any key to stop.");
        Console.ReadKey();
        stopwatch.Stop();

        TimeSpan elapsed = stopwatch.Elapsed;
        Console.WriteLine("Time Elapsed : " + elapsed);
        Console.WriteLine("Press any key to stop:");
        Console.ReadKey();

    }
}
