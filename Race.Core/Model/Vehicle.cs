using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Core.Model
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string DriverName { get; set; }
        public string Model { get; set; }

        public FuelType Fuel { get; set; }
    }
}
