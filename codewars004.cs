// Convert a Number to a String!
// Parameters or Edge Cases:
    // inputs will be integers can be negative
// Return:
    // intputs as a string
// Examples:
    // 123  --> "123"
    // 999  --> "999"
    // -100 --> "-100"
// Psuedo Code:
    // return the input as a string with .ToString()

// my answer and best practices
using System;

public class Kata
{
  public static string NumberToString(int num)
  {
    return num.ToString();
  }
}

// most clever implicit return

public class Kata
{
  public static string NumberToString(int num) => num.ToString();
}

// using concatenation

public class Kata
{
  public static string NumberToString(int num)
  {
    return num + "";
  }
}

// implicit return with concatenation
public class Kata
{
    public static string NumberToString(int num) => num + "";
}


// using string interpolation

public class Kata
{
  public static string NumberToString(int num)
  {
    return $"{num}";
  }
}

// implicit return with string interpolation
public class Kata
{
  public static string NumberToString(int n) => $"{n}";
}

// building an entire class

public class Kata
{
    public static string NumberToString(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        string result = "";
        var copy = Math.Abs(num);

        for (uint i = 0; copy != 0; i++)
        {
            result += copy % 10;
            copy /= 10;
        }
        
        if (num < 0)
        {
            result += '-';
        }
        
        char[] charArray = result.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
}

// using .Concat()

public class Kata
{
  public static string NumberToString(int num)
  {
    return string.Concat(num);
  }
}

// using .Format()

public class Kata
{
  public static string NumberToString(int num)
  {
    // code here
    return string.Format("{0:d}", num);
  }
}