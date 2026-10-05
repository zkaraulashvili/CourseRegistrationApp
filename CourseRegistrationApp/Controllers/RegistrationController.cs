using Microsoft.AspNetCore.Mvc;
using CourseRegistrationApp.Models;

namespace CourseRegistrationApp.Controllers;

public class RegistrationController : Controller
{
    private readonly ApplicationContext _context;

    public RegistrationController(ApplicationContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(CourseRegistration registration)
    {
        if (ModelState.IsValid)
        {
            _context.CourseRegistrations.Add(registration);
            _context.SaveChanges();

            return View("Success", registration);
        }

        return View(registration);
    }
}