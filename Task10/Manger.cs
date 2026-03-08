using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Manger : Employee, IComparable<Manger>
    {
        public Manger(int _id, string _name, double _salary) : base(_id, _name, _salary)
        {
        }

        public int CompareTo(Manger other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }
}
