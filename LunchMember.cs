

namespace LunchBuddies;

public class LunchMember
{
    public string firstName { get; set; }   
    public string lastName { get; set; }    

    public LunchMember(string FirstName, string LastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }

    public void Eat()
    {
        Console.WriteLine($"");
    }


}
