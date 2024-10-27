using Programming_Training__To_be_a_better_programmer_.Static_Data;

class Program
{
    static void Main()
    {

        UpdateUserImmutable();
    }

    public static void UpdateUserImmutable()
    {
        var populate = new PopulateStaticModel();
        var user = populate.Users().First();

        // Create a new User record with modified properties
        var updateUser = user with { Id = 1, Name = "Open AI" };
    }
}
