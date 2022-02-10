using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbPractices.Entities;
using DbPractices.Models.Grade;

namespace DbPractices.Extensions.Grades
{
    public static class GetGradeQueryExtensions
    {
        public static GetGradeModel GetGrade(this Grade grade)
        {
            GetGradeModel gradeModel = new()
            {
                GradeName = grade.GradeName,
                Section = grade.Section,
            };
            return gradeModel;
        }
    }
}
