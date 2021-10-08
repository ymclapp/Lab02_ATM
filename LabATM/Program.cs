using System;

namespace LabATM
{
  class Program
  {
    private static readonly BankAccount account = new BankAccount();
    static void Main(string[] args)
    {
      WriteWelcome();
      int action = PromptForAction();
      if (action == 1)
      {
        ViewBalance();
      }

      else if (action == 2)
      {
        PromptAndDeposit();
      }

      else if (action == 3)
      {
        PromptAndWithdraw();
      }

      else if (action == 0)
      {
        return;
      }

      else
      {
        Console.WriteLine("Please enter one of the correct options");
      }
    }

      


      static void WriteWelcome()
      {
        Console.WriteLine("Welcome to your friendly ATM!\n");
      }//this is the end of the WriteWelcome()

      static int PromptForAction()
      {
        String promptResponse;
        int userResponse;
        try
        {
          Console.WriteLine("Shall we play a game?  What would you like to do today?");
          Console.WriteLine("Enter 1 if you would like your current balance");
          Console.WriteLine("Enter 2 if you would like to make a deposit");
          Console.WriteLine("Enter 3 if you would like to make a withdrawal");
          Console.WriteLine("Enter 0 if you would like to quit\n");
          Console.WriteLine("Please enter a number from the selections above:  ");
          promptResponse = Console.ReadLine();
          userResponse = Convert.ToInt32(promptResponse);
          Console.WriteLine ("You selected option " + userResponse);
        return userResponse;
        }
        catch (FormatException)
        {
          Console.WriteLine ("There was an error");
          return 0;
        }
      }//this is the end of the PromptForAction()

    static int PromptAndDeposit()
    {
      String promptResponse;
      int userDepResponse;
      try
      {
        Console.WriteLine("Please enter the amount that you would like to deposit:  ");
        promptResponse = Console.ReadLine();
        userDepResponse = Convert.ToInt32(promptResponse);
        Console.WriteLine("You are depositing $" + userDepResponse);
        return userDepResponse;
      }
      catch (FormatException)
      {
        Console.WriteLine("There was an error");
        return 0;
      }
     }//this is the end of the class PromptAndDeposit()

    static int PromptAndWithdraw()
    {
      String promptResponse;
      int userWithResponse;
      try
      {
        Console.WriteLine("Please enter the amount that you would like to withdraw:  ");
        promptResponse = Console.ReadLine();
        userWithResponse = Convert.ToInt32(promptResponse);
        Console.WriteLine("You are withdrawing $" + userWithResponse);
        return userWithResponse;
      }
      catch (FormatException)
      {
        Console.WriteLine("There was an error");
        return 0;
      }
    }//this is the end of the PromptAndWithdraw()

      static int ViewBalance()
      {
        String promptResponse;
        int userWithResponse;
      try
      {
        Console.WriteLine("Please enter the amount that you would like to withdraw:  ");
        promptResponse = Console.ReadLine();
        userWithResponse = Convert.ToInt32(promptResponse);
        Console.WriteLine("Your balance is:  $");
        return userWithResponse;
      }
      catch (FormatException)
      {
        Console.WriteLine("There was an error");
        return 0;
      }//this is the end of the ViewBalance()
     }//this is the end of the Main()
  }//this is the end of the class Program
}//this is the end of the namespace LabATM
