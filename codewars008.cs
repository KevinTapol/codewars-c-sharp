// Return Negative
// Parameters or Edge Cases:
    // inputs will be an integer
    // can be positive or negative
// Return:
    // the negative absolute value of the input 
// Examples:
    // Kata.MakeNegative(1);  // return -1
    // Kata.MakeNegative(-5); // return -5
    // Kata.MakeNegative(0);  // return 0
// Psuedo Code:
    // take the input interger and get the absolute value
    // multipy by -1
    // return the product

// my answer
using System;
using System.Linq;

public static class Kata
{
    public static int MakeNegative(int number)
    {
      return Math.Abs(number) * -1;
    }
}


// my answer implicit return arrow function/ lambda
public static class Kata
{
public static int MakeNegative(int n) => Math.Abs(n) * -1;
}

// best practices and most clever
// similar to mine but putting - in front instead of behind
public static class Kata
{
  public static int MakeNegative(int number)
  {
    return -Math.Abs(number);
  }
}

// very clever imo
// pulling the min value of the input itself and multiplied by -1
public static class Kata
{
  public static int MakeNegative(int number)
  {
    return Math.Min(number, -number);
  }
}

// ternary
public static class Kata
{
  public static int MakeNegative(int number)
  {
    return number > 0 ? -number : number;
  }
}

// ternary implicit return but reversing the carrot from greater to less than
class Kata
{
  public static int MakeNegative(int n) => n < 0 ? n : -n;
}

// if conditional
public static class Kata
{
  public static int MakeNegative(int number)
  {
    if(number>0)
    number*=-1;
    return number;
  }
}

// fun with bit manipulation
public static class Kata
{
  // using two's compliment, flip bits, then add 1
  public static int MakeNegative(int number) => IsNegative(number) ? number : ~number +1;
  
  // check MSB of Int32
  public static bool IsNegative(int n) 
  {
    n |= (n >> 1); 
    n |= (n >> 2); 
    n |= (n >> 4); 
    n |= (n >> 8); 
    n |= (n >> 16);
    return n - (n >> 1) == 0;
  } 
}

// checking if input contains -
public static class Kata
{
  public static int MakeNegative(int number)
  {
    return Convert.ToInt32("-"+System.Math.Abs(number).ToString());
  }
}

// switch case
public static class Kata
{
  public static int MakeNegative(int number)
  {
    switch (number == 0 ? true : false)
            {
                case true:
                      Console.WriteLine("Number equals zero");
                      break;
                case false:
                      switch (number < 0 ? true : false)
                      {
                          case true:
                              Console.WriteLine("Number is already negative");
                              break;
                          case false:
                              number *= (-1);
                              Console.WriteLine("Number changed to negative");
                              break;
                      }
                      break;           
            }
    return number;
  }
}