using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.Contexts;
using TestMotiv.DTO;

namespace TestMotiv.Controllers.Base
{
    /// <summary>
    /// Базовый контроллер для выполнения синхронных CRUD запросов
    /// </summary>
    /// <typeparam name="TModel">Модель привязанная к базе данных</typeparam>
    /// <typeparam name="TDto">Dto модели</typeparam>
    /// <typeparam name="TFilter">Фильтр для получения отчета</typeparam>
    public abstract class BaseDictionaryController<TModel, TDto, TFilter> : Controller 
        where TModel : class, IHasId 
        where TFilter : BaseFilterDto
        where TDto : new()
    {
        protected readonly UserRequestContext UserRequestContext;
        protected readonly Mapper Mapper;
        private readonly IFilterHelper<TModel, TFilter> _filterHelper;
        private readonly IPageDataService _pageDataService;

        public BaseDictionaryController(Mapper mapper, 
                                        UserRequestContext userRequestContext, 
                                        IFilterHelper<TModel, TFilter> filterHelper, 
                                        IPageDataService pageDataService)
        {
            Mapper = mapper;
            UserRequestContext = userRequestContext;
            _filterHelper = filterHelper;
            _pageDataService = pageDataService;
        }

        /// <summary>
        /// Получение представления для создания новой сущности
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public virtual ActionResult Create()
        {
            var dto = new TDto();
            return View(dto);
        }

        /// <summary>
        ///  Получение представления для редактирования существующей сущности
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public virtual ActionResult Update(int id = 0)
        {
            if (id <= 0) return new HttpNotFoundResult();

            var model = UserRequestContext.Set<TModel>().Find(id);
            var dto = Mapper.Map<TDto>(model);

            return View(dto);
        }

        /// <summary>
        /// Получение представления с отфильтрованым списком сущностей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public virtual ActionResult Read(PageRequestDto<TFilter> dto)
        {
            var query = UserRequestContext.Set<TModel>().AsQueryable();
            var filtered = _filterHelper.Filter(query, dto.Filter);
            var (items, total) = _pageDataService.ToPageView<TModel, TDto>(filtered, dto.PageData);
            
            var result = new PageResultDto<TFilter, TDto>
            {
                Filter = dto.Filter,
                PageData = dto.PageData,
                Items = items.ToList(),
                Total = total
            };
            return View(result);
        }

        /// <summary>
        /// Получение объекта по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public virtual ActionResult Get(int id)
        {
            var model = UserRequestContext.Set<TModel>().Find(id);

            if (model == null)
                return new HttpNotFoundResult();
            
            return Json(Mapper.Map<TDto>(model));
        }

        /// <summary>
        /// Создание объекта на основе его Dto
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public virtual async Task<ActionResult> Create(TDto dto)
        {
            var model = Mapper.Map<TModel>(dto);
            UserRequestContext.Set<TModel>().Add(model);
            await UserRequestContext.SaveChangesAsync();
            return RedirectToAction("Read");
        }

        /// <summary>
        /// Обновление объекта на основе его Dto
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public virtual ActionResult Update(TDto dto)
        {
            var model = Mapper.Map<TModel>(dto);
            var set = UserRequestContext.Set<TModel>();

            if (!set.Any(i => i.Id == model.Id))
                return new HttpNotFoundResult();
            
            return Json(Mapper.Map<TDto>(model));
        }

        /// <summary>
        /// Удаление объекта по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public virtual async Task<ActionResult> Delete(int id)
        {
            var set = UserRequestContext.Set<TModel>();
            var model = set.Find(id);

            if (model == null)
                return Json(false);

            set.Remove(model);
            await UserRequestContext.SaveChangesAsync();
            return Json(true);
        }
    }
}