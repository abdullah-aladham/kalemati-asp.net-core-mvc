using Kalemati.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Kalemati.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using(MySqlConnection conn=new MySqlConnection("server=localhost;user=root;database=kalemati;port=3306;password=HelloWorld-1516!"))
            {
                MySqlCommand cmd = new MySqlCommand("show tables;",conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                    }
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
}