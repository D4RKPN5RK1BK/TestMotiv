using System.ComponentModel.DataAnnotations;
using TestMotiv.Abstractions;

namespace TestMotiv.Models
{
    public class SubscriberRequest : IHasId
    {
        [Key]
        public int Id { get; set; }
        
        public string Phone { get; set; }
        
        public string CityName { get; set; }
        
        public string RegionName { get; set; }
        
        public string CountryName { get; set; }
        
        public RequestReason RequestReason { get; set; }
        
        public int RequestReasonId { get; set; }
    }
}