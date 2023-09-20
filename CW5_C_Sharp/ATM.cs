using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_C_Sharp
{
    internal class ATM
    {
        private BankAccount bankAccount;
        public ATM(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }
        public void WithdrawMoney(double money)
        {
            bankAccount.Withdraw(money);
        }
        public void DepositMoney(double money) 
        {
            bankAccount.Deposit(money);
        }
    }
}
