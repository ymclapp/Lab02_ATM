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
        balance += depositAmount;
    }

    public void Withdrawal(decimal withdrawalAmount)
    {
      //withdrawalAmount = 20;
      //int prevBalance = balance;
      if (balance - withdrawalAmount < 0)
        throw new InvalidOperationException("Your balance is too low for this request");
        balance -= withdrawalAmount;
    }

  }


}
