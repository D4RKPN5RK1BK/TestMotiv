using System.ComponentModel;

namespace TestMotiv.DTO
{
    public class SubscriberRequestDto : BaseModelDto
    {
        [DisplayName("Телефон")]
        public string Phone { get; set; }
        
        [DisplayName("Страна")]
        public string CountryName { get; set; }

        [DisplayName("Регион")]
        public string RegionName { get; set; }

        [DisplayName("Город")]
        public string CityName { get; set; }

        [DisplayName("Причина запроса")]
        public string RequestReasonName { get; set; }
        
        [DisplayName("Причина запроса")]
        public int RequestReasonId { get; set; }
    }
}