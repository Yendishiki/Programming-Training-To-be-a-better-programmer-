﻿using Programming_Training__To_be_a_better_programmer_.Static_Data;
using Del = Programming_Training__To_be_a_better_programmer_.Static_Data.DelegationSample;
class Program
{
    static void Main()
    {
        PureFunction001();
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
