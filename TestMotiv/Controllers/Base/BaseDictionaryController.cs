using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using AutoMapper;
using TestMotiv.Abstractions;
using TestMotiv.Contexts;

namespace TestMotiv.Controllers.Base
{
    public class BaseDictionaryController<TModel, TDto> : Controller where TModel : class, IHasId
    {
        protected readonly UserRequestContext UserRequestContext;
        protected readonly Mapper Mapper;
        
        public BaseDictionaryController(Mapper mapper, UserRequestContext userRequestContext)
        {
            Mapper = mapper;
            UserRequestContext = userRequestContext;
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
            return Json(Mapper.Map<TDto>(model));
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