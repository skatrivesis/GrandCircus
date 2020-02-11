using System;
using System.Collections.Generic;
using System.Text;

namespace Classes2
{
    class Employee
    {
        #region fields
        private int id;
        private string firstName;
        private string lastName;
        private string title;
        private double salary;
        #endregion fields


        #region properties
        //ID is fixes; once you create an emplyee, their ID cannot change
        //do we remove the set from this property
        public int Id { get => id; }
        public string FirstName { get => firstName; set => firstName = value; } 
        public string LastName { get => lastName; set => lastName = value; }
        public string Title { get => title; set => title = value; }
        public double Salary { get => salary; set => salary = value; }
        #endregion properties


        #region constructors
        public Employee(int id, string firstName, string lastName, string title, double salary)
        {
            this.id = id;
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.title = title ?? throw new ArgumentNullException(nameof(title));
            this.salary = salary;
        }
        #endregion constructors


        #region methods
        public void GiveRaise(double increment)
        {
            salary += increment;
        }
        public void Promote(string newTitle, double salaryIncrement)
        {
            title = newTitle;
            salary += salaryIncrement;
        }
        public override string ToString()
        {
            return $"{id}\t{lastName}, {firstName} {title} ${salary:N2}";
        }
        #endregion methods
    }
}
