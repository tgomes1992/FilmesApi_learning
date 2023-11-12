namespace FilmesApi.Models
{
    public class Filme
    {
        public Guid Id { get; set; }
        public string Titulo {  get; set; }

        public string Descricao  { get; set; }


        public int Duracao { get; set; }
    }
}
