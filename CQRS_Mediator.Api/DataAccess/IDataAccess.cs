using CQRS_Mediator.Api.Models;

namespace CQRS_Mediator.Api.DataAccess
{
    public interface IDataAccess
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        Student AddStudent(Student student);
    }
}
