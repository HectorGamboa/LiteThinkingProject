using LiteThinkingProject.Application.UseCase.Activity.Queries.ActivityGetAllQuery;
using LiteThinkingProject.Application.UseCase.Activity.Queries.ActivityGetByIdQuery;
using Microsoft.AspNetCore.Mvc;

namespace LiteThinkingProject.Api.Controllers
{
    //Prefijo de api
    [Route("api/[controller]")]
    public class ActivityController : BaseController
    {   
        
        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var query = new ActivityGetAllQuery();
            var result = await this.Mediator.Send(query);
            return this.FromResult(result);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(ActivityGetByIdQueryModel model)
        {
            var query = this.Mapper.Map<ActivityGetByIdQuery>(model);
            var result = await this.Mediator.Send(query);
            return this.FromResult(result);
        }
    }
}
