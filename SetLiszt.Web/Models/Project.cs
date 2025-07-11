using System.ComponentModel.DataAnnotations;

namespace SetLiszt.Web.Models;

/// <summary>
/// The top level organizational unit under the user. Also, the top level
/// unit that can be shared.
/// </summary>
public class Project {
    [Key]
    public int Id { get; set; }

    [Required]
    public required string Name { get; set; }
    public List<Song> Songs { get; set; } = [];
    public List<Gig> Gigs { get; set; } = [];
    public List<Set> Sets { get; set; } = [];
}
