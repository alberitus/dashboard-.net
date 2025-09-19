using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InventorySystem.Models;
using InventorySystem.Data;
using InventorySystem.Filters;

namespace InventorySystem.Controllers;

[SessionAuthorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context; 

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
        _logger = logger;
        _context = context;
        }

        public IActionResult Index()
        {
        var totalItems = _context.InventoryItems.Count();
        var totalStock = _context.InventoryItems.Sum(i => i.Quantity);

        ViewBag.TotalItems = totalItems;
        ViewBag.TotalStock = totalStock;

        return View();
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