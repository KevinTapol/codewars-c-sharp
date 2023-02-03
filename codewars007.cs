// Convert boolean values to strings 'Yes' or 'No'
// Parameters or Edge Cases:
    // inputs will be either boolean true or false
// Return:
    // 'Yes' for boolean else 'No'
// Examples:
    // true => 'Yes'
    // false => 'No'
// Psuedo Code:
    // if the input is boolean true return 'Yes' else no using truthy

// my answer and best practices
using System;
using System.Linq;

public static class Kata
{
  public static string boolToWord(bool word)
  {
      if(word == true)
      {
        return("Yes");
      }
      else
      {
        return("No");
       }
  }
}

// most clever
// truthy ternary implicit return arrow function EXACTLY like JavaScript!!!
public static class Kata
{
  public static string boolToWord(bool word) => word ? "Yes": "No";
}

// declaring variable strings with truthy ternary implicit return
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

// truthy but with if else statements
public static class Kata
{
  public static string boolToWord(bool word)
  {    
      if (word) { return "Yes"; }
      return "No";
  }
  
}

// creating a dictionary like Python or object like JavaScript
public static class Kata
{
  public static string boolToWord(bool word)
  {
    var dict = new Dictionary<bool,string>{{true,"Yes"},{false,"No"}};
    return dict[word];
  }
}

// if else checking if the input is boolean if yes go to switch case if no throw new Exception();
//  with a nested switch case checking if the boolean input is true or false
public static class Kata
{
  public static string boolToWord(bool word)
  {
    if(word is bool)
    {
      if(word.ToString() is string _wordstr)
      {
        switch(_wordstr)
        {
            case "True": return "Yes";
            case "False": return "No";
            default: return "Maybe";
        }
      }
    }
    throw new Exception("Then unimaginable have happened. Call the priest with holy water. Only he can help");
  }
}