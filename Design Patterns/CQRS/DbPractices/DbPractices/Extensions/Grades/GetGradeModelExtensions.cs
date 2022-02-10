using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbPractices.Entities;
using DbPractices.Models.Grade;

namespace DbPractices.Extensions.Grades
{
    public static class GetGradeModelExtensions
    {
        public static List<GetGradeModel> GetGrades(this List<Grade> grades)
        {
            List<GetGradeModel> gradeModels = new();

            foreach (var grade in grades)
            {
                GetGradeModel gradeModel = new()
                {
                    Section = grade.Section,
                    GradeName = grade.GradeName
                };
                gradeModels.Add(gradeModel);
            }

            return gradeModels;
        }

    }
}
