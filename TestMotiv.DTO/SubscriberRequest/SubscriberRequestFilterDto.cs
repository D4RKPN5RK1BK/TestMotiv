using System;
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
        public string RequestReason { get; set; }

        [DisplayName("Направление принявшее заявку")]
        public int DepartmentId { get; set; }
        
        [DisplayName("Период создания")]
        public DateTime? CreatedFrom { get; set; }
        
        [DisplayName("Период создания")]
        public DateTime? CreatedTo { get; set; }
    }
}