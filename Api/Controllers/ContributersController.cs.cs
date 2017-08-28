using Api.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Services;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class ContributersController : Controller
    {
        private IRepository<Contributer> _repository;

        public ContributersController(IRepository<Contributer> repository)
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
        public async Task<IActionResult> Save([FromBody] Contributer contributer)
        {
            var t1 = Task.Run(() =>
            {
                return _repository.Save(contributer);
            });
            await t1;
            return Ok(t1.Result);
        }
    }
}