using System.ComponentModel;

namespace TestMotiv.DTO
{
    public class BaseDictDto : BaseModelDto
    {
        [DisplayName("Название")]
        public string Name { get; set; }
    }
}