using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallProject
{
    internal abstract class OutTravel:Travel
    {
        string Airline;

        public OutTravel(int TravelNo, int NoOfDays, string FromData, string Destination, float Price, string Airline) : base(TravelNo, FromData, NoOfDays, Destination, Price)
        {
            this.Airline = Airline;
        }

        public string airline
        {
            set { Airline = value; }
            get { return Airline; }
        }

        public override string Datails()
        {
            return $"{base.Datails()}$\t{Airline}";
        }


    }
}
