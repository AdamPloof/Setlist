using System.ComponentModel.DataAnnotations;

namespace Setlist.Web.Models;

public class Song {
    [Key]
    public int Id { get; set; }

    [Required]
    public required string Title { get; set; }
    public string? Artist { get; set; }
    public string? Filepath { get; set; }
}
