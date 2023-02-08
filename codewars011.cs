// Remove First and Last Character
// Parameters or Edge Cases:
    // inputs will be strings with at least 2 characters
// Return:
    // the input string without the first and last character
// Examples:
    // "eloquent" => "loquen"
    // "country" => "ountr"
    // "person" => "erso"
    // "place" => "lac"
    // "ok" => ""
// Psuedo Code
    // create a new substring starting at the index 1 and ending at the length of the input string -1

// my answer, best practice and most clever
// simple Substring(start, stop) 
using System;
public class Kata
{
    public static string Remove_char(string s)
    {
        return s.Substring(1,(s.Length - 2));
    }
}

// implicit return of my answer
public class Kata
{
    public static string Remove_char(string s) => s.Substring(1, s.Length - 2);
}

// using .Remove(location, how many characters to remove)
// first .Remove() removes 1 character at the end 
// seconded .Remove() removes 1 character at the start of the string
public class Kata
{
    public static string Remove_char(string s)
    {
        return s.Remove(s.Length - 1, 1).Remove(0, 1);
    }
}

// implicit return arrow function with a nested index algorithm call
public class Kata
{
  public static string Remove_char(string s) => s[1..^1];
}

// similar to above but not implicit return and using (s.Length -1)
public class Kata
{
    public static string Remove_char(string s)
    {
        return s[1..(s.Length - 1)];
    }
}

// using a ternary for input strings greater than or equal to 2
public class Kata
{
    public static string Remove_char(string s)
    {
        return s.Length >= 2 ? s.Substring(1, s.Length - 2) :  "ok";
    }
}

// using .Remove() twice
public class Kata
{
    public static string Remove_char(string str)
    {
        str = str.Remove(0, 1);
        str = str.Remove((str.Length - 1), 1);
        
        return str;
    }
}

// using only methods
public class Kata
{
    public static string Remove_char(string s)
    {
        return new string(s.ToCharArray().Skip(1).ToArray().Reverse().Skip(1).Reverse().ToArray());
    }
}


// using .Join() "" removes from the beginning and .Take() from the end
// C# .Skip(start).Take(stop) reminds me of JavaScript and Python .slice(start, stop)
public class Kata
{
    public static string Remove_char(string s)
    {
        return string.Join("",s.Skip(1).Take(s.Length - 2));
    }
}

// using Regex with .Replace()
// using System.Text.RegularExpressions;

class Kata
{
  public static string Remove_char(string s) => Regex.Replace(s, "^.|.$", "");
}

// ternary for empty string
public class Kata
{
    public static string Remove_char(string s)
    {
        var count = s.Length - 2;
        return count <= 0 ? string.Empty : s.Substring(1, count);
    }
}

// using char[] and a for loop
public class Kata
{
    public static string Remove_char(string s)
    {
        char[] letras = new char [s.Length-2];
          for(int i=1;i<s.Length-1;i++)
          {
          letras[i-1] = s[i];  
          }
      return new string(letras);
    }
  
}

// .Skip() .Take() and other array methods
public class Kata
{
    public static string Remove_char(string s) => new string(s.Skip(1).Take(s.Length - 2).ToArray());
}

// same as above but using .Concat()
public class Kata
{
    public static string Remove_char(string s) =>
    string.Concat(s.Skip(1).Take(s.Length - 2));
}