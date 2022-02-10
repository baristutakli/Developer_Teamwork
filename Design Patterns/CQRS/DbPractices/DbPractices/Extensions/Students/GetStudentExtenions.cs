using System.Collections.Generic;
using DbPractices.Entities;
using DbPractices.Features.StudentOperations.Queries.GetAllStudent;


namespace DbPractices.Extensions.Students
{
    public static class GetStudentExtesions
    {
        public static List<GetAllStudentResponse> GetStudents(this List<Student> students)
        {
            
            List<GetAllStudentResponse> studentList = new();

            foreach (var student in students)
            {
                GetAllStudentResponse studentResponse = new()
                {
                    GradeId = student.GradeId,
                    StudentName = student.StudentName,
                };
                studentList.Add(studentResponse);
            }

            return studentList;
        }
    }
}
