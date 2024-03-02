using System;
using System.Reflection;

namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankCustomer customer = new BankCustomer();
            //customer.PrintCustomer();

            var Bankconstructors = typeof(BankCustomer).GetConstructors();

            Console.WriteLine("Loan bank class details");
            foreach (var (constructor, index) in Bankconstructors
                        .Select((constructor, index) => (constructor, index)))
            {
                Console.WriteLine($"Constructor {index} : {constructor.Name} ");
            }


            var Bankproperties = typeof(BankCustomer).GetProperties();

            Console.WriteLine("Loan bank class details");
            foreach (var (property, index) in Bankproperties
                        .Select((property, index) => (property, index)))
            {
                Console.WriteLine($"Property {index} : {property.Name} - { property.PropertyType} ");
            }


            var Methods = typeof(BankCustomer).GetMethods();

            Console.WriteLine("Loan bank class details");
            foreach (var (method, index) in Methods
                        .Select((property, index) => (property, index)))
            {
                Console.WriteLine($"Method {index} : {method.Name} - {method.ReturnParameter} ");
                foreach (var Parameter in method.GetParameters())
                    Console.WriteLine($" Parameter { Parameter.Name } - { Parameter.ParameterType}");
            }


            var constructors = typeof(LoanCustomer).GetConstructors();

            Console.WriteLine("Loan Customer class details");
            foreach(var (constructor,index) in constructors
                        .Select((constructor,index)=>(constructor,index)))
            {
                Console.WriteLine($"Constructor {index} : {constructor.Name} ");
            }
        }
    }
}