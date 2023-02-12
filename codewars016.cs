// Function 1-hello world
// Parameters or Edge Cases:
    // no inputs
    // the class MUST BE public static class Kata for Codewars!!
    // the function MUST BE public static string greet() for Codewars!!
    // I am using my answer format to print out test cases to the Console
// Return:
    // "hello world!" when the function is run
// Examples:
    // 
// Psuedo Code:
    // 

// my answer 
// using System;
// namespace ConsoleApp 
// {
//     public static class codewars016
//     {
//         public static string greet()
//         {
//           return "hello world!";
//         }
//     }
// }

// my answer implicit return
// using System;
// namespace ConsoleApp 
// {
//     public static class codewars016
//     {
//         public static string greet() => "hello world!";
//     }
// }

// my answer for Codewars not for VS Code to print out test cases to Console!! best practices 
// using System;

// public static class Kata
// {
//     public static string greet() => "hello world!";
// }


// most clever
using System;
using System.Linq;

public static class Kata
{
  public static string greet()
  {
    string[] hello ={
    
                     "hhh   hhh  eeeeeeeee  lll        lll             ooo",        
                     "hhh   hhh  eeeeeeeee  lll        lll          ooo   ooo",    
                     "hhh   hhh  eee        lll        lll         ooo     ooo",    
                     "hhhhhhhhh  eeeeee     lll        lll        ooo       ooo", 
                     "hhhhhhhhh  eeeeee     lll        lll        ooo       ooo", 
                     "hhh   hhh  eee        lll        lll         ooo     ooo",    
                     "hhh   hhh  eeeeeeeee  lllllllll  lllllllll    ooo   ooo",    
                     "hhh   hhh  eeeeeeeee  lllllllll  lllllllll       ooo",      
                     
          "ww            w             w      ooo       rrrrrrrr     lll        dddddddd",         
           "ww           ww           w    ooo   ooo    rrr   rrr    lll        dddddddddd",       
            "ww         w ww         w    ooo     ooo   rrr    rrr   lll        ddd     ddd",     
             "ww       w   ww       w    ooo       ooo  rrr   rrr    lll        ddd      ddd",   
              "ww     w     ww     w     ooo       ooo  rrrrrrr      lll        ddd      ddd",  
               "ww   w       ww   w       ooo     ooo   rrr   rrr    lll        ddd     ddd",    
                "ww w         ww w         ooo   ooo    rrr    rrr   lllllllll  dddddddddd ",    
                 "ww           ww             ooo       rrr     rrr  lllllllll  dddddddd "};
    
    string resString = String.Join("", String.Concat(hello).Replace(" ", "").GroupBy(x => x).Select(x => x.Key));
    return String.Concat(resString[0], resString[1], resString[2], resString[2], resString[3], " ", resString[4], resString[3], resString[5], resString[2], resString[6],"!");
  }
}

// using char and inputs similar to JS template literals or f string/ format for Python
public static class Kata
{
  public static string greet()
  {
    string[] array = new string[]
    {
      $"{(char)104}{(char)101}{(char)108}{(char)108}{(char)111}",
      $"{(char)119}{(char)111}{(char)114}{(char)108}{(char)100}{(char)33}"
    };
    return string.Join(" ", array);
  }
}

// using unicode char
public static class Kata
{
  public static string greet() => new string(new char[] { '\u0068', '\u0065', '\u006C', '\u006C', '\u006F', '\u0020', '\u0077', '\u006F', '\u0072' , '\u006C', '\u0064', '\u0021' });
}

// using "\n" for new line with Console.Write()
using System;

public static class Kata
{
  // Write a public static method "greet" that returns "hello world!"
  public static string greet()
  {
    foreach (Int64 c in new long[] { 0x14401100505, 0x16589102525, 0x15455575557, 0x5455505535, 0x16448A02565 })
    {
        for (int i = 0; i < 42; i++)
        {
            Console.Write((i > 40) ? "\n" : (c & 1L << i) > 0 ? "#" : " ");
        }
    }
    return "hello world!";
  }
}

// using arrays and appending
using System.Text;
public static class Kata
{
  public static string greet() {
    char[] helloWorld = new char[] {'h','e','l','o',' ','w','r','d','!'};
    int[] reference = new int[] {0,1,2,2,3,4,5,3,6,2,7,8};
    StringBuilder sb = new StringBuilder();
    foreach (int num in reference) sb.Append(helloWorld[num]);
    return sb.ToString();
  }
}

// using a nested while loop inside a for loop
using System;
public static class Kata
{
  public static string greet(){
    Random r = new Random();
    string res = "";
    for (int i = 0; i < "hello world!".Length; i++){
      while(r.Next("hello world!".Length) == "hello world!"[i]){
        
      }
      res += "hello world!"[i];
    }
    return res;
  } 
}

// joining an array but with set/dict/object handlebars
using System.Collections.Generic;
using System;

public static class Kata
{
  public static string greet()
  {
    List<char> greeting = new List<char>()
    {
      'h','e','l','l','o',' ','w','o','r','l','d','!'
    };
    
    return String.Join("", greeting);
    
  }
}

// concating a list back into a sting
public class Kata
{
    public static string greet()
    {
        return string.Concat('h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd', '!');
    }
}

// nested for loop
using System;

public static class Kata
{
  public static string greet() {
    string helloWorld = "hello world!";
    for (int j = 0; j < 100000; j++) {
      for (int i = 0; i < helloWorld.Length; i++) {
        Console.Write(helloWorld[i]);
      }
    }
    
    return helloWorld;
  }
}