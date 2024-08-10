using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Student : IComparable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CompareTo(Student other)
        {
            return this.ID.CompareTo(other.ID);
        }
    }

}
