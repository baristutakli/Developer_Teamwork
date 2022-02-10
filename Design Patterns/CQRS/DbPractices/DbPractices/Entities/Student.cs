using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbPractices.Entities
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
