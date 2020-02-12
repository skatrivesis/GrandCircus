using System;
using System.Collections.Generic;
using System.Text;

namespace Classes3
{
    class Contact
    {
        #region fields
        private string lastName;
        private string firstName;
        private string phoneNumber;
        private string email;
        #endregion

        #region properties
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        #region constructors
        public Contact(string lastName, string firstName, string phoneNumber, string email)
        {
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"Last name: {lastName}\nFirst name: {firstName}\nPhone number: {phoneNumber}\nEmail: {email}\n";
        }
        #endregion
    }
}
