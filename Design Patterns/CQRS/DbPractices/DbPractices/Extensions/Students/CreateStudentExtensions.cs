using DbPractices.Entities;
using DbPractices.Features.StudentOperations.Commands.CreateStudent;

namespace DbPractices.Extensions.Students
{
    public static class CreateStudentExtensions
    {
        public static Student GetCreateStudent(this CreateStudentRequest createStudentModel)
        {

            var newStudent = new Student
            {
                StudentName = createStudentModel.StudentName,
                GradeId = createStudentModel.GradeId
            };

            return newStudent;

        }
    }
}

