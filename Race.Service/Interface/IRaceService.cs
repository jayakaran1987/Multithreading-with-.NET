using Race.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Service.Interface
{
    public interface IRaceService
    {
        void Start(Vehicle vechicle);
        void GetAverageSpeed(Vehicle vechicle, decimal distance, string time);

    }
}
