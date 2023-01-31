// Convert boolean values to string 'Yes' or 'No'
// Parameters or Edge Cases:
    // inputs will be boolean true or false
// Return:
    // 'Yes' if input is boolean true else 'No'
// Examples:
    // true => 'Yes'
    // false => 'No'
// Psuedo Code:

// my answer
using System;
using System.Linq;

public static class Kata
{
  public static string boolToWord(bool word)
  {
    if(word == true)
    {
    return "Yes";
    }
    else{return "No";}
  }
}

// best practices 
// truthy ternary
public static class Kata
{
  public static string boolToWord(bool word)
  {
    return word ? "Yes" : "No";
  }
}

// most clever 
// implicit return truthy ternary
public static class Kata
{
  public static string boolToWord(bool word) => word ? "Yes": "No";
}

// declaring variables
public static class Kata
{
  static string BOOL_FALSE = "No";
  static string BOOL_TRUE = "Yes";

  public static string boolToWord(bool word)
  {
    return word ? BOOL_TRUE : BOOL_FALSE;
  }
}

// switch case
public static class Kata
{
  public static string boolToWord(bool word)
  {
    //TODO
    string result = "";
    switch (word)
    {
      case true:
          result = "Yes";
          break;
      case false:
          result = "No";
          break;
    }
    return result;
  }
}

//  I didn't know for Codewars in C# you can use this format
class Kata
{
  public static string boolToWord(bool w) => w ? "Yes" : "No";
}

// return no unless the if statement is met
public static class Kata
{
  public static string boolToWord(bool word)
  {    
      if (word) { return "Yes"; }
      return "No";
  }
  
}

// multiple conditions
public static class Kata
{
  public static string boolToWord(bool word)
  {
    if (word==true)
    {
      return "Yes";
    }
    else if (word==false)
    {
      return "No";
    }
    return "";
  }
}