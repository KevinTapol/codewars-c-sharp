// String repeat
// Parameters or Edge Cases:
    // given 2 inputs first will be a positive integer and the second a string
// Return:
    // input string s repeated input integer n times
// Examples:
    // 6, "I"     -> "IIIIII"
    // 5, "Hello" -> "HelloHelloHelloHelloHello"
// Psuedo Code:
    // declare an empty string variable to concat to
    // create a for loop that starts at 0 and stops exclusively at input n concatenating string s to the empty string variable
    // return the concatenated


// my answer
namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
        // declare an empty string variable to concat to
        string str = "";
        // create a for loop that starts at 0 and stops exclusively at input n concatenating string s to the empty string variable
        for(int i = 0; i < n; ++i)
        {
            str += s;
        }
        return str;
    }
  }
}

// best practices and most clever
// using .Repeat()
namespace Solution
{
  using System;
  using System.Linq;
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      return String.Concat(Enumerable.Repeat(s, n));
    }
  }
}

// implicit return of best practices and most clever
class Program
{
  public static string repeatStr(int n, string s) => string.Concat(Enumerable.Repeat(s, n));
}

// using .Join() instead of .Concat()
namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      return string.Join("", Enumerable.Repeat(s, n));
    }
  }
}

// using StringBuilder().Insert().ToString()
namespace Solution{
  
  public static class Program {
  
    public static string repeatStr(int n, string s) {
      return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
    }
  }
}

// StringBuilder() with a for loop
namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      StringBuilder builder = new StringBuilder();
      for(int i=0; i<n; i++)
      {
         builder.Append(s);
      }
      return builder.ToString();
    }
  }
}

// using algorithms
namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      if(n==1) return s;
      return repeatStr(n-1,s)+s;
    }
  }
}

// benchmarked as fast and efficient
namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      return new string(s[0], n).Replace(s[0] + "", s);
    }
  }
}

// while loop
namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
        {
            string a = s;
            while (--n > 0) a += s;
            return a;
        }
  }
}

// ternary case for when the string is emtpy
namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      return (n < 1) ? string.Empty : s + RepeatStr(n-1, s);
    }
  }
}

// using array methods
namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      return string.Concat(ArrayList.Repeat(s,n).ToArray());
    }
  }
}

// StringBuilder, for loop and array methods
namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
        StringBuilder stringBuilder = new StringBuilder();
        
        for (int i = 0; i < n; i++)
        {
            stringBuilder.Append(s);
        }

        return stringBuilder.ToString();
    }
  }
}