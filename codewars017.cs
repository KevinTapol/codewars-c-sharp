// Convert a String to a Number
// Parameters or Edge Cases:
    // inputs will be a string of an integer that can be negative
// Return:
    // the input as an integer
// Examples:
    // "1234" --> 1234
    // "605"  --> 605
    // "1405" --> 1405
    // "-7" --> -7
// Psuedo Code:
    // take in the input string and use the method Convert.ToInt32(input) to convert the input to a integer
    // return the integer

// my answer
using System;
namespace ConsoleApp 
{
    public class codewars017 
    {
        public static int StringToNumber(String str) 
        {
            return Convert.ToInt32(str);
        }
    }
}

// my answer implicit return arrow function
using System;
namespace ConsoleApp 
{
    public class codewars017 
    {
        public static int StringToNumber(String str) => Convert.ToInt32(str);
    }
}

// Best Practices using int.Parse(input)
// int.Parse and Convert ToInt32 are two methods to convert a string to an integer. The main difference between int Parse and Convert ToInt32 in C# is that passing a null value to int Parse will throw an ArgumentNullException while passing a null value to Convert ToInt32 will give zero.
using System;
  public class Kata
  {
    public static int StringToNumber(String str) {
         return (int.Parse(str));
  }
}

// using Int32.Parse()
using System;
public class Kata
{
  public static Int32 StringToNumber(String Input) => Int32.Parse(Input);
}

// using a dictionary/object 
using System;
using System.Collections.Generic;

  public class Kata
  {
    private static Dictionary<char, int> translation = new Dictionary<char, int>()
    {
      {'0', 0},
      {'1', 1},
      {'2', 2},
      {'3', 3},
      {'4', 4},
      {'5', 5},
      {'6', 6},
      {'7', 7},
      {'8', 8},
      {'9', 9},
      {'-', int.MinValue}
    };
    
    // Converts the string representation of an integer to an int without a switch case.
    public static int StringToNumber(String str)
    {
      int num = 0, multiply = 1, length = str.Length;
      for (int i = 0; i < length; i++)
      {
        num += translation[str[length - (i + 1)]] * multiply;
        multiply *= 10;
      }
      return num * Math.Sign(translation[str[0]]);
    }
}


// checking for first character containing - for negative numbers and for loop for the integer
using System;
  public class Kata
  {
    public static int StringToNumber(String str) {
        int num=0;
        bool neg=false;
        if(str[0]=='-')
          neg=true;
        else 
          num=num*10+(str[0]-'0');
        for(int i=1;i<str.Length;i++){
      
        num=num*10+(str[i]-'0');
        
}
      if(neg)
        num*=-1;
      return num;
  }
    
}

// checking for string values not 0-9 and for loop for string to int
using System;

public static class Kata
{
  // using Int32.Parse here is boring
  // & imo failing the task, since we're supposed to write Int32.Parse
  public static int StringToNumber(String str)
    => str.TryParseInt() ?? 0;

  public static int? TryParseInt(this string source)
	{
		int signed = source[0] == '-' ? 1 : 0;
		int? result = -signed; // prevent overflow for signed numbers
		
		for (int i = signed; i < source.Length; ++i)
		{
			if (source[i] > '9' || source[i] < '0')
			{
				return null;
			}
		}

		for (int mult = 1, i = source.Length - 1; i >= signed; --i, mult *= 10)
		{
			result = checked (result + ((source[i] - '0') * mult));
		}

		return signed == 1
			? -result - 1 
			: result;
	}
}

// using int.TryParse()
using System;
  public class Kata{
  public static int StringToNumber(String str) {
        int j;
         int.TryParse(str, out j);
         return j;  
  }
}