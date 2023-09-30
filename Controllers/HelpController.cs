using System.Diagnostics;
using EduCompass.Classes;
using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduCompass.Controllers;

public class HelpController : Controller
{

    public HelpController()
    {
    }

    public IActionResult HelpSignUp()
    {
        return View();
    }

    public IActionResult HelpStart()
    {
        return View();
    }

    public IActionResult HelpLogin()
    {
        return View();
    }

    public IActionResult HelpDashboard()
    {
        return View();
    }

    public IActionResult HelpIntroTest()
    {
        return View();
    }

    public IActionResult HelpOrientations()
    {
        return View();
    }

    public IActionResult HelpCourse()
    {
        return View();
    }

    public IActionResult HelpCourseTest()
    {
        return View();
    }

    public IActionResult HelpEvaluationTest()
    {
        return View();
    }

    public IActionResult HelpStatistics()
    {
        return View();
    }

    public IActionResult HelpSuggestions()
    {
        return View();
    }

    public IActionResult HelpProfile()
    {
        return View();
    }
    public IActionResult HelpEditProfile()
    {
        return View();
    }

    public IActionResult HelpSignout()
    {
        return View();
    }
}