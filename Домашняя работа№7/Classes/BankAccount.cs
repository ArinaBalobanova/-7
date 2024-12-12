using System;
using System.Security.AccessControl;

namespace Домашняя_работа_7.Classes
{
    class BankAccount
    {
        private static Random random = new Random();
        private static int accountNumberCounter = 0;
        private string accountNumber;
        private decimal balance;
        private AccType accountType;

        public BankAccount()
        {
        }

        public BankAccount(decimal Balance, AccType accountType)
        {
            this.accountNumber = UnicAccountNumber();
            this.balance = Balance;
            this.accountType = accountType;
        }
        private string UnicAccountNumber()
        {
            int randomPart = random.Next(1000, 1000000);
            accountNumberCounter++;
            return $"AC{randomPart}-{accountNumberCounter:0000}";
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Сумма должна быть положительной.");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
        public void Transfer(BankAccount destinationAccount, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Сумма перевода должна быть положительной.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Недостаточно средств для перевода.");
                return;
            }
            Withdraw(amount);
            destinationAccount.Deposit(amount);
            Console.WriteLine($"Переведено {amount} на счет {destinationAccount.accountNumber}.");
        }
        public void PrintAccountInfo()
        {
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {accountType}");
        }
    }
}
