using System;

namespace rock_paper_scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      bool playAgain = false;
      do
      {
        var userAction = PlayerAction();
        var computerAction = ComputerAction();

        Console.WriteLine($"Player: {userAction}");
        Console.WriteLine($"Computer: {computerAction}");

        var playResult = Play(userAction, computerAction);
        Console.WriteLine(playResult);

        playAgain = playAgainFunction();

      } while (playAgain);
      Console.WriteLine("Thanks for playing!");
    }

    static string PlayerAction()
    {
      Console.Write("Enter Rock,Paper,or Scissors:");
      var user_action = Console.ReadLine();
      return user_action.ToLower();
    }
    static string ComputerAction()
    {
      Random rand = new Random();
      string[] playActions = { "rock", "paper", "scissors" };
      var computer_action = playActions[rand.Next(playActions.Length)];
      return computer_action.ToLower();
    }

    static Boolean playAgainFunction()
    {
      Console.Write("Would you like to play again (Y/N):");
      var answer = Console.ReadLine();
      return answer.ToLower() == "y";

    }

    static string Play(string user_action, string computer_action)
    {
      string result;

      switch (user_action)
      {
        case "rock":
          if (computer_action == user_action)
          {
            result = "It's a draw!";
          }
          else if (computer_action == "paper")
          {
            result = "You lose!"; ;
          }
          else
          {
            result = "You win!"; ;
          }
          break;
        case "paper":
          if (computer_action == user_action)
          {
            result = "It's a draw!";
          }
          else if (computer_action == "scissors")
          {
            result = "You lose!"; ;
          }
          else
          {
            result = "You win!"; ;
          }
          break;
        case "scissors":
          if (computer_action == user_action)
          {
            result = "It's a draw!";
          }
          else if (computer_action == "rock")
          {
            result = "You lose!"; ;
          }
          else
          {
            result = "You win!"; ;
          }
          break;
        default:
          result = "you Enter invalid input!";
          break;
      }
      return result;
    }
  }
}

