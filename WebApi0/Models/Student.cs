using System.ComponentModel.DataAnnotations;

namespace WebApi0.Models;

public class Student
{
    
    public Student(int id, string name, string email)
    {
        this.id = id;
        this.name = name;
        this.email = email;
    }
    [Required]
    public int id { get; set; }

    [Required]
    [MinLength(3,ErrorMessage = "please enter a valid name")]

    public string name { get; set; }
    [Required]
    [EmailAddress]
    public string email { get; set; }

}