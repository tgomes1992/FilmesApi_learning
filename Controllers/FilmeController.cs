using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;
using FilmesApi.Data;

namespace FilmesApi.Controllers 

{
    

    [ApiController]
    [Route("[controller]")]
    public class FilmeController : Controller
    {

        private FilmesContext _context; 

        public FilmeController(FilmesContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void AdcionarFilme([FromBody] Filme filme)
        {

            _context.Filme.Add(filme);
            _context.SaveChanges();

        }
        

        [HttpGet]
        public IEnumerable<Filme> GetFilmes ()
        {
            
            return _context.Filme.ToList();

        }



    }
}
