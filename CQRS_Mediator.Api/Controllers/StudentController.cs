using CQRS_Mediator.Api.Commands;
using CQRS_Mediator.Api.Models;
using CQRS_Mediator.Api.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IMediator mediator;

        public StudentController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Student>> Get()
        {
            return await mediator.Send(new GetStudentListQuery());
        }

        [HttpPost]
        public async Task<Student> Post([FromBody] Student student)
        {
            return await mediator.Send(new AddStudentCommand(student));
        }
    }
}
