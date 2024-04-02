using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using missions413.Models;

namespace missions413.Controllers;
using missions413.Models;

public class HomeController(BooksContext temp, ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;
    
    private BooksContext _context = temp;

    public IActionResult Index()
    {

        var books = _context.Books.ToList(); // Assuming _dbContext is your database context
        return View(books);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}