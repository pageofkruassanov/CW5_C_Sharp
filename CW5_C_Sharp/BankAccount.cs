using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_C_Sharp
{
    internal class BankAccount
    {
        private double _cash;
        public BankAccount(double cash)
        {
            _cash = cash;
        }
        public void Deposit(double cash)
        {
            if (cash < 0)
            {
                throw new ArgumentException("Попытка внести отрицательную сумму");
            }
            _cash += cash;
        }
        public void Withdraw(double cash)
        {
            if (cash < 0)
            {
                throw new ArgumentException("Попытка снять отрицательную сумму");
            }
            else if (cash > _cash)
            {
                throw new InsufficientFundsException("Недостаточно средств");  
            }
            _cash -= cash;
        }
    }
}
