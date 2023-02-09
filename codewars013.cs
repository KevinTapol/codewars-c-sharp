// Square(n) Sum
// Parameters or Edge Cases:
    // inputs will be an array of integers
    // will the array be empty? test cases have no negative values
    // can they be negative or 0? test cases shows empty or null array equate to 0
// Return:
    // square each element and return the sum of the squares
// Examples:
    // (new int[]{34, 15, 88, 2}) => 1^2 + 2^2 + 2^2 = 9
// Psuedo Code:
  // declare an int variable
  // loop through the array and multiply each elementy to itself and add the sum to the declared variable
  // return the variable 

// my answer

using System;
namespace ConsoleApp 
{
    public class codewars013 
    {
  public static int SquareSum(int[] numbers)
  { 
    int total = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
      total += numbers[i]*numbers[i];
    }
    return total;
  }
    }
}

// best practices and most clever
// You can use .Sum() similar to .map() in JavaScript in that you can make a copy of the array and mutate the elements
// using System.Linq;
public static class Kata
{
  public static int SquareSum(int[] n) => n.Sum(i => i * i);
}

// using foreach instead of a for loop
public static class Kata
{
  public static int SquareSum(int[] n)
  { 
    int sum = 0;
    foreach (int a in n){
          int b = a*a;
          sum+= b;
    }
    return sum;
  }
}

// using Math.Pow() nested inside of .Sum()
// using System;
// using System.Linq;

public static class Kata
{
  public static int SquareSum(int[] n)
  { 
    return (int)n.Sum(i => Math.Pow(i, 2));
  }
}

// using .Select() to perform the array element manipulation for squaring and iterating again with .Sum() to add them up
// using System;
// using System.Linq;

public static class Kata
{
  public static int SquareSum(int[] n)
  { 
    return n.Select(x => x * x).Sum(o => o);
  }
} 

// while loop
public static class Kata
{
  public static int SquareSum(int[] numbers)
  {
    int mySum = 0;

    int i = 0;
    while (i < numbers.Length)
    {
      mySum+= numbers[i] * numbers[i];
      i++;
    }

    return mySum;
  }
}

// is the additional (int) to avoid concatenation?
using System;
public static class Kata
{
  public static int SquareSum(int[] n)
  { 
    int count = 0;
    for(int i =0; i<n.Length; i++)
    {
      count += (int)Math.Pow(n[i],2);
      
    }
    return count;
  }
}

// .Aggregate(0,(accum, current)=>math here) reminds me of .reduce() method in JavaScript
// using System.Linq;
public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    return numbers.Aggregate(0,(accum,current)=>accum+current*current);
  }
}

// .ToList() and .Sum()
// using System.Linq;

public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    return numbers.ToList().Sum(number => number * number);
  }
}