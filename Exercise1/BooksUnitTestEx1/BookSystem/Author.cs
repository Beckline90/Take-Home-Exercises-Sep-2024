using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookSystem
{
    public class Author
    {
        #region Data Members
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _contactUrl = string.Empty;
        private string _residentCity = string.Empty;
        private string _residentCountry = string.Empty;
        #endregion

        #region Properties
        public string AuthorName
        {
            get { return $"{_lastName}, {_firstName}"; }
        }
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First Name is required");
                }
                _firstName = value.Trim();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last Name is required");
                }
                _lastName = value.Trim();
            }

        }

        public string ContactUrl
        {
            get => _contactUrl;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                { throw new ArgumentException("URL is required"); }
                string pattern = @"(https?://www\.)?[a-zA-Z0-9]+\.\w{2,}(?!\.)";
                if (!Regex.IsMatch(value, pattern))
                { throw new ArgumentException("acceptable url pattern required"); }

                _contactUrl = value.Trim();



            }
        }
        public string ResidentCity
        {
            get => _residentCity;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("City is Required");
                }
                _residentCity = value.Trim();
            }
        }
        public string ResidentCountry
        {
            get => _residentCountry;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Country is required");
                }
                _residentCountry = value.Trim();
            }
        }
        #endregion

        #region Constructor
        public Author(string firstName, string lastName, string contactUrl, string residentCity, string residentCountry)
        {
            FirstName = firstName;
            LastName = lastName;
            ContactUrl = contactUrl;
            ResidentCity = residentCity;
            ResidentCountry =  residentCountry;
        }

        #endregion

        #region Method
        public override string ToString() => $"{FirstName},{LastName},{ContactUrl},{ResidentCity},{ResidentCountry}";



        #endregion
    }
}
