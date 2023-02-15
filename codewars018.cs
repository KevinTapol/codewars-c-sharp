// Counting Sheep
// Parameters or Edge Cases:
    // input will be an array of boolean true or false elements
    // will array be empty?
// Return:
    // the total count of boolean true in the input array
// Examples:
    // [true,  true,  true,  false,true,  true,  true,  true ,true,  false, true,  false,true,  false, false, true ,true,  true,  true,  true ,false, false, true,  true] // 17
// Psuedo Code:
    // declare an integer variable and set it equal to 0
    // itertate through the array and for each boolean true in the array add 1 to the declared variable
    // return the declared variable

// my answer brute force for loop
using System;
namespace ConsoleApp 
{
    public class codewars018
    {
  public static int CountSheeps(bool[] sheeps)
  {
    // declare an integer variable and set it equal to 0
    int total = 0;
    // itertate through the array and for each boolean true in the array add 1 to the declared variable
    for (int i = 0; i < sheeps.Length; i++)
    {
        if(sheeps[i] == true){
            total +=1;
        }
    }
    // return the declared variable
    return total;
  }
    }
}

// my answer using array methods of .Where() 
using System;
namespace ConsoleApp 
{
    public class codewars018
    {
  public static int CountSheeps(bool[] sheeps)
  {
    // declare an integer variable and set it equal to 0
    // itertate through the array and for each boolean true in the array add 1 to the declared variable
    return sheeps.Where(x => x == true).Count();
    // return the declared variable
  }
    }
}
// my answer using array methods implicit return arrow function
using System;
namespace ConsoleApp 
{
    public class codewars018
    {
  public static int CountSheeps(bool[] sheeps) => sheeps.Where(x => x == true).Count();
    }
}

// best practices and most clever
// using .Count()
// this is a shorter version of using sheeps.Where(s => s == true).Count()
using System;
using System.Linq;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    return sheeps.Count(s => s);
  }
}

// using foreach keep in mind the word bool in the conditional statement
using System;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    int count = 0;
    foreach (bool sheep in sheeps) {
      if(sheep) count++;
    }
    return count;
  }
}

// same answer best practices and most clever but using the full word sheeps intead of s
using System;
using System.Linq;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    return sheeps.Count(sheep => sheep);
  }
}

// implicit return of above
using System.Linq;

class Kata
{
  public static int CountSheeps(bool[] sheeps) => sheeps.Count(s => s);
}

// specifying int count for boolean
using System;
using System.Linq;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    return (int)sheeps.Count(x => x == true);
  }
}