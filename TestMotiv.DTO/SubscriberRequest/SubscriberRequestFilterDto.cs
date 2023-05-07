using System.ComponentModel;

namespace TestMotiv.DTO
{
    public class SubscriberRequestFilterDto : BaseFilterDto
    {
        [DisplayName("Страна")]
        public int CountryId { get; set; }
        
        [DisplayName("Регион")]
        public int RegionId { get; set; }
        
        [DisplayName("Населенный пункт")]
        public int CityId { get; set; }
        
        [DisplayName("Телефон")]
        public string Phone { get; set; }
        
        [DisplayName("Причина обращения")]
        public int RequestReasonId { get; set; }
    }
}