using ChooseDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDay.Services
{
    /// <summary>
    /// This service will handle HTTP requests to retrieve data from the cloud
    /// </summary>
    public class MyDayService
    {
        HttpClient httpClient;
        List<Day> days = new();

        public MyDayService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Day>> GetDays()
        {
            if (days?.Count > 0)
                return days;

            var url = "https://gist.githubusercontent.com/gmlunesa/e90fe9869419f02952352b764bde54da/raw/721d211fc6d91c1bbb3f67baec8de87088ab3222/chooseday.json";

            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                days = await response.Content.ReadFromJsonAsync<List<Day>>();
            }

            return days;
        }
    }
}
