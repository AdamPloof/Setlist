using System.ComponentModel.DataAnnotations;

namespace Setlist.Web.Models;

public class Set {
    [Key]
    public int Id { get; set; }
    public List<Song> Songs { get; set; } = [];
}
