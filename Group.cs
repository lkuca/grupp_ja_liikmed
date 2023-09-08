using grupp_ja_liikmed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Group
{
    public List<liikmed> Members { get; } = new List<liikmed>();
    private readonly int _maxAmount;

    public Group(int maxAmount)
    {
        _maxAmount = maxAmount;
    }

    public bool AddMember(liikmed member)
    {



        if (Members.Contains(member)) return false;
        if (Members.Count >= _maxAmount) return false;
        Members.Add(member);
        return true;
    }

    public int GetMembersCount()
    {
        return Members.Count;
    }

    public bool HasMember(liikmed member)
    {
        return Members.Contains(member);
    }

}

