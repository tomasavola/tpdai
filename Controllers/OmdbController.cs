using Microsoft.AspNetCore.Mvc;
using Pizzas.API.Models;
namespace Pizzas.API.Controllers;
using Pizzas.API.Utils;
[ApiController]
[Route("api/[controller]")]

public class OMDBController : ControllerBase
{
    
    [HttpGet("movie/{imdbId}")]
    public async Task<IActionResult> GetByImdbId(string ImdbId)
    {
        string apiResponse = await HTTPHelper.GetContentAsync("http://clarin.com", null);
        return Ok(apiResponse);
    }
    [HttpGet("search")]
    public IActionResult GetByTerm([FromQuery] string term)
    {
        return Ok("el id es: " + term);
    }
    
    
    [HttpGet("movie/{omdbID}")]
    public static async Task<string> BuscarPeliculaPorID(string ImdbID)
    {
        string apiResponse = await HTTPHelper.GetContentAsync("http://www.omdbapi.com/?apikey=bb428e42=s", null);
        return Ok(apiResponse);
    }

     public static async Task<IActionResult> ObtenerPorTitulo(string ImdbTitle)
    {
        string apiResponse = await HTTPHelper.GetContentAsync("http://www.omdbapi.com/?apikey=bb428e42=s", null);
        return Ok(apiResponse);
    }
    
}
