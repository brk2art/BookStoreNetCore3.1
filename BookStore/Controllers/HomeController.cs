using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;

        public HomeController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public ViewResult Index()
        {
            var newBook = configuration.GetSection("NewBookAlert");
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var result = configuration["AppName"];
            var key1 = configuration["infoObj:key1"];
            var key3 = configuration["infoObj:key3:key3obj1"];
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
