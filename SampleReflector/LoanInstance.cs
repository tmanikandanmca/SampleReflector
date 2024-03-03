using System.Reflection;
namespace Reflections;
internal class LoanInstance
{    public void GetLoanCustomer()
    {
        var Loan = typeof(LoanCustomer);
        var constructors = Loan.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine("Loan Customer class details");
        foreach (var (constructor, index) in constructors
                    .Select((constructor, index) => (constructor, index)))
        {
            Console.WriteLine($"Constructor {index} : {constructor.Name} ");
        }
        var instance = (LoanCustomer)constructors[0].Invoke(null);
        var Methods = Loan.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        Console.WriteLine("Loan bank class details");
        foreach (var (method, index) in Methods
                    .Where(x => x.IsFamily != true && x.IsSpecialName != true)
                    .Select((property, index) => (property, index)))
        {
            method.Invoke(instance, null);
            Console.WriteLine($"Method {index} : {method.Name} - {method.ReturnParameter} ");
            foreach (var Parameter in method.GetParameters())
                Console.WriteLine($" Parameter {Parameter.Name} - {Parameter.ParameterType}");
        }
        var Bankproperties = Loan.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine("Loan bank class details");
        foreach (var (property, index) in Bankproperties
                    .Select((property, index) => (property, index)))
        {
            Console.WriteLine($"Property {index} : {property.Name} - {property.PropertyType} ");
            var field = Bankproperties.Single(x => x.Name == property.Name);
            if (field.Name == "Id")
                field.SetValue(instance, 9999);
            else
                field.SetValue(instance, "Grek");
        }
         var Secretmethod=Methods.Where(x=>!x.IsFamily && !x.IsSpecialName).FirstOrDefault();
        _ = Secretmethod.Invoke(instance, null);
    }
}
