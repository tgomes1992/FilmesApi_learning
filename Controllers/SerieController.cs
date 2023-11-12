using FilmesApi.Data;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SerieController : Controller
    {
        private FilmesContext _context;

        [HttpPost]
        public void AdicionarSerie([FromBody] Serie Serie)
        {

            _context.Serie.Add(Serie);
            _context.SaveChanges();

        }


        [HttpGet]
        public IEnumerable<Serie> GetSeries()
        {
            return _context.Serie.ToList();

        }


    }
}
