using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class MemberManagement
    {
        List<Member> members = new List<Member>();
        public void RegisterMember(Member member)
        {
            members.Add(member);
        }
        public void DisplayMembers()
        {
            foreach (var member in members)
            {
                Console.WriteLine($"{member.Name} (ID: {member.MemberID})");
            }
        }
    }    
}
