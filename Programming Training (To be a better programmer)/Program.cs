using Programming_Training__To_be_a_better_programmer_.Static_Data;

class Program
{
    private static Func<int, bool> _odd = (int x) =>  x % 2 == 0;
    private static Func<int, bool> _even = (int x) => x % 2 == 0;

    private static Predicate<int> _predicateEven = (int x) => x % 2 == 0;
    static void Main()
    {
        Console.WriteLine("Enter if you want to print even or odd number:");
        string input = Console.ReadLine();

       IEnumerable<int> nums = Enumerable.Range(1, 100)
                                         .Where(x => 
                                         input == "even"
                                         ? _predicateEven(x)
                                         : _odd(x)
                                         );
        foreach(int num in nums)
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
