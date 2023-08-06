using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallProject
{
    internal abstract class Travel
    {
        protected int TravelNo, NoOfDays;
        protected string FromData, Destination;
        protected float Price;

        public Travel()
        {
            TravelNo = 0;
            NoOfDays = 0;
            FromData = "";
            Destination = "";
            Price = 0.0f;
        }

        public Travel(int TravelNo, string FromData, int NoOfDays, string Destination, float Price)
        {
            this.TravelNo = TravelNo;
            this.NoOfDays = NoOfDays;
            this.FromData = FromData;
            this.Destination = Destination;
            this.Price = Price;
        }

        public int travel_no
        {
            set { TravelNo = value;}
            get { return TravelNo; }
        }

        public int no_of_days
        {
            set { NoOfDays = value;}
            get { return NoOfDays; }
        }

        public string from_data
        {
            set { FromData = value; }
            get { return FromData; }
        }

        public string destination
        {
            set { Destination = value; }
            get { return Destination; }
        }

        public float price
        {
            set { Price = value; }
            get { return Price; }
        }

        // for all classes
        public void ExtendDays(int Days)
        {
            NoOfDays += Days;
        }

        public virtual string Datails()
        {
            return $"{TravelNo}\t{FromData}\t{NoOfDays}Days\t{Destination}\t{Price}$";
        }


    }

}
