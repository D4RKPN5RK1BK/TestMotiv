using System.Linq;
using TestMotiv.Abstractions;
using TestMotiv.DTO;
using TestMotiv.Models;

namespace TestMotiv.Helpers.Filters
{
    public class RequestReasonFilterHelper : IFilterHelper<RequestReason, BaseFilterDto>
    {
        public IQueryable<RequestReason> Filter(IQueryable<RequestReason> query, BaseFilterDto filter)
        {
            return query;
        }
    }
}