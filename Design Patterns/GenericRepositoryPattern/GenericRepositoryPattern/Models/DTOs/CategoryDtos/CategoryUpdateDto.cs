using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GenericRepositoryPattern.Models.DTOs.CategoryDtos
{
    public class CategoryUpdateDto
    {
        public string Name { get; set; }
        public bool Status { get; set; } = true;
        
    }
}
