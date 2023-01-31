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