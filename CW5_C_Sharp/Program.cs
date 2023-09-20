using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount firstAccount = new BankAccount();
            ATM mainAtm = new ATM(firstAccount);
            mainAtm.DepositMoney((double)300);
            mainAtm.WithdrawMoney((double)300.1);
            Console.ReadLine();

        }
    }
}
