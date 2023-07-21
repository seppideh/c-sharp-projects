using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      var calculate = new CalculatorOperations();
      bool Continue = true;
      while (Continue)
      {
        Console.Clear();
        Console.WriteLine("------------------");
        Console.WriteLine("Calculator Program");
        Console.WriteLine("------------------");

        setCalculatorNumbers(calculate);
        calculate.Options();
        Console.Write("Enter an option:");
        // calculate.Operation = Console.ReadLine();
        try
        {
          calculate.Operation = Console.ReadLine();
          calculate.process();
          Console.WriteLine(calculate);
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message); ;
        }
        // calculate.process();
        Console.Write("Would you like to continue? (Y = yes , N = No):");
        var answer = Console.ReadLine();
        Continue = answer.ToUpper() == "Y";
      }
      Console.WriteLine("Bye!");
    }

    public static void setCalculatorNumbers(CalculatorOperations obj)
    {
      Console.Write("Enter number 1:");
      obj.number1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter number 2:");
      obj.number2 = Convert.ToDouble(Console.ReadLine());
    }
  }
}
