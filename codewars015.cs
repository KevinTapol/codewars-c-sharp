// Remove String Spaces
// Parameters or Edge Cases:
    // inputs will be a single string with characters and spaces
// Return:
    // the input string without ALL spaces
// Examples:
    // NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B")); => "8j8mBliB8gimjB8B8jlB"
    // NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd")); => "88Bifk8hB8BB8BBBB888chl8BhBfd"
    // NoSpace("8aaaaa dddd r     ")); => "8aaaaaddddr"
// Psuedo Code:
    // replace every " " with "" and return the new string

// my answer, best practices and most clever
using System;
namespace ConsoleApp 
{
    public class codewars015 
    {
        public static string NoSpace(string input)
        {
        return input.Replace(" ", "");
        }  
    }
}

// my answer implicit return
using System;
namespace ConsoleApp 
{
    public class codewars015 
    {
        public static string NoSpace(string input) => input.Replace(" ", ""); 
    }
}

// using string.Empty instead of "" for the second argument in .Replace()
namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        return input.Replace(" ", string.Empty);
    }  
  }
}

// using a ternary to check if the input is null
namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        return input != null ? input.Replace(" ", "") : null;
    }  
  }
}

// using method .IsNullOrWhiteSpace()
using System;

namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
				  return string.Empty;

			  return input.Replace(" ", string.Empty);
    }  
  }
}

// brute force for loop
using System;

namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        string output = "";
        for(int i = 0; i < input.Length; i++)
        {
          if(input[i].ToString() != " ")
          {
            output = output + input[i];
          }
        }
        return output;
    }  
  }
}

// using .Trim() for white space before and after the string with .Replace() for in-between string characters
namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    { 
    //Added the Trim() for cases where spaces are at the start or end which IS NOT BEING COVERED BY THE TESTS
        return input.Replace(" ",string.Empty).Trim();
    }  
  }
}

// using .Split() to remove whitespace and convert each element around them into elements in an array then .Concat() to return to string
namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        return string.Concat(input.Split());
    }  
  }
}

// using .Where() checking for whitespace similar to .filter() for JavaScript
using System;
using System.Linq;

namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string s)
    {
        return new string(s.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
    }  
  }
}

// using Regex
using System.Text.RegularExpressions;

namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        return input = Regex.Replace(input, @"\s+", "");        
    }  
  }
}

// another regex
using System.Text.RegularExpressions;
namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
      return new Regex("[ ]?").Replace(input, "");
    }  
  }
}

// using foreach instead of a for loop
namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
        //Code it!
      string ch = "";
      foreach(char i in input)
        {
        if (i != ' ')
          ch += i;
      }
      return ch;
    }  
  }
}

// classic .Join() and .Split() for string and array methods
using System;
namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
      return String.Join("",input.Split());
    }  
  }
}