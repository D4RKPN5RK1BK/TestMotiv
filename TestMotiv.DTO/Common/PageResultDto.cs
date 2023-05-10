using System.Collections.Generic;

namespace TestMotiv.DTO
{
    public class PageResultDto<TFilter, TItem> where TFilter : BaseFilterDto
    {
        public TFilter Filter { get; set; }
        
        public PageDataDto PageData { get; set; }

        public List<TItem> Items { get; set; } = new List<TItem>();
        
        public int Total { get; set; }
    }
}