// Century From Year
// Parameters or Edge Cases:
    // 
// Return:
    // the century meaning divide by 100 and round up 
// Examples:
    // 1705 --> 18
    // 1900 --> 19
    // 1601 --> 17
    // 2000 --> 20
// Psuedo Code:
    // divide by 100 and round up
    // I don't know why Math.Ceiling() isn't accepted. So I'm going to brute force a conditional instead.
    // if there is a remainder when dividing by 100 then add 1
    // else return the even division
// my answer
// using System;
// namespace ConsoleApp 
// {
//     public class codewars021
//     {
//         public static int СenturyFromYear(int year)
//         {
//             if(year % 100 != 0)
//             {
//                 return (int)((year / 100) + 1);
//             }
//             else{
//                 return (int)(year / 100);
//             }
//         }
//     }
// }

// my answer ternary implicit return arrow function
using System;
namespace ConsoleApp 
{
    public class codewars021
    {
        public static int СenturyFromYear(int year) => year % 100 != 0 ? (int)((year / 100) + 1) : (int)(year / 100);
    }
}

// best practices and most clever
// very clever subtracting by 1 takes into the account of even 100 year division
public static class Kata
{
  public static int СenturyFromYear(int year) => (year - 1) / 100 + 1;
}

// same idea as best practices and most clever but the back end approach of adding 99 for evenly divisible by 100 years
class Kata
{
  public static int СenturyFromYear(int year) => (year + 99) / 100;
}

// Math.Ceiling()
using System;

public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        return (int)Math.Ceiling(year * 0.01);
    }
}

// using a while loop
public static class Kata
{
  public static int СenturyFromYear(int year)
  {
    var century = 1;
    
    while (year > 100) 
    {
      year -= 100;
      century++;
    }
    
    return century;
  }
}

// System.Math.DivRem()
public static class Kata
{
  public static int СenturyFromYear(int year)
  {
    int remainder = year;
    return System.Math.DivRem(year, 100, out remainder) + (remainder > 0 ? 1 : 0);
  }
}

// Math.Round() Wow! You can specify the direction of the round
using System;

public static class Kata
{
  public static int СenturyFromYear(int year)
  {
    double x = Math.Round((year / 100.00), MidpointRounding.ToPositiveInfinity);
    
    int century = (int)x;
    
    return century;
  }
}

// Math.Ceiling() but with double for the input
using System;
public static class Kata
{
  public static double СenturyFromYear(double year)
  {
    return Math.Ceiling(year/100);
  }
}

// Math.Ceiling() but with decimal for the input
using System;

public static class Kata
{
  public static decimal СenturyFromYear(decimal year) => Math.Ceiling(year/100);
}