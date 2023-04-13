using CollectionData.Db;
using CollectionData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CollectionData.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		private readonly ApplicationDbContext _db;
		public StudentController(ApplicationDbContext db)
		{
			_db = db;
		}
		[HttpPost]
		[Route("Create")]
		public IActionResult Create([FromBody] Student s1)
		{
			_db.Add(s1);
			_db.SaveChanges();
			return Ok(s1);
		}
		[HttpGet]
		[Route("GetAll")]
		public IActionResult GetAll(int id)
		{
			List<Student> students = new List<Student>();
			students = _db.students.ToList();
			return Ok(students);
		}
		[HttpGet]
		[Route("GetById")]
		public IActionResult GetById(int id)
		{
			Student s1 = _db.students.FirstOrDefault(x => x.Id == id);
			return Ok(s1);
		}
		[HttpPut]
		[Route("Update")]
		public IActionResult Update([FromBody] Student s1)
		{
			_db.Update(s1);
			_db.SaveChanges();
			return Ok(s1);
		}
		[HttpDelete]
		[Route("Delete")]
		public IActionResult DeleteById(int id)
		{
			Student s1 = _db.students.FirstOrDefault(x => x.Id == id);
			_db.Remove(s1);
			_db.SaveChanges();
			return Ok();

		}
	}
}


