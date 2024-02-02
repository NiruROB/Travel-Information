using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiseplanlegging
{
    internal class Travel
    {
        private int TravelNumber { get; set;  }
        private DateTime TravelDate { get; set; }
        private decimal TotalCost { get; set; }
        private List<TravelService> SelectedServices { get;} = new List<TravelService>();


        public Travel(int travelNumber, DateTime travelDate)
        {
            TravelNumber = travelNumber;
            TravelDate = travelDate; 
        }


        public void TravelInfo()
        {
            Console.WriteLine($"Travel Number: {TravelNumber}");
            Console.WriteLine($"Travel Date: {TravelDate}");
            Console.WriteLine($"Total Cost: {TotalCost}");
            foreach(var service in SelectedServices)
            {
                service.ServiceInfo(); 
            }
        }

        public void AddService(TravelService service)
        {
            SelectedServices.Add(service);
            TotalCost += 50;

        }
    }
}
