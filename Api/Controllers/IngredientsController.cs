using Api.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Services;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class IngredientsController : Controller
    {
        private IRepository<Ingredient> _repository;

        public IngredientsController(IRepository<Ingredient> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var t1 = Task.Run(() =>
            {
                return _repository.GetList();
            });
            await t1;
            return Ok(t1.Result);
        }

        [HttpPost]
        [ValidateModelStateFilter]
        public async Task<IActionResult> Save([FromBody] Ingredient ingredient)
        {
            var t1 = Task.Run(() =>
            {
                return _repository.Save(ingredient);
            });
            await t1;
            return Ok(t1.Result);
        }
    }
}