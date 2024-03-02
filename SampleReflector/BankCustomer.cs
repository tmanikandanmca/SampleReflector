namespace Reflections;
public class BankCustomer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public BankCustomer():this(1001,"Nick")
    {

    }

    public BankCustomer(int Id, string Name)
    {
        this.Id = Id;
        this.Name = Name;
    }


    public void PrintCustomer()
    {
        Console.WriteLine($"Current Bank Customer { Id }");
        Console.WriteLine($"Current Bank Customer { Name }");
    }
}
