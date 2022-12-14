using CQRS_Mediator.Api.DataAccess;
using CQRS_Mediator.Api.Models;
using CQRS_Mediator.Api.Queries;
using MediatR;

namespace CQRS_Mediator.Api.Handlers
{
    public class GetStudentListQueryHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IDataAccess data;

        public GetStudentListQueryHandler(IDataAccess data)
        {
            this.data = data;
        }

        public Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(data.GetStudents());
        }
    }
}
