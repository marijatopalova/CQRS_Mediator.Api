using CQRS_Mediator.Api.Commands;
using CQRS_Mediator.Api.DataAccess;
using CQRS_Mediator.Api.Models;
using MediatR;

namespace CQRS_Mediator.Api.Handlers
{
    public class AddStudentCommandHandler : IRequestHandler<AddStudentCommand, Student>
    {
        private readonly IDataAccess data;

        public AddStudentCommandHandler(IDataAccess data)
        {
            this.data = data;
        }

        public Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student();
            student.FirstName = request.FirstName;
            student.LastName = request.LastName;
            student.Age = request.Age;

            return Task.FromResult(data.AddStudent(student));
        }
    }
}
