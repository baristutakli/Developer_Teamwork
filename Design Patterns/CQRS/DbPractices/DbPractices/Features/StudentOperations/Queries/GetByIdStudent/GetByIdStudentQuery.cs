using System;
using DbPractices.DataAccess.EntityFramework.Abstract;
using DbPractices.Extensions.Students;

namespace DbPractices.Features.StudentOperations.Queries.GetByIdStudent
{
    public class GetByIdStudentQuery
    {
        private readonly IEfStudentDal _efStudent;

        public GetByIdStudentQuery(IEfStudentDal efStudent)
        {
            _efStudent = efStudent;
        }

        public GetByIdStudentResponse Handle(int id)
        {
            var student =  _efStudent.GetById(id);

            if (student is null) throw new InvalidOperationException("Student didn't find");

            return student.GetStudentById();
        }
    }
}
