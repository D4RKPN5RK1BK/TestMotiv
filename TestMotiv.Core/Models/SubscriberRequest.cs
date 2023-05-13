using System;
using TestMotiv.Core.Abstractions;

namespace TestMotiv.Core.Models
{
    public class SubscriberRequest : IAudiable, IHasId
    {
        public int Id { get; set; }
        
        public string Phone { get; set; }
        
        public string CityName { get; set; }
        
        public string RegionName { get; set; }
        
        public string CountryName { get; set; }
        
        public Department Department { get; set; }
        
        public string RequestReason { get; set; }
        
        public int DepartmentId { get; set; }
        
        public DateTime Created { get; set; }
    }
}