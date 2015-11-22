using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Core.Model
{
    public class Audi: Vehicle
    {
        // Some unique Audi Properties are listed 
        //public string AudiEngineNumber { get; set; }
        //public string AudiShape { get; set; }
        public VehicleType Type { get; set; }
    }
}
