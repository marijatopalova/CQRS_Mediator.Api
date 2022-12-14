using CQRS_Mediator.Api.Models;
using MediatR;

namespace CQRS_Mediator.Api.Queries
{
    public class GetStudentListQuery : IRequest<List<Student>>
    {
    }
}
