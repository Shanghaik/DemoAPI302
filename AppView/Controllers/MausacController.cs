using AppData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace AppView.Controllers
{
    public class MausacController : Controller
    {
        public MausacController()
        {
        }
        public async Task<IActionResult> ShowAllColor()
        {
            // Call API
            string apiUrl = "https://localhost:7278/api/Mausac";
            var httpClient = new HttpClient(); // tạo ra để callApi
            var response = await httpClient.GetAsync(apiUrl);// Lấy dữ liệu ra từ API URL
                                                             // Lấy dữ liệu Json trả về từ Api được call dạng string
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy kqua trả về từ API dạng Json
            // Đọc từ string Json vừa thu được sang double
            var colors = JsonConvert.DeserializeObject<List<MauSac>>(apiData);
            return View(colors);
        }
        // Cơ chế bất đồng bộ:
        /*
         * Là cơ chế rất phổ biến và quan trọng trong lập trình web được
         * sử dụng để tăng hiệu suất của các chương trình bằng cách 
         * không cho phép tài nguyên xử lý được nghỉ ngơi
         * Khi client tạo ra 1 request thì sẽ có 1 luồng chính được thực
         * thi. Luồng chính đó có thể chứa nhiều luồng phụ (con) các luồng
         * con này sẽ không chạy tuần tự mà thực hiện luân phiên cho tới
         * khi hoàn thành tất cả. Trong thời điểm đó, luồng chính sẽ bị block
         * đên thời điểm các luồng con được xử lý hoàn toàn
         * VD: Khi thực hiện luông thanh toán thì có các tác vụ sau:
         * > Tạo ra 1 hóa đơn trên db
         * > Trừ số lượng sản phẩm trong db
         * > Clear giỏ hàng
         * > Update thêm lịch sử mua hàng
         * > Trừ tiền (nếu có), tăng điểm cho khách (nếu có) ...
         * Có nhiều cách để cơ chế bất đồng bộ được thực hiện và với cơ chế
         * sử dụng thread pool thì sẽ có nhiều thread cùng hoạt động để xử
         * lý một yêu cầu. Nếu số lượng thread < số lượng request thì
         * sẽ không có thread nào trong trạng thái nghỉ mà sẽ luân phiên thực 
         * hiện các tác vụ cho đến khi tất cả thành công.
         */
    }
}
