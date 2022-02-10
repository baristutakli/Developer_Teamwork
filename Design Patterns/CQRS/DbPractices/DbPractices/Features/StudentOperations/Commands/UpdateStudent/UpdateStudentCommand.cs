using System;
using DbPractices.DataAccess.EntityFramework.Abstract;
using DbPractices.Extensions.Students;

namespace DbPractices.Features.StudentOperations.Commands.UpdateStudent
{
    public class UpdateStudentCommand
    {
        private readonly IEfStudentDal _efStudentDal;

        public UpdateStudentCommand(IEfStudentDal efStudentDal)
        {
            _efStudentDal = efStudentDal;
        }
        public UpdateStudentResponse Handle(UpdateStudentRequest request,int id)
        {
            var student = _efStudentDal.GetById(id);
            if (student is null) throw new InvalidOperationException("Student didn't find");

             request.GetUpdateStudent(student);

             return new UpdateStudentResponse { Message = "Student updated" };
        }

    }
}
