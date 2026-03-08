using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Employee : IComparable<Employee>, ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int _id, string _name, double _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
        }

        public override string ToString()
        {
            return $"Id is {Id}, Name is {Name}, Salary is {Salary}";
        }

        public int CompareTo(Employee other)
        {
            return this.Salary.CompareTo(other.Salary);
        }

        public object Clone()
        {
            return new Employee(this.Id, this.Name, this.Salary);
        }
    }
}
