// Sum of Positive
// Parameters or Edge Cases:
    // input will be an array of integers that can be negative
    // input array can contain NO positive values
// Return:
    // the sum of all the positive integers in the array
    // if the input array contains no positive values then return 0
// Examples:
    // [1,-4,7,12] => 1 + 7 + 12 = 20
// Psuedo Code:
    // declare an int sum variable equal to 0
    // iterate through the input array and if the element is equal to or greater than 0 add it to sum
    // return sum this way if there is no positive integers default will be 0

// my answer
using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    // declare an int sum variable equal to 0
    int sum = 0;
     // iterate through the input array and if the element is equal to or greater than 0 add it to sum
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 0)
        {
            sum += arr[i];
        }
    }
    // return sum this way if there is no positive integers default will be 0
    return sum;
    
  }
}


// best practices and most clever
public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    return arr.Where(x => x > 0).Sum();
  }
}

// very clever
// using array methods .Sum() with a nested arrow function iterating through each element with a ternary
public class Kata
{
  public static int PositiveSum(int[] arr)
  {
  return arr.Sum(c => (c < 0 ? 0 : c));
  }
}

// check for null array
// using foreach instead of for loop with conditionals
public class Kata
{
  public static int PositiveSum(int[] arr)
  {
            int sum = 0;

            if (arr != null)
            {
                foreach (int i in arr)
                {
                    if (i > 0)
                    {
                        sum += i;
                    }
                    else
                    {
                        sum += 0;
                    }
                }
                return sum;
            }
            return 0;
        }
}

// using array method .Where() with a nested arrow function and .Sum() after the fact
public class Kata
{
  public static int PositiveSum(int[] arr) => arr.Where( x => x > 0).Sum();

}

// using from statement with select
public class Kata
{
  public static int PositiveSum(int[] arr)
  {
  	return (from n in arr
    			 where n > 0
           select n).Sum();
  }
}

// using Math.Max()
public class Kata
{
  public static int PositiveSum(int[] arr) => arr.Sum(x => Math.Max(0, x));
}

// checking if array length is 0 or null
public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    if(arr.Length == 0 || arr == null)
    {
      return 0;
    }
    
    int sum = 0;
    foreach (int num in arr)
    {
      if(num >0)
      {
        sum += num;
      }
    }
    
    return sum;
  }
}

// using array method Aggregate()
public class Kata
{
  public static int PositiveSum(int[] arr)
  {
  return arr.Aggregate(0, (e,r) =>(r>0?r+e:e));

  }
}

// using array method Any()
public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    // Your code here
    
    return arr.Any()? arr.Where(m => m>0).Sum():0;
  }
}