// Reversed Strings
// Parameters or Edge Cases:
// Return:
// Examples:
    // 'world'  =>  'dlrow'
    // 'word'   =>  'drow'
// Psuedo Code:

// my answer and best practices
using System;
using System.Linq;

public static class Kata
{
  public static string Solution(string str) 
  {
     return new string(str.ToArray().Reverse().ToArray());
  }
}

// popular solution StackOverflow
public static class Kata
{
  public static string Solution(string str) 
  {
    char[] newstr = str.ToCharArray();
    Array.Reverse(newstr);
    return new String(newstr);
  }
}

// implicit return with .Concat() and .Reverse()
class Kata
{
  public static string Solution(string s) => string.Concat(s.Reverse());
}

// using .Concat() and .Reverse() directly on the string
public static class Kata
{
  public static string Solution(string str) 
  {
    return string.Concat(str.Reverse());
  }
}

// using .Reverse() directly on the input string?
public static class Kata
{
  public static string Solution(string str) 
  {
    return new String(str.Reverse().ToArray());
  }
}

// for loop concat to a new string
public static class Kata
{
  public static string Solution(string str) 
  {  
       string rev = "";
	       for(int c = str.Length ; c > 0; c--){
	        
	       		rev += str[c-1];
		   }
	    return rev;
  }
}

// using .ToCharArray()
public static class Kata
{
  public static string Solution(string str) 
  {
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
  }
}

// using .Join() arguments
public static class Kata
{
  public static string Solution(string str) => string.Join("",str.Reverse());
}

// using .Append()
public static class Kata
{
        public static string Solution(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length-1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }            
            return sb.ToString();
            //return new string(str.Reverse().ToArray());
        }
}