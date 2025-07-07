using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Setlist.Web.Models;
using Setlist.Web.Data;

namespace Setlist.Web.Controllers;

[ApiController]
[Route("songs")]
public class SongController : ControllerBase {
    private readonly SetlistDbContext _dbContext;

    public SongController(SetlistDbContext dbContext) {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<Song>>> ListSongs() {
        return Ok(await _dbContext.Songs.ToListAsync());
    }
}
