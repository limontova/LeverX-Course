﻿using System;

namespace BankSystem
{
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Client
    {
        public Client() : this(string.Empty, string.Empty, string.Empty, string.Empty)
        {
        }
        public Client(string name, string lastname, string patronymic, string passportNumber)
        {
            Name = name;
            Lastname = lastname;
            Patronymic = patronymic;
            PassportNumber = passportNumber;
        }
        public string Name { set; get; }
        public string Lastname { set; get; }
        public string Patronymic { set; get; }
        public string PassportNumber { set; get; }
    }

    public interface IBankAccount
    {
        public decimal Withdraw { get; set; }
        public Client owner { get; }
        public decimal Deposit { get; set; }
        public decimal cardBalance { get; set; }
        public void SetCardBalance(decimal balance)
        {
            cardBalance = balance;
        }
        decimal InterestRate { get; }
        public void MakeWithdraw(decimal sum)
        {
            Logger.Log("Made withdraw");
        }
        public void MakeCredit(decimal sum)
        {
            Logger.Log("Made credit");
        }
        public void MakeDeposit(decimal sum)
        {
            Logger.Log("Made deposit");
        }
    }

    public class BankAccountForVIP : IBankAccount
    {
        public BankAccountForVIP()
        {
            owner = new Client();
        }
        public BankAccountForVIP(Client client)
        {
            owner = client;
        }
        public BankAccountForVIP(string name, string lastName, string patronymic, string passportNumber)
        {
            owner = new Client(name, lastName, patronymic, passportNumber);
        }
        public void SetCardBalance(decimal balance)
        {
            cardBalance = balance;
        }
        public decimal Withdraw { get; set; }
        public Client owner { get; }
        public decimal Deposit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal cardBalance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        decimal IBankAccount.cardBalance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal InterestRate { get { return cardBalance / 1000; } }
    }

    public class BankAccountForEntrepreneur : IBankAccount
    {
        public BankAccountForEntrepreneur(string name, string lastName, string patronymic, string passportNumber)
        {
            owner = new Client();
        }
        public BankAccountForEntrepreneur(Client client)
        {
            owner = client;
        }
        public BankAccountForEntrepreneur()
        {
            owner = new Client(string.Empty, string.Empty, string.Empty, string.Empty);
        }
        public void SetCardBalance(decimal balance)
        {
            cardBalance = balance;
        }
        public decimal Withdraw { get; set; }
        public Client owner { get; }
        public decimal Deposit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal cardBalance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal InterestRate { get { return cardBalance / 2000; } }
    }
    public class BankAccountForOrdinary : IBankAccount
    {
        public BankAccountForOrdinary(string name, string lastName, string patronymic, string passportNumber)
        {
            owner = new Client();
        }
        public BankAccountForOrdinary(Client client)
        {
            owner = client;
        }
        public BankAccountForOrdinary()
        {
            owner = new Client(string.Empty, string.Empty, string.Empty, string.Empty);
        }
        public void SetCardBalance(decimal balance)
        {
            cardBalance = balance;
        }
        public decimal Withdraw { get; set; }
        public Client owner;
        public decimal Deposit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal cardBalance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal InterestRate { get { return cardBalance / 3000; } }
        Client IBankAccount.owner => throw new NotImplementedException();
        public void MakeDeposit(decimal sum)
        {
            if (sum <= 1000)
            {
                Withdraw -= sum;
                cardBalance += sum;
                Logger.Log("Made deposit");
            }
        }
    }

    public class RequestForCreditCard
    {
        public static bool IsApproved(IBankAccount account)
        {
            if (account.cardBalance < 2000)
            {
                Logger.Log("Approved for giving a credit card");
                return true;
            }
            else
            {
                Logger.Log("Rejected for insufficient balance");
                return false;
            }
        }
    }

    public class CreditRequest
    {
        private IBankAccount bankAccount;
        public CreditRequest(IBankAccount account)
        {
            bankAccount = account;
        }
        public bool IsApprovedByCreditDepartment()
        {
            if (bankAccount.cardBalance < 20000)
            {
                Logger.Log("Rejected for insufficient balance");
                return false;
            }
            else
            {
                Logger.Log("Approved for giving a credit");
                return true;
            }
        }
    }
}