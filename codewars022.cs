// Convert Boolean to a String
// Parameters or Edge Cases:
    // inputs will be boolean
// Return:
    // return the boolean true or false to string "True" or "False"
// Examples:
    // true => "True"
    // false => "False"
// Psuedo Code:
    // if the input is true return "True" else "False"


// my answer and best practices
// using truthy ternary
using System;
namespace ConsoleApp 
{
    public class codewars022
    {
        public static string BooleanToString(bool b)
        {
            return b? "True": "False";
        }
    }
}

// my answer using truty ternary implicit return arrow function
using System;
namespace ConsoleApp 
{
    public class codewars022
    {
        public static string BooleanToString(bool b) => b? "True": "False";
    }
}

// I was wondering if you could do this in C#.
// using .ToString() directly on a boolean
using System;

public class kata
{
  public static string BooleanToString(bool b)
  {
    //Please don't delete me!
    // ok
    
    return b.ToString();
  }
}

// using + to concat the boolean input
using System;

public class kata
{
  public static string boolean_to_string(bool b) => "" + b;
}

// using string interpolation for C# similar to JS template literals and Python f string
using System;

public class kata
{
  public static string BooleanToString(bool b)
  {
    return  $"{b}";

  }
}

// using Convert.ToString() to handle null values
using System;

public class kata
{
  public static string BooleanToString(bool b) => Convert.ToString(b);
 
}

// using classic conditional statements and taking into account non bool values
using System;

public class kata
{
  public static string BooleanToString(bool b)
  {
    //Please don't delete me!
    if (b == true) {
      return "True";
    } else if (b == false) {
      return "False";
    } else {
      return "Invalid input";
    }
  }
}