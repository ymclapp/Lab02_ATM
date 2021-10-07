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
    //[Fact]
    //public void ex_FizzBuzz_returns_1_given_1()
    //{
      //Arrange
      //FizzBuzzer fb = new FizzBuzzer();
      //Act
      //string result = fb.FizzBuzz(1);
      //Assert
      //Assert.Equal("1", result);
    //}

    [Fact]
    public void balance_shows_correct_amount()
    {
      //Arrange
      BankAccount atm = new BankAccount();
      //Act
     decimal result = atm.GetBalance();

      //Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void add_money_to_the_balance()
    {
      //Arrange
      BankAccount atm = new BankAccount();

      //Act
      atm.Deposit(50);

      //Assert
      decimal newBalance = atm.GetBalance();
      Assert.Equal(50, newBalance);
    }

    [Fact]
    public void subtract_money_from_the_balance()
    {
      //Arrange
      BankAccount atm = new BankAccount();

      //Act
      atm.Withdrawal(0);

      //Assert
      decimal newBalance = atm.GetBalance();
      Assert.Equal(0, newBalance); 
    }

    [Fact]
    public void subtract_money_from_the_balance_to_get_a_throw()
    {
      //Arrange
      BankAccount atm = new BankAccount();

      //Act
      //atm.Withdrawal(0);

      //Assert
      decimal newBalance = atm.GetBalance();
      Assert.Throws<ArgumentOutOfRangeException>(() =>
      {
        atm.Withdrawal(-20);
      });
    }
    [Fact]
    public void subtract_money_from_the_balance_to_get_another_throw()
    {
      //Arrange
      BankAccount atm = new BankAccount();

      //Act
      //atm.Withdrawal(0);

      //Assert
      decimal newBalance = atm.GetBalance();
      Assert.Throws<InvalidOperationException>(() =>
      {
        atm.Withdrawal(20);
      });
    }
    }
}
