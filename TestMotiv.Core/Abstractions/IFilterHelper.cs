using System.Linq;

namespace TestMotiv.Core.Abstractions
{
    public interface IFilterHelper<TModel, TFilter>
    {
        IQueryable<TModel> Filter(IQueryable<TModel> query, TFilter filter);
    }
}