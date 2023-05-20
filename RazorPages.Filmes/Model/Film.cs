using System.ComponentModel.DataAnnotations;

namespace RazorPages.Filmes.Model
{
    public class Film
    {
        public int Id { get; set; }
        public string? Tittle { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateLaunch { get; set; }
        public string? Gender { get; set; }
        public decimal Price { get; set; }


    }
}
