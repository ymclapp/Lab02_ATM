using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabATM
{
  public class BankAccount
  {
    private decimal balance;  //balance here will default to 0 if no value given
    public decimal GetBalance()
    {
      return balance;
    }

    public void Deposit(decimal depositAmount)
    {
      if (depositAmount < 0)
        throw new ArgumentOutOfRangeException("Amount must be positive");
      else balance += depositAmount;
    }

    public void Withdrawal(decimal withdrawalAmount)
    {
       if (balance - withdrawalAmount < 0)
        Console.WriteLine("Your balance is too low for this request");
      else if (withdrawalAmount < 0)
        Console.WriteLine("Please enter a positive amount to withdraw");
       else balance -= withdrawalAmount;
    }

  }


}
