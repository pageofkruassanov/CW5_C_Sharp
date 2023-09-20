using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_C_Sharp
{
    internal class InsufficientFundsException : Exception
    {
        private string _message;
        public InsufficientFundsException(string message)
        {
            _message = message;
        }
        public string Message()
        { 
            return _message; 
        }
    }
}
