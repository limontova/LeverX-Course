using System;
using Xunit;
using BankSystem;
using NSubstitute;
using FluentAssertions;

namespace BankSystem.Tests
{
    public class BankTests
    {
        [Theory]
        [InlineData(true, 200000)]
        [InlineData(false, 100)]
        public void IsApprovedByCreditDepartment_MakeCreditRequest_ShouldReturnValidResult(bool expected, decimal cardBalance)
        {
            //Arrange
            var account= Substitute.For<IBankAccount>();
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
            var account = Substitute.For<IBankAccount>();
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
            BankAccountForOrdinary account = Substitute.For<BankAccountForOrdinary>();
            account.cardBalance = cardBalance;
            account.Deposit = deposit;
            //Act
            account.MakeDeposit(sum);
            //Assert
            expectedCardBalance.Should().Be(account.cardBalance);
            expectedDeposit.Should().Be(account.Deposit);
        }
    }
}
