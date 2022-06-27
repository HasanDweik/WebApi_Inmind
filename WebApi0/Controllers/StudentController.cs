using Microsoft.AspNetCore.Mvc;
using WebApi0.Models;

namespace WebApi0.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : Controller
{
    private List<Student> students = new List<Student>{new Student(1,"Hasan","hasan7@live.com"),
        new Student(2,"George","george3@live.com")};
    
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetStudent")]
    public IEnumerable<Student> Get()
    {
        return students
            .ToArray();
    }
    [HttpPost(Name = "PostStudent")]
    public IEnumerable<Student> AddStudent(Student student)
    {
        students.Add(student);
        return Get();
    }
    [HttpDelete(Name = "DeleteStudent")]
    public IEnumerable<Student> DeleteStudent(int id)
    {
        Student student = students.Where(obj => obj.id == id).Select(x => x).First();
        students.Remove(student);
        return Get();
    }
    
}