using Microsoft.EntityFrameworkCore;
using FilmesApi.Models;


namespace FilmesApi.Data
{
    public class FilmesContext: DbContext
    {
        public FilmesContext(DbContextOptions<FilmesContext> opts)
            :base(opts)
        {
            
        }


        public DbSet<Filme> Filme { get; set; }

        public DbSet<Serie> Serie { get; set; }

    }
}
