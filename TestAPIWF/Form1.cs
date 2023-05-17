using Newtonsoft.Json;

namespace TestAPIWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_Calculate_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ 2 textbox
            double period = Convert.ToDouble(tbt_Period.Text);
            double distance = Convert.ToDouble(tbt_Distance.Text);
            // Dựa vào dl lấy được gán vào trong URL API
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
            btn_Result.Text = pace.ToString();
        }
    }
}