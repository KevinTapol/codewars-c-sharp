// Keep Hydrated!
// Parameters or Edge Cases:
    // inputs will be numbers in hours representation
    // inputs can be integers or floats
    // inputs will be greater than 0
// Return:
    // the total litres of water per hour consumed each hour is 0.5 litres rounded down to an integer
// Examples:
    // time = 3 ----> litres = 1
    // time = 6.7---> litres = 3
    // time = 11.8--> litres = 5
// Psuedo Code:
    // take the input float and multiply by 0.5
    // then round down to an integer value
    // return the value

// my answer using Math.Floor() and putting (int) in front to specify that I want an integer return
using System;
namespace ConsoleApp 
{
    public class codewars019 
    {
  public static int Litres(double time)
  {
    return (int)Math.Floor(time * 0.5);
  }
    }
}

// my answer implicit return one liner arrow function
using System;
namespace ConsoleApp 
{
    public class codewars019 
    {
  public static int Litres(double time) => (int)Math.Floor(time * 0.5);
    }
}

// best practices and most clever
// using (int) before the math similar to Python using // to divide and only grab the integer value
using System;
public class Kata
{
  public static int Litres(double time)
  {    
    return (int)(time/2);
  }
}

// doing the same as best practices but multiplying with a float
using System;

public class Kata
{
  public static int Litres(double time) => (int)(time*0.5);

}

// using Convert.ToInt32() instead of (int)
using System;

public class Kata
{
  public static int Litres(double time)
  {
    return Convert.ToInt32(Math.Floor(time * 0.5));
  }
}

//  left shift(<<) by 1 means more or less multiply by 2 and right shift(>>) by 1 means more or less divide by 2. so (time/2) gives same result with (time >> 1).
class Kata
{
  public static int Litres(double time) => (int) time >> 1;
}

// interesting that you can add a space in-between (int) and the math
public class Kata
{
  public static int Litres(double time)
  {
    return (int) (time*0.5);
  }
} 