using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace AvaloniaApplication1.Classes;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

public class APIinterface
{
    private const string API_KEY = "MTFIYJCYMTUTMGQYZI0ZOWI5LTLMY2QTNZVMZJG0MDVKMTLI";
    private readonly HttpClient client;
    private const int MY_ID = 1089223;

    public APIinterface()
    {
        client = new HttpClient();
        client.BaseAddress = new Uri("https://garage61.net/");
    }
    
    
    public async Task<string> GetLapTime()
    {
        var fromDate = DateTime.Now.AddDays(-7).ToString("yyy-mm-dd");
        string requestUri = $"api/v1/findLaps?user={MY_ID}&from={fromDate}&limit=1";
        
        var response = await client.GetAsync(requestUri);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var laps = JsonSerializer.Deserialize<List<Lap>>(content, options);

        var lap = laps?.FirstOrDefault();

        return lap != null ? $"Lap time: {lap.Time}" : "No lap found in the past week.";
    }
    
    public class Lap
    {
        public string Time { get; set; }
        // Include other properties as needed
    }
}