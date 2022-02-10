using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbPractices.DataAccess.Dapper.Abstract;
using DbPractices.DataAccess.EntityFramework.Abstract;
using DbPractices.Extensions.Students;

namespace DbPractices.Features.StudentOperations.Commands.CreateStudent
{
    public class CreateStudentCommand
    {
        private readonly IEfStudentDal _efStudentDal;

        public CreateStudentCommand(IEfStudentDal efStudentDal)
        {
            _efStudentDal = efStudentDal;

        }
        public CreateStudentResponse Handle(CreateStudentRequest request)
        {
            _efStudentDal.Add(request.GetCreateStudent());

            return new CreateStudentResponse {Message = "Student added"};
        }


    }

}
