using CQRS_Mediator.Api.Models;

namespace CQRS_Mediator.Api.DataAccess
{
    public class DataAccess : IDataAccess
    {
        private List<Student> students;

        public DataAccess()
        {
            students = new List<Student>()
            {
                new Student() { Id = 1, FirstName = "Marija", LastName = "Topalova",  Age = 24 },
                new Student() { Id = 2, FirstName = "Mario", LastName = "Topalov",  Age = 35 },
                new Student() { Id = 3, FirstName = "Marko", LastName = "Markovski",  Age = 16 },
                new Student() { Id = 4, FirstName = "Ana", LastName = "Anevska",  Age = 22 },
                new Student() { Id = 5, FirstName = "Dimitar", LastName = "Dimitrovski",  Age = 28 },
            };
        }

        public Student AddStudent(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);

            return student;
        }

        public Student GetStudentById(int id)
        {
            var srudent = students.Where(s => s.Id == id).FirstOrDefault();
            return srudent;
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
