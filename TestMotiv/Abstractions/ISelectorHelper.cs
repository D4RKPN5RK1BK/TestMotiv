using System.Linq;

namespace TestMotiv.Abstractions
{
    /// <summary>
    /// Установка селекторов при запросе к БД
    /// </summary>
    /// <typeparam name="TModel">Модель для которой пишутся селекторы</typeparam>
    /// <typeparam name="TMarker">Маркер (ореинтеровочно тип Dto модели в который в дальшейшем будет произведена конвертация модели)</typeparam>
    public interface ISelectorHelper<TModel, TMarker>
    {
        IQueryable<TModel> ApplySelectors(IQueryable<TModel> query);
    }
}