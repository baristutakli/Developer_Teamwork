using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbPractices.Entities
{
    [Table("Grades")]
    public class Grade
    { 
        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

    }
}
