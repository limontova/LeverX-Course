using System;
using Xunit;
using BankSystem;
using NSubstitute;

namespace BankSystem.Tests
{
    public class BankTests
    {
        [Theory]
        [InlineData(true, 200000)]
        [InlineData(false, 100)]
        public void IsApprovedByCreditDepartment_MakeCreditRequest_ShouldReject(bool expected, decimal cardBalance)
        {
            //Arrange
            var account= Substitute.For<IBankAccount>();
            account.cardBalance = cardBalance;
            var creditRequest = new CreditRequest(account);
            //Act
            var isApproved = creditRequest.IsApprovedByCreditDepartment();
            //Assert
            Assert.Equal(expected, isApproved);
        }
    }
}
