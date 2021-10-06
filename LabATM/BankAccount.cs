using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabATM
{
  public class BankAccount
  {
    public int Account()
    {
      int balance = 0;
      return balance;
    }

    public int Deposit(int balance)
    {
      int depositAmount = 500;
      //int prevBalance = balance;
      int newBalance = balance + depositAmount;
      return newBalance;
    }

    public int Withdrawal(int balance)
    {
      int withdrawalAmount = 20;
      //int prevBalance = balance;
      int newBalance = balance - withdrawalAmount;
      return newBalance;
    }

  }


}
