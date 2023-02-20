// You Can't Code Under Pressure #1
// Parameters or Edge Cases:
    // inputs will be numbers
// Return:
    // the double of the input number
// Examples:    
    // (2) => (4);
    // (4) => (8);
    // (-10) => (-20);
    // (0) => (0);
    // (100) => (200);
// Psuedo Code:

// my answer and best practices
using System;
namespace ConsoleApp 
{
    public class codewars024
    {
        public static int DoubleInteger(int n)
        {
            return n*2;
        }
    }
}


// my answer implicit return arrow function
using System;
namespace ConsoleApp 
{
    public class codewars024 
    {
  public static int DoubleInteger(int n) => n*2;
    }
}

// most clever using << to multiply by 2
using System;

public static class Kata
{
  public static int DoubleInteger(int n) =>n<<1;
}

// adding itself to itself 
using System;

public static class Kata
{
  public static int DoubleInteger(int n) =>
  n + n;
}

// interesting that you can use parenthesis to evaluate to addition
using System;

public static class Kata
{
  public static int DoubleInteger(int n)
  {
 int result= n-(-n);
 return result;
    //Double the input!
    //easy 
  }
}

// creating a function and calling it by another to pass in the input to ultimately use << 1 to multiply by 2
// essentially an overly complicated version of input * 2 but similar to what you would see in an interview
using System;

public static class Kata
{
  private static int Add(int x, int y){
    if(y != 0)
      return Add(x ^ y, (x & y) << 1);
    return x;
  }

  public static int DoubleInteger(int n)
  {
    return Kata.Add(n,n);
  }
}