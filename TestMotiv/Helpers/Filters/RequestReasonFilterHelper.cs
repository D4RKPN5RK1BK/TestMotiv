using System.Linq;
using TestMotiv.Abstractions;
using TestMotiv.DTO;

namespace TestMotiv.Helpers.Filters
{
    public class RequestReasonFilterHelper : IFilterHelper<RequestReasonFilterHelper, BaseFilterDto>
    {
        public IQueryable<RequestReasonFilterHelper> Filter(IQueryable<RequestReasonFilterHelper> query, BaseFilterDto filter)
        {
            return query;
        }
    }
}