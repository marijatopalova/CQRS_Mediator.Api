using CQRS_Mediator.Api.Models;
using MediatR;

namespace CQRS_Mediator.Api.Commands
{
    public class AddStudentCommand : IRequest<Student>
    {
        public AddStudentCommand(Student student)
        {
            FirstName = student.FirstName;
            LastName = student.LastName;
            Age = student.Age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
