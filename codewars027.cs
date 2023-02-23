// Abbreviate a Two Word Name
// Parameters or Edge Cases:
    // inputs will be a string with two words and one space in-between
// Return:
    // the first two letters of each word capitalized and separated with a period
// Examples:
    // Sam Harris => S.H
    // patrick feeney => P.F
// Psuedo Code:
    // since the inputs will *always* be first "string string" I can grab by index the first character and the next character after the space and uppercase them
    // using string interpolation, add a period in-between the capital letters
    // return the new string
// my answer given there being only 1 space in-between a 2 word string
using System;
namespace ConsoleApp 
{
    public class codewars027
    {
        public static string AbbrevName(string name)
        {
          // return $"{name[0]}.{name.ElementAt(name.IndexOf(" ") + 1)}".ToUpper(); // this answer works in IDE but not Codewars
            return $"{name[0]}.{name[name.IndexOf(' ') + 1]}".ToUpper();
        }
    }
}

// my answer using array methods
using System;
namespace ConsoleApp 
{
    public class codewars027 
    {
        public static string AbbrevName(string name)
        {
            string[] initials = name.Split(" ");
          return $"{initials[0][0]}.{initials[1][0]}".ToUpper();
        }
    }
}

// best practices and most clever
// using string and array methods with implicit return filtering with .Select() for first index of each word
using System;
using System.Linq;
public class Kata
{
       public static string AbbrevName(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();
}

// using First() and Last() for elements in an array
// this works because there are only 2 elements in the array
using System;
using System.Linq;

public class Kata
{
    public static string AbbrevName(string name)
    {
        string[] buf = name.Split(' ');

        var firstName = buf.First();
        var lastName = buf.Last();

        var oneUpper = Char.ToUpper(firstName.First());
        var twoUpper = Char.ToUpper(lastName.First());

        return $"{oneUpper}.{twoUpper}";
    }
}

// using .IndexOf() and .Substring()
public class Kata
{
  public static string AbbrevName(string name)
  {
    
    //get the index of the space
    int posOfSpace = name.IndexOf(" ");
    
    //build a string with the first character, the period, and the first character AFTER the space
    string abbrevName = name.Substring(0, 1) + "." + name.Substring(posOfSpace+1, 1);
    
    //return the result in uppercase (since some random testcases had lowercase names)
    return abbrevName.ToUpper();
  }
}

// declaring a new array and using .ToUpper() on individual substrings
using System;
using System.Linq;

public class Kata
{
  public static string AbbrevName(string name)
  {
    string[] a = name.Split(' ').ToArray();
    return $"{a[0].Substring(0,1).ToUpper()}.{a[1].Substring(0,1).ToUpper()}";
   
  }
}

// implicit return using char
using System.Linq;
public class Kata
{
  public static string AbbrevName(string name)
    => string.Join(".",name.Split(' ').Select(w=>char.ToUpper(w[0])));
}

// implicit return string interpolation similar to my original answer
public class Kata
{
  public static string AbbrevName(string name) =>
    $"{name[0]}.{name[name.IndexOf(' ') + 1]}".ToUpper();
}

// I didn't know you could use null as an argument in .Split()
using System;
using System.Linq;

public class Kata
{
  public static string AbbrevName(string s) => String.Join(".", s.Split(null).Select(r => r[0].ToString().ToUpper()));
}

// using .First() instead of index location of [0] for each element
using System.Linq;

public class Kata
{
  public static string AbbrevName(string name)
  {
    return string.Join(".", name.ToUpper().Split(' ').Select(n => n.First()));
  }
}

// using regex and concatenation
using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static string AbbrevName(string name)
  {
    MatchCollection m = Regex.Matches(name,@"\b\w");
    return (m[0] + "." + m[1]).ToUpper();
  }
}

// using .Format() and string interpolation
using System;
public class Kata
{
    public static string AbbrevName(string name)
    {
        return String.Format("{0}.{1}", Char.ToUpper(name[0]), Char.ToUpper(name[name.IndexOf(' ')+1]));
    }
}

// using foreach and .Append() with .TrimEnd()
using System.Text;
public class Kata
{
  public static string AbbrevName(string name)
  {
    var result = name.Split(" ");
    StringBuilder sb = new StringBuilder();
    foreach (string x in result)
      {
        sb.Append(x.Substring(0,1).ToUpper()+'.');
      }
    return sb.ToString().TrimEnd('.');
  }
}