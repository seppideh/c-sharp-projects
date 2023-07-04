using System;
using System.Linq;

namespace commandLineProgram
{
  class Program
  {
    static void Main(string[] args)
    {
      Execute(args);
    }
    static void Execute(string[] args)
    {
      if (args[0] == "bmi" && args[1] == "--helps")
      {
        BmiHelps();
      }
      else if (args[0] == "bmi" && args[1] == "--version")
      {
        versionMethod();
      }
      else if (args[0] == "bmi" && args[1] == "--height" && args[3] == "--weight" && args.Length == 5)
      {
        var height = Convert.ToDouble(args[2]);
        var weight = Convert.ToDouble(args[4]);
        BMICalculator(weight, height);
      }
      else if (args[0] == "bmi" && args[1] == "--weight" && args[3] == "--height" && args.Length == 5)
      {
        var weight = Convert.ToDouble(args[2]);
        var height = Convert.ToDouble(args[4]);
        BMICalculator(weight, height);
      }
      else
      {
        Error();
      }
    }
    static void Error()
    {
      Console.WriteLine("Invalid command :(");
      Console.WriteLine("Use --helps switch to show help");
    }

    static void BmiHelps()
    {
      Console.WriteLine("--height\tYour height (centimeters)");
      Console.WriteLine("--weight\tYour weight (kilograms)");
      Console.WriteLine("--version\tShow current version");
      Console.WriteLine("--helps\t\tShow command list");
    }

    static void versionMethod()
    {
      Console.WriteLine("Current version is: 1:0");
    }

    static void BMICalculator(double weight, double height)
    {
      var BMI = weight / (height * height);
      string result;

      switch (BMI)
      {
        case < 18.5:
          result = "Underweight";
          break;
        case >= 18.5 and < 25:
          result = "Normal";
          break;
        case >= 25 and < 40:
          result = "Overweight";
          break;
        default:
          result = "Obese";
          break;
      }
      Console.WriteLine($"Your BMI score is: {BMI}");
      Console.WriteLine($"Your status is: {result}");
    }
  }
}

