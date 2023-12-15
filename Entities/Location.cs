using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagement.Entities
{
    internal class Location
    {
        private long locationID;
        private string locationName;
        private string address;

        public Location() { }

        public Location(long locationID, string locationName, string address)
        {
            this.locationID = locationID;
            this.locationName = locationName;
            this.address = address;
        }

    
        public long LocationID { get => locationID; set => locationID = value; }
        public string LocationName { get => locationName; set => locationName = value; }
        public string Address { get => address; set => address = value; }

        public override string ToString()
        {
            return $"Location{{locationID={locationID}, locationName='{locationName}', address='{address}'}}";
        }
    }
}
 