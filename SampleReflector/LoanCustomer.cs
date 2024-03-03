namespace Reflections;

public class LoanCustomer
{

    private int Id { get; set; }
    private string Name { get; set; }
    private LoanCustomer() : this(1002, "Adil")
    {

    }
    private LoanCustomer(int Id, String Name)
    {
        this.Id = Id;
        this.Name = Name;
    }
    private void PrintCustomer()
    {
        Console.WriteLine($"Current Loan Customer {Id}");
        Console.WriteLine($"Current Loan Customer {Name}");
    }
}
