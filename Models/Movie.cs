using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    public string? Title { get; set; }

    [Display(Name = "Release Date"), DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [StringLength(100)]
    public string? Genre { get; set; }

    [Column(TypeName = "decimal(18, 2)"), Range(1, 300)]
    public decimal Price { get; set; }
}
