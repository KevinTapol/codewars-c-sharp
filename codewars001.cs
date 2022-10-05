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