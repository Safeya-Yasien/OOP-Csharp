using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Project
{
    internal class Customer
    {
        string name;
        string email;

        public Customer(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public Customer()
        {
            name = "";
            email = "";
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }
    }
}
