// Parameters or Edge Cases:
// Return: string "Even" for even numbers or "Odd" for odd numbers.
// Examples:
//          [Test]
//              public void MyTest()
//              {
//                Assert.AreEqual("Even", SolutionClass.EvenOrOdd(2));
//                Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(1));
//                Assert.AreEqual("Even", SolutionClass.EvenOrOdd(0));
//                Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(7));
//                Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(-1));
//              }
// Psuedo Code: divide by 2 and check if there is a remainder by using modulus
//              if there is no remainder then the input is even else odd


// my answer, best practices and most clever
using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      return number % 2 == 0 ? "Even" : "Odd";
    }
  }
}

// if else
using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      // Code goes here...
      if(number % 2 == 0)
      {
        return("Even");
      }
      else
      {
        return("Odd");
       }
    }
  }
}

// I'm still learning C# sytanx but this looks like an arrow function in javascript
using System;

namespace Solution
{
  public class SolutionClass
  {
    public static Func<int,string> EvenOrOdd = (x) => x % 2 == 0 ? "Even" : "Odd";
  }
}

// for loop
using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
    
      bool isEven = false;
      string solution;
      int[] evenNumbers = {0, 2, 4, 6, 8};
      
      string bigNumber = number.ToString();
      
      for (int i = 0; i < evenNumbers.Length; i++)
      {
        if (bigNumber.EndsWith("0"))
        {
          isEven = true;
          break;
        }
        else if (bigNumber.EndsWith("2"))
        {
          isEven = true;
          break;
        }
        else if (bigNumber.EndsWith("4"))
        {
          isEven = true;
          break;
        }
        else if (bigNumber.EndsWith("6"))
        {
          isEven = true;
          break;
        }
        else if (bigNumber.EndsWith("8"))
        {
          isEven = true;
          break;
        }
      } 
      
      if (isEven)
      {
        solution = "Even";
      }
      else
      {
        solution = "Odd";
      }
      
      return solution;
    }
  }
}