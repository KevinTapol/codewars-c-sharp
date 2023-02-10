// 
// Parameters or Edge Cases:
    // input will be an integer greater than 0
// Return:
    // the summation of 1 to input integer n incrementing by 1
// Examples:
    // 2 -> 3 (1 + 2)
    // 8 -> 36 (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8)
// Psuedo Code: 
    // use Guass' Thereom of x * (x + 1) / 2 or loop
    // declare a variable int and set it equal to 0
    // loop through starting at 1 and incrementing by 1 to the input number inclusively adding each increment to the declared variable
    // return the declared variable

// my answer using Gauss' Thereom best practices and most clever
using System;
namespace ConsoleApp 
{
    public class codewars014 
    {
    public static int summation(int num)
    {
        return num * (num +1) / 2;
    }
    }
}

// my answer brute force for loop
// using System;
// namespace ConsoleApp 
// {
//     public class codewars014 
//     {
//     public static int summation(int num)
//     {
//       int sum = 0;
//       for(int i = 1; i <= num; i++)
//       {
//         sum += i;
//       }
//       return sum;
//     }
//     }
// }

// In general, arrays are best used when you know the size of the collection and don't need to add or remove elements dynamically. Lists are best used when you need a dynamic collection that can grow or shrink in size as elements are added or removed.
// Enumerable.Range(start, stop inclusively) .Sum() Range.() is used to create a sequence and you can add .ToList() or .ToArray() to create a list or an array respectively.
using System;
using System.Linq;

public static class Kata 
{
    public static int summation(int num)
    {
      return Enumerable.Range(1, num).Sum();
    }
}

// here they are adding .ToArray() and using .Sum() to sum the generated array
using System.Linq;

public static class Kata 
{
    public static int summation(int num)
    {
      return Enumerable.Range(1, num).ToArray().Sum();
    }
}

// using methods for Guass' Thereom
using System;

public static class Kata 
{
    public static int summation(int num)
    {
      return Convert.ToInt32(num++ * Decimal.Divide(num, 2));
    } 
}

// calling the function on itself to simulate a for loop 
using System;

public static class Kata 
{
    public static int summation(int num) => num < 1 ? num : num + summation(num - 1);
}

// here they are using Guass' Theroem but altered with Console.Write(input); to record the input
using System;

public static class Kata 
{
    public static int summation(int num)
    {
      //Code here
      Console.Write(num);
      return num * (2 +(num - 1) ) / 2;
     }
}

// while loop but decrementing
using System;

public static class Kata 
{
    public static int summation(int num)
    {
    int result =0;
      while(num>0)
      {
      result +=num;
      num--;
      }
      return result;
    }
}

// while loop but incrementing
using System;

public static class Kata 
{
    public static int summation(int num)
    {
      //Code 
      int i=1;
      int sum=0;
      while (i<=num){
        sum+=i;
        i++;
      }
      return sum;
    }
}