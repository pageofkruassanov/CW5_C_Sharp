using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_C_Sharp
{
    internal class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message):base(message) { }
    }
}
