using System.ComponentModel.DataAnnotations;

namespace Setlist.Web.Models;

public class Gig {
    [Key]
    public int Id { get; set; }

    [Required]
    public required string Name { get; set; }
    public string? Location { get; set; }
    public DateTime? HitAt { get; set; }
    public List<Set> Sets { get; set; } = [];
}
