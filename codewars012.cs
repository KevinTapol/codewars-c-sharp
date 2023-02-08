// Find the smallest integer in the array
// Parameters or Edge Cases:
    // inputs will be an array of integers
    // array will not be empty
    // integers can be negative or positive
// Return:
    // the smallest integer of the input array
// Examples:
    // [34, 15, 88, 2] => 2
    // [34, -345, -1, 100] => -345
// Psuedo Code:
    // either for loop through the array and compare each value to the next value in the array taking the min value
    // or use a similar method of math.min() with spread in JavaScript and Python to C#

// my for loop answer
using System;
public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
        int small = args[0];
        for(int i = 0; i < args.Length; i++)
        {
            if(small > args[i])
            {
                small = args[i];
            }
        }
        return small;
    }
}

// my answer using Enumerable as a spread similar to ... for JavaScript and *args for Python
// to use Enumerable you must use using System.Ling;
using System.Linq;

public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
      return Enumerable.Min(args);
    }
}

// best practices and most clever
// I didn't know you could use .Min() directly on an array in C#!!
using System.Linq;

public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
      return args.Min();
    }
}

// from is a keyword used in Linq to specify a data source using a query using select and where statments similar to SQL 
using System.Linq;
public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
        return (from e in args orderby e ascending select e).FirstOrDefault();
    }
}

// implicit return arrow function of a from statement
using System.Linq;
public class Kata 
{
    public static int FindSmallestInt(int[] args) => (from e in args orderby e ascending select e).FirstOrDefault();
}

// using foreach instead of a for loop
public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
      int small = args[0];
      foreach(int num in args) {
        if(small > num) {
          small = num;
        }
      }
      return small;
    }
}

// completely forgot about .Sort() and grab the first element in the array
using System;
using System.Collections;

public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
      Array.Sort(args);
      
      return args[0];
    }
}

// nested for loop
public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
           int smallest = args[0];

            for (int i = 0; i < args.Length; i++)
            {
                for (int k = 0; k < args.Length; k++)
                {
                    if (smallest > args[k])
                    { 
                        smallest = args[k];
                        break;
                    }

                }
            }

            return smallest;
    }
}