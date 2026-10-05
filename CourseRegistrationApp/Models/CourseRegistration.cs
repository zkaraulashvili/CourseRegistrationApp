using System.ComponentModel.DataAnnotations;
using CourseRegistrationApp.Validation;

namespace CourseRegistrationApp.Models;

public class CourseRegistration
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Student name is required")]
    public string StudentName { get; set; } = "";

    [Required(ErrorMessage = "Course is required")]
    [AllowedCourse(
        new[] { "C#", "ASP.NET Core", "SQL" },
        ErrorMessage = "This course is not allowed"
    )]
    public string Course { get; set; } = "";
}