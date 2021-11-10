using System;
using Xunit;
using BankSystem;
using NSubstitute;
using FluentAssertions;
using System.IO;

namespace BankSystem.Tests
{
    public class BankTests
    {
        private Client _client = new Client("Vasya", "Sergeevich", "Petrov", "AB1234567");

        [Theory]
        [InlineData(true, 200000)]
        [InlineData(false, 100)]
        public void IsApprovedByCreditDepartment_MakeCreditRequest_ShouldReturnValidResult(bool expected, decimal cardBalance)
        {
            //Arrange
            var account= Substitute.For<BankAccount>(new Client(), AccountType.VIP);
            account.cardBalance = cardBalance;
            var creditRequest = new CreditRequest(account);
            //Act
            var isApproved = creditRequest.IsApprovedByCreditDepartment();
            //Assert
            expected.Should().Be(isApproved);
        }

        [Theory]
        [InlineData(true, 3000)]
        [InlineData(false, 1999)]
        public void IsApprovedRequestForCreditCard_MakeRequest_ShouldReturnValidResult(bool expected, decimal cardBalance)
        {
            //Arrange
            var account = Substitute.For<BankAccount>(new Client(), AccountType.Entrepreneur);
            account.cardBalance = cardBalance;
            var request = new RequestForCreditCard(account);
            //Act
            var isApproved = request.IsApproved();
            //Assert
            expected.Should().Be(isApproved);
        }

        [Theory]
        [InlineData(5000, 10000, 5000, 0, 5000)]
        [InlineData(100, 100, 5, 5, 50)]
        [InlineData(1000, 1000, 50, 50, 5000)]
        public void BankAccountForOrdinaryMakeDeposit_MakeDeposit_ShouldReturnValidResult(decimal expectedCardBalance, decimal cardBalance, decimal expectedDeposit, decimal deposit, decimal sum)
        {
            //Arrange
            BankAccount account = Substitute.For<BankAccount>(new Client(), AccountType.Ordinary);
            account.cardBalance = cardBalance;
            account.Deposit = deposit;
            //Act
            account.MakeDeposit(sum);
            //Assert
            expectedCardBalance.Should().Be(account.cardBalance);
            expectedDeposit.Should().Be(account.Deposit);
        }

        //[Theory]
        //[InlineData("Rejected for insufficient balance. Data of client: name: Vasya, lastname: Petrov, patronymic: Sergeevich, passportNumber: AB1234567", 120, _client)]
        //[InlineData("Approved for giving a credit. Data of client: name: Vasya, lastname: Petrov, patronymic: Sergeevich, passportNumber: AB1234567", 3000)]
        //public void IsApprovedRequestForCreditCardLog_MakeRequest_ShouldWriteValidLog(string expected, decimal cardBalance, Client client, object _client)
        //{
        //    //Arrange
        //    var account = Substitute.For<BankAccount>(client, AccountType.Entrepreneur);
        //    account.cardBalance = cardBalance;
        //    var request = new RequestForCreditCard(account);
        //    //Act
        //    var actual = Console.ReadLine();
        //    //Assert
        //    expected.Should().Be(actual);
        //}
    }
}
