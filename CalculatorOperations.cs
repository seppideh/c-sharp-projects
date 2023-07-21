using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
  public class CalculatorOperations
  {
    public double number1 { get; set; }
    public double number2 { get; set; }
    double result;
    string _operation;
    public string Operation
    {
      set
      {
        if (value == "+" || value == "-" || value == "*" || value == "/")
        { _operation = value; }
        else
        {
          throw new Exception("The operation in not valid");
        }
      }
    }


    public void Options()
    {
      Console.WriteLine("Options:");
      Console.WriteLine("\t+ : Add");
      Console.WriteLine("\t- : Subtract");
      Console.WriteLine("\t* : Multiply");
      Console.WriteLine("\t/ : Divide");
    }

    public double Add(double num1, double num2)
    {
      return num1 + num2;
    }
    public double Subtract(double num1, double num2)
    {
      return num1 - num2;
    }
    public double Multiply(double num1, double num2)
    {
      return num1 * num2;
    }
    public double Divide(double num1, double num2)
    {
      return num1 / num2;
    }
    public void process()
    {
      switch (_operation)
      {
        case "+":
          result = Add(number1, number2);
          break;
        case "-":
          result = Subtract(number1, number2);
          break;
        case "*":
          result = Multiply(number1, number2);
          break;
        default:
          result = Divide(number1, number2);
          break;
      }
    }
    public override string ToString()
    {
      return $"Your result: {number1}{_operation}{number2}={result}";
    }
  }
}