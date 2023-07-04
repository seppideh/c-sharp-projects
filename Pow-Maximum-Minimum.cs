using System;

namespace Pow_Maximum_Minimum
{
  class Program
  {
    static void Main(string[] args)
    {
      ExecutePower();
      ExecuteMaxMin();
    }
    static void ExecutePower()
    {
      Console.WriteLine("Enter two numbers for calculating \"Power\":");
      Console.WriteLine("Enter first number:");
      double x = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter second number:");
      double y = Convert.ToDouble(Console.ReadLine());

      var result = Power(x, y);
      Console.WriteLine($"{x} power {y}: {result}");
      Console.ReadLine();
      Console.Clear();
    }
    static void ExecuteMaxMin()
    {
      Console.WriteLine("please say how many numbers do you Enter: ");
      int counter = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("please enter the numbers:");
      var numbers = new double[counter];
      for (int i = 0; i < counter; i++)
      {
        numbers[i] = Convert.ToDouble(Console.ReadLine());
      }
      var minimum = FindMinimum(numbers);
      Console.WriteLine($"the Minimum is:{minimum}");
      var maximum = FindMaximum(numbers);
      Console.WriteLine($"the maximum is:{maximum}");

    }

    static double Power(double x, double y)
    {
      return Math.Pow(x, y);
    }

    static double FindMinimum(double[] numbers)
    {
      double minvalue = numbers[0];
      foreach (var number in numbers)
      {
        if (number < minvalue)
        {
          minvalue = number;
        }
      }
      return minvalue;
    }

    static double FindMaximum(double[] numbers)
    {
      double maxvalue = numbers[0];
      foreach (var number in numbers)
      {
        if (number > maxvalue)
        {
          maxvalue = number;
        }
      }
      return maxvalue;
    }

  }
}
