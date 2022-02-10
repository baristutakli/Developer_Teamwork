using DbPractices.Entities;
using DbPractices.Features.StudentOperations.Queries.GetByIdStudent;

namespace DbPractices.Extensions.Students
{
    public static partial class GetStudentDetailExtensions
    {
        public static GetByIdStudentResponse GetStudentById(this Student student)
        {
            GetByIdStudentResponse studentResponse = new()
            {
                StudentName = student.StudentName,
                GradeId = student.GradeId
            };
            return studentResponse;
        }
    }
}


