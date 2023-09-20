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
            BankAccount firstAccount = new BankAccount((double)1000.2);
            ATM mainAtm = new ATM(firstAccount);
            try
            {
                mainAtm.WithdrawMoney((double)1100);
            }
            catch(InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
