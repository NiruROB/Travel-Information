using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Reiseplanlegging
{
    internal class Destination
    {
        private string DestinationName { get; set; }
        private string Description { get; set; }
        private List<TravelService> Services { get; } = new List<TravelService>(); 

        public Destination(string destinationName, string description)
        {
            DestinationName = destinationName;
            Description = description;
            
        }

        public void AddService(TravelService service)
        {
            Services.Add(service);
        }

        public void DestinationInfo() 
        {
            Console.WriteLine($"Destination {DestinationName}");
            Console.WriteLine($"Description {Description}");
            Console.WriteLine("Available Services:");
            foreach(var service in Services)
            {
                service.ServiceInfo(); 
            }
        }
        
    }
}
