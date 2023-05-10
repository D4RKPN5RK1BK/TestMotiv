using TestMotiv.Models.Domain;
using TestMotiv.Models.Domain.Base;

namespace TestMotiv.Models
{
    public class City : BaseNamedDictModel
    {
        public Region Region { get; set; }
        
        public int RegionId { get; set; }
    }
}