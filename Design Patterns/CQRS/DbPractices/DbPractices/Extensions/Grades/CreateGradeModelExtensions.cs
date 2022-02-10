using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbPractices.Entities;
using DbPractices.Models.Grade;

namespace DbPractices.Extensions.Grades
{
    public static class CreateGradeModelExtensions
    {
        public static Grade GetCreateGradeModel(this CreateGradeModel createModel)
        {
            Grade grade = new()
            {
                GradeName = createModel.GradeName,
                Section = createModel.Section,
            };
            return grade;
        }
    }
}
