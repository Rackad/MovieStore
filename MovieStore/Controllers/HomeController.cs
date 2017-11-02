using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;


namespace MovieStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // dataset
            var url = "https://raw.githubusercontent.com/bantic/imdb-data-scraping/master/data/movies.json";

            // load data
            var json = new WebClient().DownloadString(url);

            // desrialize JSON to .NET Object
            dynamic obj = JsonConvert.DeserializeObject(json);

            // populate the model
            Movies movies = new Movies(obj);

            return View(movies.list.ToList());
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
