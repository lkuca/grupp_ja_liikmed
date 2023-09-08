using grupp_ja_liikmed;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        liikmed liigmed = new liikmed();
       
        liigmed.taishaalikud();


        

        Group group = new Group(3); /*liikmed liigmed = new liikmed();*/
        //liikmed Likmed = new
        Console.WriteLine(group.AddMember(liigmed));
        Console.WriteLine(string.Join(", ", group.Members));  // John, Mary, Jane
        Console.WriteLine(group.GetMembersCount());  // 3
        
        
    }
}