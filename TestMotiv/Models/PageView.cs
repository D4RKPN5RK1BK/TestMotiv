using System.Collections.Generic;

namespace TestMotiv.Models
{
    /// <summary>
    /// Модель для пагинации
    /// </summary>
    /// <typeparam name="TDto">Тип отображаемых элементов</typeparam>
    public class PageView<TDto, TFilter>
    {
        /// <summary>
        /// Элементы текущей страницы
        /// </summary>
        public List<TDto> Items { get; set; } = new List<TDto>();
        
        public TFilter Filter { get; set; }

        /// <summary>
        /// Всего элементов в списке
        /// </summary>
        public int Total { get; set; }
    }
}