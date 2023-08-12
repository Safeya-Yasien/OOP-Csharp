using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Last_Project
{
    internal class Booking
    {
        Customer customer;
        Tour tour;
        int numberOfSeats;

        public Booking(Customer customer, int numberOfSeats)
        {
            this.customer = customer;
            this.numberOfSeats = numberOfSeats;
        }

        public Booking()
        {
            customer = new Customer();
            tour = new Tour();
            numberOfSeats = 0;
        }

        public int NumberOfSeats
        {
            set { numberOfSeats = value; }
            get { return numberOfSeats; }
        }

        public Customer Customer
        {
            set { customer = value; }
            get { return customer; } 
        }

        public Tour Tour
        {
            set { tour = value; }
            get { return tour; }
        }


    }
}
