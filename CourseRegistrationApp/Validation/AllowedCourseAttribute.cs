using System.ComponentModel.DataAnnotations;

namespace CourseRegistrationApp.Validation;

public class AllowedCourseAttribute : ValidationAttribute
{
    private readonly string[] _allowedCourses;

    public AllowedCourseAttribute(string[] allowedCourses)
    {
        _allowedCourses = allowedCourses;
    }

    public override bool IsValid(object? value)
    {
        if (value == null)
            return true;

        string course = value.ToString()!;

        return _allowedCourses.Contains(course);
    }
}