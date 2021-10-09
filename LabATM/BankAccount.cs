using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabATM
{
  public class BankAccount
  {
    private decimal balance;  //balance here will default to 0 if no value given

    

    public decimal GetBalance()
    {
      return this.balance;
    }

    public void Deposit(decimal depositAmount)
    {
      if (depositAmount < 0)
        throw new ArgumentOutOfRangeException("Amount must be positive");
      else balance += depositAmount;
      WriteToLog(depositAmount);
    }

    public void Withdrawal(decimal withdrawalAmount)
    {
       if (balance - withdrawalAmount < 0)
        Console.WriteLine("Your balance is too low for this request");
      else if (withdrawalAmount < 0)
        Console.WriteLine("Please enter a positive amount to withdraw");
       else balance -= withdrawalAmount;
      WriteToLog(withdrawalAmount);
    }//end of withdrawalAmount

    public static void WriteToLog(decimal amount)
    {
      //string fileText = File.ReadAllLines(filename);
      string logMessage = $"{DateTime.Today: yyyy-MM-dd}: {amount}\n";
      File.AppendAllText("log.txt", logMessage);
    }//end of WriteToLog()

    public static void ClearLogFile()
    {
      File.WriteAllText("log.txt", "");
    }//end of ClearLogFile()
  }//end of BankAccount class
}//end of namespace LabATM
