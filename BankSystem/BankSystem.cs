using System;

namespace BankSystem
{
    public enum AccountType
    {
        VIP,
        Entrepreneur,
        Ordinary
    }
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
        public string GetData()
        {
            return $"name: {Name}, lastname: {Lastname}, patronymic: {Patronymic}, passportNumber: {PassportNumber}";
        }
        public string Name { set; get; }
        public string Lastname { set; get; }
        public string Patronymic { set; get; }
        public string PassportNumber { set; get; }
    }

    public class BankAccount
    {
        public BankAccount(Client client, AccountType accountType)
        {
            owner = new Client();
            owner = client;
            cardBalance = 0;
            AccountType = accountType;
        }
        private AccountType AccountType;
        public string GetAccountType()
        {
            return AccountType.ToString();
        }
        public decimal Withdraw { get; set; }
        public Client owner { get; }
        public decimal Deposit { get; set; }
        public decimal cardBalance { get; set; }
        public decimal GetInterestRate()
        {
            switch(AccountType){
                case AccountType.VIP:
                    return cardBalance / 1000;
                case AccountType.Entrepreneur:
                    return cardBalance / 2000;
                case AccountType.Ordinary:
                    return cardBalance / 3000;
                default:
                    return cardBalance;
            }
        }
        public void MakeWithdraw(decimal sum)
        {
            Logger.Log($"Made withdraw, sum: {sum}");
        }
        public void MakeCredit(decimal sum)
        {
            Logger.Log($"Made credit, sum: {sum}");
        }
        public void MakeDeposit(decimal sum)
        {
            if(AccountType == AccountType.Ordinary)
            {
                if (cardBalance <= sum)
                {
                    Logger.Log($"Rejected for insufficient balance. Data of client: {owner.GetData()}");
                }
                else if (sum <= 1000)
                {
                    Logger.Log($"Rejected. Sum couldn't be less than 1000. Data of client: {owner.GetData()}");
                }
                else
                {
                    cardBalance -= sum;
                    Deposit += sum;
                }
            }
            Logger.Log($"Made deposit, sum: {sum}");
        }
        public void ShowInfoAboutOwner()
        {
            Logger.Log($"{owner.GetData()}");
        }
        public void ShowAccountType()
        {
            Logger.Log($"{AccountType.ToString()}");
        }
    }

    public class RequestForCreditCard
    {
        private BankAccount bankAccount;
        public RequestForCreditCard(BankAccount bank)
        {
            bankAccount = bank;
        }
        public bool IsApproved()
        {
            if (bankAccount.cardBalance > 2000)
            {
                Logger.Log($"Approved for giving a credit card. Data of client: {bankAccount.owner.GetData()}");
                return true;
            }
            else
            {
                Logger.Log($"Rejected for insufficient balance. Data of client: {bankAccount.owner.GetData()}");
                return false;
            }
        }
    }

    public class CreditRequest
    {
        private BankAccount bankAccount;
        public CreditRequest(BankAccount account)
        {
            bankAccount = account;
        }
        public bool IsApprovedByCreditDepartment()
        {
            if (bankAccount.cardBalance < 20000)
            {
                Logger.Log($"Rejected for insufficient balance. Data of client: {bankAccount.owner.GetData()}");
                return false;
            }
            else
            {
                Logger.Log($"Approved for giving a credit. Data of client: {bankAccount.owner.GetData()}");
                return true;
            }
        }
    }
}
