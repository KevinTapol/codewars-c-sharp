// Basic Mathematical Operations
// Parameters or Edge Cases:
    // inputs will be in order a string +-*/, an integer, and another integer
    // inputs will not be empty
// Return:
    // return the maths given the sign and integers
// Examples:
    // ('+', 4, 7) --> 11
    // ('-', 15, 18) --> -3
    // ('*', 5, 5) --> 25
    // ('/', 49, 7) --> 7
// Psuedo Code:
    // if the first character is + then return the sum of the integers
    // if the first character is - then subtract the first integer by the second
    // if the first character is * then return the product of the integers
    // else return the first integer divided by the second integer

// my answer
// using System;
// namespace ConsoleApp 
// {
//     public class codewars023
//     {
//     public static double basicOp(char operation, double value1, double value2)
//     {
//       if(operation == '+')
//       {
//         return value1 + value2;
//       }
//       else if (operation == '-')
//       {
//         return value1 - value2;
//       }
//       else if (operation == '*')
//       {
//         return value1*value2;
//       }
//       else
//         return value1 / value2;
//     }
//     }
// }

// my answer implicit return nested ternaries
using System;
namespace ConsoleApp 
{
    public class codewars023
    {
    public static double basicOp(char o, double a, double b) => o == '+'? a + b : (o == '-' ? a - b : (o == '*' ? a*b : a / b ) );
    }
}

// best practices 
// using switch case 
namespace Solution
{
  public static class Program
  {
    public static double basicOp(char op, double val1, double val2)
    {
      switch(op){
        case '+': return val1+val2;
        case '-': return val1-val2;
        case '*': return val1*val2;
        case '/': return val1/val2;
        default:
           throw new System.ArgumentException("Unknown operation!", op.ToString());
      }
    }
  }
}

// most clever
// using DataTable() and .Compute()
using System;
using System.Data;

public static class Program
{
  public static double basicOp(char op, double a, double b)
  {
    return Convert.ToDouble(new DataTable().Compute($"{a}{op}{b}", ""));
  }
}

// same as most clever but putting the Convert.ToDouble() at the end
using System.Data;
using System;
namespace Solution
{
  public static class Program
  {
    public static double basicOp(char op, double val1, double val2)
    {
    DataTable dt = new DataTable();
    var v = dt.Compute($"{val1} {op} {val2}","");
      return Convert.ToDouble(v);
    }
  }
}

// using switch with implicit arrow function throw exception
using System;

public static class Program
{
  public static double basicOp(char op, double a, double b)
  {
    return op switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        '/' => a / b,
        _ => throw new ArgumentException("Unknown operation", $"{op}")
    };
  }
}


// using Dictionary
namespace Solution
{
  using System;
  using System.Collections.Generic;
  
  public static class Program
  {
    public static double basicOp(char op, double val1, double val2)
    {
      return new Dictionary<char, Func<double, double, double>>()
      {
          { '+', (a, b) => a + b },
          { '-', (a, b) => a - b },
          { '*', (a, b) => a * b },
          { '/', (a, b) => a / b }
      }[op](val1, val2);
    }
  }
}

// Dictionary with implicit return
using System;
using System.Collections.Generic;

namespace Solution
{
  public static class Program
  {
      private readonly static Dictionary<Char, Func<Double, Double, Double>> Functions = new Dictionary<Char, Func<Double, Double, Double>>
      {
        { '+', (a,b) => a + b  },
        { '-', (a,b) => a - b  },
        { '*', (a,b) => a * b  },
        { '/', (a,b) => a / b  },
      };
    public static double basicOp(char op, double val1, double val2)
      => Functions[op](val1, val2);
  }
}

// cleaner version of nested ternaries
namespace Solution
{
    public static class Program
    {
        public static double basicOp(char op, double val1, double val2)
        {
            return op == '+' ? val1 + val2
                : op == '-' ? val1 - val2
                : op == '*' ? val1 * val2
                : val1 / val2;
        }
    }
}

// DataTable() .ToDouble() .Compute() .ToString()
using System.Data;
using System;

namespace Solution
{
  public static class Program
  {
    public static double basicOp(char op, double val1, double val2)
    {
      DataTable dt = new DataTable();      
      return Convert.ToDouble(dt.Compute(val1.ToString()+op+ val2.ToString(),""));
      
    }
  }
}