using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secao11Exercicio.Entities.Exception;

namespace Secao11Exercicio.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holdet { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() 
        {
        }

        public Account(int number, string holdet, double balance, double withdrawLimit)
        {
            Number = number;
            Holdet = holdet;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
