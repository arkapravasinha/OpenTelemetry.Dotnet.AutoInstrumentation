using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace OpenTelemetry.Dotnet.AutoInstrumentation.Client.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _httpClient;

        public List<WeatherForecast> Forecasts { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClient = httpClientFactory.CreateClient("WFService");
        }

        public async Task OnGet()
        {
            var response=await _httpClient.GetAsync("/WeatherForecast");
            if (response.IsSuccessStatusCode)
                Forecasts = JsonConvert.DeserializeObject<List<WeatherForecast>>(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
        }
    }
}