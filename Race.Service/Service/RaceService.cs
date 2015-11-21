using Race.Core.Model;
using Race.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Service
{
    public class RaceService:IRaceService
    {
        public void Start(Vehicle vechicle)
        { 
            // Send details to Administrator

            // Print
            Console.WriteLine("Vehicle started, Name -{0} Model - {1} Driver {2}", vechicle.Name, vechicle.Model, vechicle.DriverName);
        }

        public void GetAverageSpeed(Vehicle vechicle, decimal distance, string time)
        { 
            // Average Speed
            var speed =  (double)distance / TimeSpan.Parse(time).TotalHours;
            Console.WriteLine("Vehicle Name -{0} Speed {1}", vechicle.Name, speed);
        }
    }
}
