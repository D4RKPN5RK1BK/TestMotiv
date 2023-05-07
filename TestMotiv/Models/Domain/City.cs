using TestMotiv.Models.Domain.Base;

namespace TestMotiv.Models.Domain
{
    public class City : BaseNamedDictModel
    {
        public Region Region { get; set; }
        
        public int RegionId { get; set; }
    }
}