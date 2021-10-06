using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using LabATM;

namespace Lab02ATM.Tests
{
  public class BankAccount_erTests
  {
    [Fact]
    public void ex_FizzBuzz_returns_1_given_1()
    {
      //Arrange
      //FizzBuzzer fb = new FizzBuzzer();
      //Act
      //string result = fb.FizzBuzz(1);
      //Assert
      //Assert.Equal("1", result);
    }

    [Fact]
    public void balance_shows_correct_amount()
    {
      //Arrange
      BankAccount atm = new BankAccount();
      //Act
     int result = atm.Account();
      //Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void add_money_to_the_balance()
    {
      //Arrange
      BankAccount atm = new BankAccount();
      //Act
      int result = atm.Deposit(0);
      //Assert
      Assert.Equal(500, result);
    }

  }
}
