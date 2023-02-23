// Beginner - Lost Without a Map
// Parameters or Edge Cases:
    // input will be an array of integers
    // array will not be empty
// Return:
    // a new array with each value doubled
// Examples:
    // [1, 2, 3] --> [2, 4, 6]
// Psuedo Code:
    // declare a new array and iterate through the input array multiplying each element by 2
    // return the new array

// my answer best practices and most clever
using System;
namespace ConsoleApp 
{
    public class codewars026
    {
        public static int[] Maps(int[] x)
        {
            return x.Select(e => e*2).ToArray();
        }
    }
}

// for loop creating an array and multiplying each element by 2
using System;
public class Kata
{
   public static int[] Maps(int[] x)
        {
            for(int i = 0;i<x.Length;i++)
            {
                x[i] *= 2;
            }
            return x;
        }
}

// using Array.ConvertAll() to create a new array and manipulate each element
using System;
public class Kata
{
  public static int[] Maps(int[] x)
  {
    return Array.ConvertAll(x, n => n * 2);
  } 
}

// using list instead of array
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] Maps(int[] x)
        {
            List<int> xList = x.ToList();
            List<int> xList2 = new List<int>();

            foreach (var item in xList)
            {
                xList2.Add(item * 2);
            }
            return xList2.ToArray();
        }
}

// using IEnumberagble<int> instead of int[]
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<int> Maps(IEnumerable<int> input) => input.Select(i => i * 2);
}

// using foreach
public class Kata
{
  public static int[] Maps(int[] arrayDeInt)
  {
    
    int indices = 0;
    foreach (int dobro in arrayDeInt)
    {
        arrayDeInt[indices] = dobro * 2;
        ++indices;
    }
    
    return arrayDeInt;
  }
}

// declaring a new array
// int[] myArray = new int[0];
// int[] myArray = Array.Empty<int>();
public class Kata
{
  public static int[] Maps(int[] x)
  {
 
    int[] x2 = new int[x.Length];
    for(int i = 0; i < x.Length
; i++) x2[i] = 2 * x[i];
    return x2;
  }
}

// using list and list methods .Add()
using System.Collections.Generic;

public class Kata
{
  public static int[] Maps(int[] x)
  {
    List<int> nums = new List<int>();

    for (int i = 0; i < x.Length; i++) 
    {
      nums.Add(x[i] * 2);
    }
    int[] doubled = nums.ToArray();
    return doubled;
  }
}