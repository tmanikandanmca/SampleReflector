using System.Reflection;
namespace Reflections;

internal class BankInstance
{
    public void GetBankCustomer()
    {
        var Bank = typeof(BankCustomer);

        var Bankconstructors = Bank.GetConstructors();

        Console.WriteLine("bank class details");
        foreach (var (constructor, index) in Bankconstructors
                    .Select((constructor, index) => (constructor, index)))
        {
            Console.WriteLine($"Constructor {index} : {constructor.Name} ");
        }

        var Bankproperties = Bank.GetProperties();

        Console.WriteLine("Loan bank class details");
        foreach (var (property, index) in Bankproperties
                    .Select((property, index) => (property, index)))
        {
            Console.WriteLine($"Property {index} : {property.Name} - {property.PropertyType} ");
        }


        var Methods = Bank.GetMethods();

        Console.WriteLine("Loan bank class details");
        foreach (var (method, index) in Methods
                    .Select((property, index) => (property, index)))
        {
            Console.WriteLine($"Method {index} : {method.Name} - {method.ReturnParameter} ");
            foreach (var Parameter in method.GetParameters())
                Console.WriteLine($" Parameter {Parameter.Name} - {Parameter.ParameterType}");
        }
    }

}
