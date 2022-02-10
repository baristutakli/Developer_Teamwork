using System;
using DbPractices.DataAccess.EntityFramework.Abstract;

namespace DbPractices.Features.StudentOperations.Commands.DeleteStudent
{
    public class DeleteStudentCommand
    {
        private readonly IEfStudentDal _efStudentDal;

        public DeleteStudentCommand(IEfStudentDal efStudentDal)
        {
            _efStudentDal = efStudentDal;

        }

        public DeleteStudentResponse Handle(int id)
        {
            var student =  _efStudentDal.GetById(id);
            if (student is null) throw new InvalidOperationException("Student didn't find");

            _efStudentDal.Delete(student);

            return new DeleteStudentResponse { Message = "Student deleted" };
        }
    }
}
