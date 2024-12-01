using System.ComponentModel.DataAnnotations;

namespace WebApp.Models;

public class MovieModel
{
    public string? Title { get; set; }

    public string? Overview { get; set; }
    public int CompanyId { get; set; }
    
    [DataType(DataType.Date)]
    public DateOnly ReleaseDate { get; set; }
}