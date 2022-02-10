using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbPractices.Entities;
using DbPractices.Models.Grade;

namespace DbPractices.Extensions.Grades
{
    public static class UpdateGradeModelExtensions
    {

        public static Grade GetUpdateGradeModel(this UpdateGradeModel createModel,int id)
        {
            Grade grade = new()
            {
                GradeId = id,
                GradeName = createModel.GradeName,
                Section = createModel.Section,
            };
            return grade;
        }
    }
}

