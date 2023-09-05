using grupp_ja_liikmed;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        

        Group group = new Group(3);
        
        Console.WriteLine(group.AddMember("John"));  // True
        Console.WriteLine(group.AddMember("John"));  // False
        Console.WriteLine(group.AddMember("Mary"));  // True
        Console.WriteLine(group.AddMember("Jane"));  // True
        Console.WriteLine(group.AddMember("Joseph"));  // False
        Console.WriteLine(string.Join(", ", group.Members));  // John, Mary, Jane
        Console.WriteLine(group.GetMembersCount());  // 3

        Group bookClub = new Group(4);
        Console.WriteLine(bookClub.AddMember("Albert"));   // True
        Console.WriteLine(bookClub.AddMember("Samantha"));  // True
        Console.WriteLine(bookClub.AddMember("Robert"));   // True
        Console.WriteLine(bookClub.AddMember("Roberta"));  // True
        Console.WriteLine(string.Join(", ", bookClub.Members));  // Albert, Samantha, Robert, Roberta

        Console.WriteLine(bookClub.HasMember("Albert"));  // True
        Console.WriteLine(bookClub.HasMember("John"));  // False
    }
}