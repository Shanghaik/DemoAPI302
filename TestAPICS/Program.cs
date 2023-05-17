// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System.Threading.Channels;

Console.WriteLine("Enter time to run");
double period = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter run distance");
double distance = Convert.ToDouble(Console.ReadLine());
// Dựa vào dl lấy được gán vào trong URL API
string apiUrl =
    $"https://localhost:7251/Tinhtoan/" +
    $"get-average-pace?distance={distance}&period={period}";
var httpClient = new HttpClient(); // tạo ra để callApi
var response = await httpClient.GetAsync(apiUrl);// Lấy dữ liệu ra từ API URL
                                                 // Lấy dữ liệu Json trả về từ Api được call dạng string
string apiData = await response.Content.ReadAsStringAsync();
// Lấy kqua trả về từ API dạng Json
// Đọc từ string Json vừa thu được sang double
double pace = JsonConvert.DeserializeObject<double>(apiData);
Console.WriteLine("Pace trung bình của bạn là: " + pace);
Console.ReadKey();