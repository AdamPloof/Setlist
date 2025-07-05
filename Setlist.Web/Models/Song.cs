using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Setlist.Web.Models;

public class Song {
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Artist { get; set; }
    public string? ScoreFile { get; set; }
    public List<Tag> Tags { get; set; } = [];
}
