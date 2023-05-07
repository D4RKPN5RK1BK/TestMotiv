using TestMotiv.Models.Domain.Base;

namespace TestMotiv.Models.Domain
{
    public class Region : BaseNamedDictModel
    {
        public Country Country { get; set; }
        
        public int CountryId { get; set; }
    }
}