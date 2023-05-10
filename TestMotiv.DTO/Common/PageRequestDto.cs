namespace TestMotiv.DTO
{
    public class PageRequestDto<TFilter> where TFilter : BaseFilterDto
    {
        public TFilter Filter { get; set; }
        
        public PageDataDto PageData { get; set; }
    }
}