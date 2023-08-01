using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallProject
{
    internal class InTravel:Travel
    {
        string Transportation;

        public InTravel(int TravelNo, string FromData, int NoOfDays, string Destination, float Price, string Transportation):base(TravelNo, FromData, NoOfDays, Destination, Price)
        {
            this.Transportation = Transportation;
        }

        public string transportation
        {
            set { Transportation = value; }
            get { return Transportation; }
        }

        public override string Datails()
        {
            return $"{base.Datails()}\t{Transportation}";
        }

    }
}
