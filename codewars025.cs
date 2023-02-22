// Convert number to reversed array of digits
// Parameters or Edge Cases:
    // inputs will be a random non-negative number
    // will the array be empty?
// Return:
    // an array of the input integer of digits in reversed order
// Examples:
    // 35231 => [1,3,2,5,3]
    // 0 => [0]
// Psuedo Code:
    // convert the input to a string so that you can separate each digit
    // reverse the string and iterate through each string digit converting it back into an integer
    // convert the reversed integer into an array where each element is a digit
    // return the array

// my answer best practices and most clever
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
  class codewars025
  {
    public static long[] Digitize(long n)
    {
        // convert the input to a string so that you can separate each digit
      return n.ToString()
      // reverse the string
      .Reverse()
      // iterate through each string digit converting it back into an integer
      .Select(t => Convert.ToInt64(t.ToString()))
      // convert the reversed integer into an array where each element is a digit
      .ToArray();
    }
  }
}

// my answer refactored implicit return
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
  class codewars025
  {
    public static long[] Digitize(long n) => n.ToString().Reverse().Select(t => Convert.ToInt64(t.ToString())).ToArray();
  }
}

// string interpolation with a .Select() to iterate through
using System.Linq;

class Digitizer
{
  public static long[] Digitize(long n)
  {
    return $"{n}".Select(c => (long) c - '0').Reverse().ToArray();
  }
}

// string interpolation with long.Parse()
using System.Linq;

class Digitizer
{
  public static long[] Digitize(long n)
  {
    return $"{n}".Select(c => long.Parse($"{c}")).Reverse().ToArray();
  }
}

// using long.Parse() instead of Convert.ToInt64()
using System;
using System.Collections.Generic;
using System.Linq;

    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            return n.ToString().Reverse().Select(x => long.Parse(x.ToString())).ToArray();
        }
    }

    // a do while loop with a list and .Add() method
    using System.Collections.Generic;

namespace Solution
{
    public class Digitizer
    {
        public static long[] Digitize(long number)
        {
            List<long> digits = new List<long>();
            do
            {
                const byte RADIX = 10;
                long digit = number % RADIX;
                digits.Add(digit);
                number /= RADIX;
            }
            while (number > 0);
            return digits.ToArray();
        }
    }
}

// for loop array methods
using System;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      string s = n.ToString();
      long[] l = new long[s.Length];
  
      for (int i = s.Length - 1; i >= 0; i--) {
        long a = s[i] - 48;
        l[i] = a;
      }
      
      Array.Reverse(l);
      return l;
    }
  }
}

// string interpolation with (long) and (c-48)
using System.Linq;

class Digitizer
{
  public static long[] Digitize(long n)
  {
    return $"{n}".Select(c => (long) (c - 48)).Reverse().ToArray();
  }
}

// using + to concat and convert the input with (long)(each element - 48) inside a .Select()
using System.Linq;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
     return (""+n).Reverse().Select(x => (long)(x - 48)).ToArray();
    }
  }
}

// brute force for loop
using System;
using System.Collections.Generic;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      List<long> answer = new List<long>();
      string stringDigit = n.ToString();
      for(int i = stringDigit.Length - 1; i >= 0; i--){
        answer.Add(stringDigit[i] - '0');
      }
      return answer.ToArray();
    }
  }
}

// using Array.ConvertAll()
using System;
using System.Linq;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n) => Array.ConvertAll(n.ToString().Reverse().ToArray(), s => long.Parse(s.ToString()));
  }
}

// using foreach char in string
using System;
using System.Collections.Generic;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long numberArray)
    {
      string number = numberArray.ToString(); 
      int length = number.Length;
      long[] numArray = new long[length];
      double val = 0;
      
      foreach (char num in number)
      {
        length--;
        val = Char.GetNumericValue(num);
        numArray[length] = (long)val;
      }
      return numArray;
    }
  }
}