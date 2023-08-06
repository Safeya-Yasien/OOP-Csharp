using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallProject
{
    internal class FunTravel: OutTravel
    {
        bool IsVisa;

        /*public FunTravel()
        {

        }*/

        public FunTravel(int TravelNo, int NoOfDays, string FromData, string Destination, float Price, string Airline, bool IsVisa) : base(TravelNo, NoOfDays, FromData, Destination, Price, Airline)
        {
            this.IsVisa = IsVisa;
        }

        public bool is_visa
        {
            set { IsVisa = value; }
            get { return IsVisa; }
        }

        // only for fun class
        public void Discount(int d)
        {
            Price = Price - (Price * (d / 100));
        }

        public override string Datails()
        {
            return $"{base.Datails()}\t{IsVisa}";
        }

    }
}
