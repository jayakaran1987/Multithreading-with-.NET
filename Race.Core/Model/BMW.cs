using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Core.Model
{
    public class BMW: Vehicle
    {
        // Some unique BMW Properties are listed 
        //public string BMWRegistryNumber { get; set; }
        //public string BMWShape { get; set; }
        public VehicleType Type { get; set; }
    }
}
