using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public void PrintCustomer()
    {
        Console.WriteLine($"Current Customer {Id}" );
        Console.WriteLine($"Current Customer {Name}" );
    }
}
