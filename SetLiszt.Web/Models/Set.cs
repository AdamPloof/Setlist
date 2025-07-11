using System.ComponentModel.DataAnnotations;

namespace SetLiszt.Web.Models;

public class Set {
    [Key]
    public int Id { get; set; }
    public List<Song> Songs { get; set; } = [];
    public List<Gig> Gigs { get; set; } = [];
    public List<Project> Projects { get; set; } = [];
}
