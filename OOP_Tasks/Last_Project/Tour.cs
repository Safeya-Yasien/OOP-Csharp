using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Last_Project
{
    internal class Tour : TravelEntity
    {
        int duration;

        // https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-list-in-C-Sharp/
        List<Destination> destinations = new List<Destination>();
        float price;
        List<Booking> bookings = new List<Booking>();

        public Tour(string name, string description, int duration, float price) : base(name, description)
        {
            this.duration = duration;
            this.price = price;
        }

        public Tour() : base()
        {
            duration = 0;
            price = 0;
        }

        public int Duration
        {
            set { duration = value; }
            get { return duration; }
        }

        public float Price
        {
            set { price = value; }
            get { return price; }
        }


        public void AddDestination(Destination destination)
        {
            destinations.Add(destination);
        }

        public void RemoveDestination(Destination destination)
        {
            destinations.Remove(destination);
        }

        public int GetAvailableSeats()
        {
            int totalSeats = 0;
            foreach (Destination destination in destinations)
            {
                totalSeats += destination.Seats;
            }
            return (totalSeats);
        }

        public void MakeBooking(Customer customer, int numberOfSeats)
        {
            Booking booking = new Booking(customer, numberOfSeats);
            bookings.Add(booking);
        }

        public void CancelBooking(Booking booking)
        {
            bookings.Remove(booking);
        }

        public List<Booking> GetBookings()
        {
            return (bookings);
        }

        public List<Destination> GetDestinations()
        {
            return (destinations);
        }

        public float GetPrice()
        {
            return (price);
        }

    }
}
