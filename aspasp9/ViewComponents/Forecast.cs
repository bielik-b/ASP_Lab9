using aspasp9.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace aspasp9.ViewComponents
{
    public class Forecast : ViewComponent
    {
        public IViewComponentResult Invoke(string city)
        {
            string json;
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric" +
                $"&appid=b122aeba1feaa5a3fc0f834a0e234434";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                json = reader.ReadToEnd();
            }
            WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
            return View(weatherData);
        }
    }
}

