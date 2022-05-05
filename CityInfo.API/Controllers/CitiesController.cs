using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController] // Helps to improve the development experience for web apis
    public class CitiesController : ControllerBase
    {
        public JsonResult GetCities()
        {
            new JsonResult(
                new List<object> {
                    new {id = 1, name = "New York City"},
                    new {id = 2, name = "Houston City"} 
                });
        }
    }
}
