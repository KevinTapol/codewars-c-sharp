// debug code
//  public class CustomMath {
//      public static int multiply(int a, int b) {
//          return a b;
//      }
//  }

// my answer and best practices
// The only difference I see here from javascript is the class format instead of function format.
// It makes me wonder if I needed to include using System; in my first C# codewars.
// This makes me think I'll be able to pick up C# faster than I initially thought.
public class CustomMath {
    public static int multiply(int a, int b) {
        return a * b;
    }
}

// most clever
// It looks like arrow functions in C# aren't that different from javascript.
public class CustomMath {
    public static int multiply(int a, int b) => a * b;
}

// for loop
// same start stop step in C# as python and javascript
public class CustomMath {
    public static int multiply(int a, int b) {
        int i;
        int tempA = a;
        for (i = 0; i < b - 1; ++i) {
            a = a + tempA;
        }
        return a;
    }
}      //Multiplication by addition