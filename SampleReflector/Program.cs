using System;
using System.Reflection;

namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankInstance bInstance = new BankInstance();
            bInstance.GetBankCustomer();

            LoanInstance loanInstance = new LoanInstance();
            loanInstance.GetLoanCustomer();

        }
    }
}