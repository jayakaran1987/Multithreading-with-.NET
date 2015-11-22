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
        private Object thisLock = new Object();

        public void Start(Vehicle vechicle)
        { 
            // Send details to Administrator

            // Print
            Console.WriteLine("Race Vehicle started, Name : {0} | Model : {1} | Driver : {2}", vechicle.Name, vechicle.Model, vechicle.DriverName);
        }

        public void GetAverageSpeed(Vehicle vechicle, decimal distance, string time)
        {
            try
            {
                // Thread Synchronuzation for calculating speed
                lock (thisLock)
                {
                    // Average Speed
                    // Distance - Km
                    // time span string  "00:02:04.05"
                    var speed = (double)distance / TimeSpan.Parse(time).TotalHours;
                    Console.WriteLine("Average Speed of Vehicle : {0} | Speed : {1} Kmph", vechicle.Name, Math.Round(speed, 2));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured while calcuting speed for vehcle : {0} | Error Message  : {1}", vechicle.Name, e.Message);
            }
           
           
        }
    }
}
