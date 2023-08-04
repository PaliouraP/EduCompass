﻿using System.Diagnostics;
using EduCompass.Data;
using EduCompass.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduCompass.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;
    private readonly ApplicationDbContext _database;

    public AuthController(ILogger<AuthController> logger, ApplicationDbContext db)
    {
        _logger = logger;
        _database = db;
    }
    
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string usrnm, string pswrd)
    {
        // Search by username first and then by email.
        User? user = _database.Users.FirstOrDefault(u => (u.Username == usrnm && u.Password == pswrd) || (u.Email == usrnm && u.Password == pswrd));

        // If it doesn't exist, fail.
        if (user == null)
        {
            TempData["Error"] = "Invalid Credentials.";
            return RedirectToAction("Login");
        }

        // Otherwise redirect to dashboard.
        CreateSession(user.Username);
        return RedirectToAction("Dashboard", "Home");
    }

    // GET
    public IActionResult SignUp()
    {
        return View();
    }

    //POST
    [HttpPost]
    public IActionResult SignUp(string usrnm, string email, string name, string srname, string term, string pswrd, string pswrd2)
    {
        // test cases for failing.
        if ( (from user in _database.Users where user.Username == usrnm select user).Any() )
        {
            // fail and display error to the user.
            Debug.WriteLine($"This should fail, because {usrnm} a duplicate username.");
            TempData["Error"] = "This Username is already taken.";
            return RedirectToAction("SignUp");
        }

        if ((from user in _database.Users where user.Email == email select user).Any())
        {
            // fail and display error to the user.
            Debug.WriteLine($"This should fail, because {email} a duplicate username.");
            TempData["Error"] = "This E-Mail is already taken.";
            return RedirectToAction("SignUp");
        }

        if (pswrd != pswrd2)
        {
            // fail and display error to the user.
            Debug.WriteLine($"This should fail, because passwords don't match.");
            TempData["Error"] = "Please confirm your password correctly.";
            return RedirectToAction("SignUp");
        }

        // if none of the above cases fail, then create the user.
        var newUser = new User
        {
            Username = usrnm,
            Email = email,
            FirstName = name,
            LastName = srname,
            Semester = int.Parse(term),
            Password = pswrd
        };

        // add the user to the database.
        _database.Add(newUser);
        _database.SaveChanges();

        // and then redirect the user to home.
        CreateSession(newUser.Username);
        return RedirectToAction("Dashboard", "Home");
    }

    private void CreateSession(string username)
    {
        HttpContext.Session.SetString("username", username);
    }

    private void DestroySession()
    {
        HttpContext.Session.SetString("username", string.Empty);
    }
}