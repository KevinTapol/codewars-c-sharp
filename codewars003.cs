// Opposite number
// Parameters or Edge Cases:
    // input will be and integer or floating point number
// Return:
    // return the opposite value that when added together results in 0
// Examples:
    // 1: -1
    // 14: -14
    // -34: 34
// Psuedo Code:
    // return the input multiplied by -1

// my answer, best practices and most clever
using System;

public class Kata
    {
        public  static int Opposite(int number)
        {
            Console.WriteLine(number);
            return -number;
        }
    }

// implicit return
// using System;

public class Kata
    {
        public  static int Opposite(int number) => -number;
    }

// multiplying by negative 1 using * -1 
// using System;

public class Kata
    {
        public  static int Opposite(int n)
        {
            return n * -1;
        }
    }

// subtracting the number by itself * 2 
// using System;

public class Kata
    {
        public  static int Opposite(int number)
        {
            // Happy Coding
            return number - (number * 2);
        }
    }

// checking to see if the input contains -
// using System;
// using System.Linq;

public class Kata
    {
        public  static int Opposite(int num)
        {
          return num.ToString().Contains('-') ? 
                 Int32.Parse(num.ToString().Substring(1)) : 
                 Int32.Parse("-" + num.ToString());
        }
    }

// if the input is less than 0 return the absolute value else -input
// using System;

public class Kata
    {
        public  static int Opposite(int number)
        {
           if (number<0){ number = Math.Abs(number);}
          else{number = number -number -number;}
          return number;
        
        }
    }

// multiple conditions
// using System;

public class Kata
    {
        public  static int Opposite(int number)
        {  
        
            int answer = 1;
            
            if(number > 0) {
              answer *= -number;
            }
            else if(number < 0) {
              answer *= -number;
            }
            else if(number == 0) {
              answer = 0;
            }
            
            return answer;
        }
    }