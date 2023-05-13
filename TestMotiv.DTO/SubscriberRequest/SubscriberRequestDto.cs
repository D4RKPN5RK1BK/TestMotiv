using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        public string RequestReason { get; set; }
        
        [Required]
        [DisplayName("Направление принявшее заявку")]
        public int DepartmentId { get; set; }

        [DisplayName("Направление принявшее заявку")]
        public string DepartmentName { get; set; }
        
        [DisplayName("Дата и время создания")]
        public DateTime Created { get; set; }
    }
}