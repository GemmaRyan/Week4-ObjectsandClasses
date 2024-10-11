using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class School
    {
        public string Name { get; set; }
        public int NumberOfStudents { get; set; }

        public School(string name, int numberOfStudents)
        {
            Name = name;
            NumberOfStudents = numberOfStudents;
        }

        public int CompareTo(School other)
        {
            return this.NumberOfStudents.CompareTo(other.NumberOfStudents);
        }

        public override string ToString()
        {
            return $"school name: {Name}, student no.: {NumberOfStudents}";
        }
    }
}
