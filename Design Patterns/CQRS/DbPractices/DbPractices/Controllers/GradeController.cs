using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DbPractices.DataAccess.Dapper.Abstract;
using DbPractices.DataAccess.EntityFramework.Abstract;
using DbPractices.Extensions.Grades;
using DbPractices.Models.Grade;
using Microsoft.AspNetCore.Mvc;

//namespace DbPractices.Controllers
//{
 
//    [Route("api/[controller]s")]
//    [ApiController]
//    public class GradeController : ControllerBase
//    {
//        private readonly IEfGradeDal _efGradeDal;
//        private readonly IDpGradeDal _dpGradeDal;

//        public GradeController(IEfGradeDal efGradeDal, IDpGradeDal dpGradeDal)
//        {
//            _efGradeDal = efGradeDal;
//            _dpGradeDal = dpGradeDal;
//        }

//        [HttpGet]
//        public IActionResult GetAll()
//        {
//            var grades = _dpGradeDal.GetAll();
//            return Ok(grades.GetGrades());
//        }

//        [HttpGet("{id}")]
//        public IActionResult Get(int id)
//        {
//            var grade = _dpGradeDal.Get(20);
//            return Ok(grade.GetGrade());
//        }

//        [HttpPost]
//        public IActionResult Add([FromBody] CreateGradeModel gradeModel)
//        {
//            _efGradeDal.Add(gradeModel.GetCreateGradeModel());
//            return StatusCode((int) HttpStatusCode.Created);
//        }

//        [HttpPut("{id}")]
//        public IActionResult Update(int id,[FromBody] UpdateGradeModel gradeModel)
//        {
//            _efGradeDal.Update(gradeModel.GetUpdateGradeModel(id));
//            return Ok();
//        }

//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            var removeGrade = _dpGradeDal.Get(id);
//            _efGradeDal.Delete(removeGrade);
//            return Ok();
//        }
//    }
//}
