using WebApi0.DTOs;
using WebApi0.Interfaces;
using WebApi0.Models;

namespace WebApi0.Helpers;

public class StudentHelpers : IStudentHelper
{
    public IEnumerable<Student> GetAllStudents(List<Student> students)
    {
        return students.ToArray();
    }

    public Student GetStudentById(List<Student> students, int id)
    {
        return students.Where(obj => obj.Id == id).Select(x => x).First();
    }

    public IEnumerable<Student> AddStudent(List<Student> students,Student student)
    { 
        students.Add(student);
        return students;
    }
    public IEnumerable<Student> DeleteStudent(List<Student> students, int id)
    {
        students.Remove(students.Where(obj => obj.Id == id).First());
        return students;
    }
    public IEnumerable<Student> UpdateStudent(List<Student> students, int id, UpdateStudentDto usDto)
    {
        Student student = students.Where(obj => obj.Id == id).First();
        int index = students.IndexOf(student);
        students[index].Email = usDto.Email;
        students[index].Name = usDto.Name;
        return students.ToArray();
    }

    public List<Student> GetStudentByString(List<Student> students, string s)
    {
        return students.Where(obj => obj.Name.Contains(s)).ToList();
    }
}