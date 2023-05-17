using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using TestAPIMVC.Models;

namespace TestAPIMVC.Controllers
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
            return View();
        }
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> PrivacyAsync(double distance, double period)
        {
            string apiUrl =
                $"https://localhost:7251/WeatherForecast/" +
                $"get-average-pace?distance={distance}&period={period}";
            var httpClient = new HttpClient(); // tạo ra để callApi
            var response = await httpClient.GetAsync(apiUrl);// Lấy dữ liệu ra từ API URL
                                                             // Lấy dữ liệu Json trả về từ Api được call dạng string
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy kqua trả về từ API dạng Json
            // Đọc từ string Json vừa thu được sang double
            double pace = JsonConvert.DeserializeObject<double>(apiData);
            ViewData["result"] = "Tốc độ chạy trung bình của bạn là :"+pace;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}