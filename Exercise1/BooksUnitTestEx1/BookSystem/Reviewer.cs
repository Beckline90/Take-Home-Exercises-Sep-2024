using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookSystem
{
    public class Reviewer
    {
        #region Data Members
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _email = string.Empty;
        private string? _organization;

        #endregion

        #region Properties
        public string ReviewerName
        {
            get { return $"{_lastName}, {_firstName}"; }
        }
        public string FirstName
        {
            get { return _firstName;}
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First Name must is required");
                }
                _firstName = value.Trim(',');
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last Name is required");
                }
                _lastName = value.Trim();
            }

        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Valid email is required");
                }

                string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(value))
                {
                    throw new ArgumentException("an acceptable email address pattern is required");
                }

                _email = value.Trim();
            }
        }
        public string? Organization
        {
            get => _organization;
            set
            {
                _organization = value?.Trim();
            }
        }


        #endregion

        #region Constructor
        public Reviewer(string firstname, string lastName, string email, string organization)
        {
            FirstName = firstname;
            LastName = lastName;
            Email = email;
            Organization = organization;

        }

        #endregion

        #region Method
        public override string ToString() => $"{FirstName},{LastName},{Email},{Organization}";


        #endregion
    }
}
