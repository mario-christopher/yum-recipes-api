using Api.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Services;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class TagsController : Controller
    {
        private IRepository<Tag> _repository;

        public TagsController(IRepository<Tag> repository)
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
            await t1;       //or for multiple tasks // await Task.WhenAll(t1, t2, t3);
            return Ok(t1.Result);
        }

        [HttpPost]
        [ValidateModelStateFilter]
        public async Task<IActionResult> Save([FromBody] Tag tag)
        {
            var t1 = Task.Run(() =>
            {
                return _repository.Save(tag);
            });
            await t1;
            return Ok(t1.Result);
        }
    }
}