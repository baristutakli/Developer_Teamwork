using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DbPractices.DataAccess.EntityFramework.Abstract;
using DbPractices.Entities;
using Microsoft.EntityFrameworkCore;

namespace DbPractices.DataAccess.EntityFramework.Concrete
{
    public class EfStudentDal : EfRepositoryBase<Student>,IEfStudentDal
    {
        public EfStudentDal(SchoolDbContext context) : base(context)
        {
        }
        public Student GetById(int id)
        {
            return SchoolDbContext.Students.SingleOrDefault(s => s.StudentId == id);
        }

        public IList<Student> GetAll()
        {
            return SchoolDbContext.Set<Student>().Include(x => x.Grade).OrderBy(s=>s.StudentId).ToList();
        }
    }
}


