using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbPractices.DataAccess.Dapper.Abstract;
using DbPractices.Extensions.Students;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace DbPractices.Features.StudentOperations.Queries.GetAllStudent
{
    public class GetAllStudentQuery
    {
        private readonly IDpStudentDal _dpStudentDal;

        public GetAllStudentQuery(IDpStudentDal dpStudentDal)
        {
            _dpStudentDal = dpStudentDal;
        }

        public List<GetAllStudentResponse> Handle()
        {
           var students =  _dpStudentDal.GetAll();

           return students.GetStudents();

        }
    }
}
