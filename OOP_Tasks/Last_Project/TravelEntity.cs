using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_Project
{
    internal class TravelEntity
    {
        protected string name;
        protected string description;

        public TravelEntity(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public TravelEntity()
        {
            name = "";
            description = "";
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Description
        {
            set { description = value; }
            get { return description; }
        }
    }
}
