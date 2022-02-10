using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbPractices.Entities;

namespace DbPractices.DataAccess.EntityFramework.Abstract
{
    public interface IEfStudentDal : IEfRepostitoryBase<Student>
    {
        Student GetById(int id);
        IList<Student> GetAll();
    }
}
