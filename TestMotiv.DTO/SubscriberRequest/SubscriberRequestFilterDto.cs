using System.ComponentModel;

namespace TestMotiv.DTO
{
    public class SubscriberRequestFilterDto : BaseFilterDto
    {
        [DisplayName("Страна")]
        public string CountryName { get; set; }
        
        [DisplayName("Регион")]
        public string RegionName { get; set; }
        
        [DisplayName("Населенный пункт")]
        public string CityName { get; set; }
        
        [DisplayName("Телефон")]
        public string Phone { get; set; }
        
        [DisplayName("Причина обращения")]
        public int RequestReasonId { get; set; }
    }
}