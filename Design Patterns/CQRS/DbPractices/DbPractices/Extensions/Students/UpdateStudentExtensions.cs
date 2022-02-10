using DbPractices.Entities;
using DbPractices.Features.StudentOperations.Commands.UpdateStudent;

namespace DbPractices.Extensions.Students
{
    public static class UpdateStudentExtensions
    {
        public static Student GetUpdateStudent(this UpdateStudentRequest updateStudent,Student student)
        {
            student.StudentName = updateStudent.StudentName;
            student.GradeId = updateStudent.GradeId;
            return student;
        }
    }
}

