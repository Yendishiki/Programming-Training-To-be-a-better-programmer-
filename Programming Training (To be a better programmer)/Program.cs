
using Programming_Training__To_be_a_better_programmer_.Base;
using Programming_Training__To_be_a_better_programmer_.Models;
using Programming_Training__To_be_a_better_programmer_.Static_Data;
using Base = Programming_Training__To_be_a_better_programmer_.Base;

using Del = Programming_Training__To_be_a_better_programmer_.Static_Data.DelegationSample;
class Program
{
    static void Main()
    {

    }

    public void GetAndSetProperty()
    {
        var employee = new Employee()
        {
            Name = "Lisa",
            Salary = 10000
        };

        Console.WriteLine($"{employee.Name}'s salary is {employee.Salary}");
    }

    public void BaseClassSample()
    {
        // ---1
      //  Parent parent = new Child();

        // ---2
      //  Parent parent = new Child("call");

        // ---3
        Parent parent = new Child("call", "call2");
    }

    public static void PureFunction001()
    {
        var shoppingList = new List<string> { "coffee beans", "BANANAS", "Dates" };

        PureFunction
            .Format(shoppingList)
            .ForEach(Console.WriteLine);
    }
    public static void PrintOddOrEven()
    {
        Console.WriteLine("Enter if you want to print even or odd number:");
        string input = Console.ReadLine();

        IEnumerable<int> nums = Enumerable.Range(1, 100)
                                          .Where(x =>
                                          input == "even"
                                          ? Del.even(x)
                                          : Del.odd(x)
                                          );
        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }
    }

    public static void UpdateUserImmutable()
    {
        var populate = new PopulateStaticModel();
        var user = populate.Users().First();

        // Create a new User record with modified properties
        var updateUser = user with { Id = 1, Name = "Open AI" };
    }
}
