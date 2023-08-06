using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallProject
{
    class RelTravel:OutTravel
    {
        string Path;


        public RelTravel(int TravelNo, int NoOfDays, string FromData, string Destination, float Price, string Airline, string Path) : base(TravelNo, NoOfDays, FromData, Destination, Price, Airline)
        {
            this.Path = Path;
        }

        public string path
        {
            set { Path = value; }
            get { return Path; }
        }

        public override string Datails()
        {
            return $"{base.Datails()}\t{path}";
        }
    }
}
