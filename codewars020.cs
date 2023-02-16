// Return Strings
// Parameters or Edge Cases:
    // inputs will be a single string name
    // the string will not be empty
// Return:
    // "Hello, <name> how are you doing today?" <name> being the input
// Examples:
    // "Ryan" => "Hello, Ryan how are you doing today?"
// Psuedo Code:
    // using string interpolation, break the string up into 3 portions 
    // that being before the input and after
    // then concat each piece together remembering to implement white space for sentence clarity

// my answer
using System;
namespace ConsoleApp 
{
    public class codewars020
    {
        public static string Greet(string name)
        {
            return "Hello, " + $"{name}" + " how are you doing today?";
        }
    }
}

// my answer implicit return arrow function
using System;
namespace ConsoleApp 
{
    public class codewars020
    {
        public static string Greet(string name) => "Hello, " + $"{name}" + " how are you doing today?";
    }
}

// best practices and most clever
// I did not know that $"{name}" could include the entire string similar to JavaScript template literals `` or Python f string 
using System;

public static class Kata
{
  public static string Greet(string name)
  {
    return $"Hello, {name} how are you doing today?";
  }
}

// here they are using a ternary to check if the input is null
using System;

public static class Kata
{
  public static string Greet(string name)
  {
    return !String.IsNullOrEmpty(name) ? $"Hello, {name} how are you doing today?" : "Name is empty.";         
    
  }
}

// using .Insert() to specify the index location for the input and what to be added
using System;

public static class Kata
{
  public static string Greet(string name)
  {
    //throw new NotImplementedException("Greet is not implemented.");
    string str = "Hello,  how are you doing today?";
    return str.Insert (7, name);
  }
}

// using .Replace() instead of string interpolation
using System;

public static class Kata
{
  public static string Greet(string name)
  {
              string AA = "Hello, <name> how are you doing today?";

            string BB = AA.Replace("<name>",name);
            return (BB);

  }
}

// using .Format() similar to Python
using System;

public static class Kata
{
  public static string Greet(string name)
  {
    return String.Format("Hello, {0} how are you doing today?", name);
  }
}

// classic concatenation but I was wondering if there was something extra required to use a variable in C#
using System;

public static class Kata
{
  public static string Greet(string name)
  {
    return "Hello, "+name+" how are you doing today?";
  }
}

// using a switch case if the input is empty
using System;

public static class Kata
{
  public static string Greet(string name)
  {
    switch(name){
        case "":
        return "Greet is not implemented.";
        break;
        
        default:
        return String.Format("Hello, {0} how are you doing today?",name);
        break;
        
    }
    
  }
}

// checking if the input is either null or empty
using System;

public static class Kata
{
  public static string Greet(string name)
  {
    if (name != null || name !=""){
      return "Hello, " + name + " how are you doing today?";
    } 
    else{
      throw new NotImplementedException("Greet is not implemented.");
    }
  }
}