using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Filmes.Model
{
    public class Film
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 6)]
        [Display(Name = "Titulo")]
        public string? Tittle { get; set; }

        [Display(Name = "Data Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DateLaunch { get; set; }

        [Required(ErrorMessage = "Digite o genero do filme")]
        [StringLength(30, MinimumLength = 6)]
        [Display(Name = "Genero")]
        public string? Gender { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        [Range(0,5)]
        [Display(Name = "Pontos")]
        public int Stitches { get; set; }
    }
}
