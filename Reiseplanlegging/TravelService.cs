using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiseplanlegging
{
    internal class TravelService
    {
        private string TransportType { get; set; }
        public TravelService( string transportType) 
        {
            TransportType = transportType; 
        }       

        public void ServiceInfo()
        {
            Console.WriteLine($"Transport Type: {TransportType}");
        }
        
    }
}
