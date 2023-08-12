using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Project
{
    internal class Destination : TravelEntity
    {
        int seats;

        public Destination(string name, string description, int seats) : base(name, description)
        {
            this.seats = seats;
        }

        public Destination() : base()
        {
            seats = 0;
        }

        public int Seats
        {
            set { this.seats = value; }
            get { return this.seats; }
        }
    }
}
