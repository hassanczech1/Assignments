﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        
        public Member(int memberID, string name) { 

            MemberID = memberID;
            Name = name;

        }
    }
}
