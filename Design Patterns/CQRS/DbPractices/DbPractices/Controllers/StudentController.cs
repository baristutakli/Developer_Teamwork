using System.Net;
using DbPractices.DataAccess.Dapper.Abstract;
using Microsoft.AspNetCore.Mvc;
using DbPractices.DataAccess.EntityFramework.Abstract;
using DbPractices.Features.StudentOperations.Commands.CreateStudent;
using DbPractices.Features.StudentOperations.Commands.DeleteStudent;
using DbPractices.Features.StudentOperations.Commands.UpdateStudent;
using DbPractices.Features.StudentOperations.Queries.GetAllStudent;
using DbPractices.Features.StudentOperations.Queries.GetByIdStudent;

namespace DbPractices.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IEfStudentDal _efStudentDal;
        private readonly IDpStudentDal _dpStudentDal;

        public StudentController(IEfStudentDal studentDal, IDpStudentDal dpStudentDal)
        {
            _efStudentDal = studentDal;
            _dpStudentDal = dpStudentDal;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new GetAllStudentQuery(_dpStudentDal).Handle());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new GetByIdStudentQuery(_efStudentDal).Handle(id));
        }

        [HttpPost]
        public IActionResult Add([FromBody] CreateStudentRequest createStudent)
        {
            var result = new CreateStudentCommand(_efStudentDal).Handle(createStudent);
            return StatusCode((int)HttpStatusCode.Created, result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,[FromBody] UpdateStudentRequest updateStudent)
        {
            return Ok(new UpdateStudentCommand(_efStudentDal).Handle(updateStudent, id));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(new DeleteStudentCommand(_efStudentDal).Handle(id));
        }
    }
}
