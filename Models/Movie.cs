using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [StringLength(70, MinimumLength = 2)]
    [Required(ErrorMessage = "Required field.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Required field.")]
    [Display(Name = "Release Date")]
    [DataType(DataType.Date, ErrorMessage = "Enter valid date.")]
    public DateTime ReleaseDate { get; set; }

    [Required(ErrorMessage = "Required field.")]
    [Range(1, 100)]
    [DataType(DataType.Currency, ErrorMessage = "Enter correct number (eg. 5.5).")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }    

    [Required(ErrorMessage = "Required field.")]
    [StringLength(30)]
    public string? Genre { get; set; }

    [RegularExpression(@"^(G|PG|PG-13|R|NC-17)$", ErrorMessage = "Enter rating: G, PG, PG-13, R, NC-17.")]
    [StringLength(5)]
    [Required(ErrorMessage = "Required field.")]
    public string? Rating { get; set; }
}