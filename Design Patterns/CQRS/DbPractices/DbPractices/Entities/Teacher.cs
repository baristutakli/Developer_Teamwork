using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DbPractices.Entities
{
    [Table("Teachers")]
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string Name  { get; set; }
        public string Branch { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
