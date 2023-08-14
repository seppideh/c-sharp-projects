using System;
using System.Collections.Generic;

namespace Parenthesis
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Enter a string");
      string input = Console.ReadLine();

      var input1 = input.Replace("{", "").Replace("}", "").Replace("[", "").Replace("]", "");  //just ()
      var input2 = input.Replace("(", "").Replace(")", "").Replace("[", "").Replace("]", "");  //just {}
      var input3 = input.Replace("{", "").Replace("}", "").Replace("(", "").Replace(")", "");  //just []

      // Console.WriteLine(input1);
      // Console.WriteLine(input2);
      // Console.WriteLine(input3);

      while (input1.Contains("()") || input2.Contains("{}") || input3.Contains("[]"))
      {
        input1 = input1.Replace("()", "");
        input2 = input2.Replace("{}", "");
        input3 = input3.Replace("[]", "");
      }

      if (input1.Length == 0 && input2.Length == 0 && input3.Length == 0)
      {
        Console.WriteLine("True");
      }
      else
      {
        Console.WriteLine("False");
      }
    }
  }
}

