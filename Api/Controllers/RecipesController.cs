using Api.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Services;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class RecipesController : Controller
    {
        private IRepository<Recipe> _repository;

        public RecipesController(IRepository<Recipe> repository)
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
        public async Task<IActionResult> Save([FromBody] Recipe recipe)
        {
            var t1 = Task.Run(() =>
            {
                return _repository.Save(recipe);
            });
            await t1;
            return Ok(t1.Result);
        }
    }
}