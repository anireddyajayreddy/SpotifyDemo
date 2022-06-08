using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpotifyDemo.Models;

namespace SpotifyDemo.Controllers
{
    [Route("api/Song")]
    [ApiController]
    public class SongController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Song> ListOfSongs()
        {
            var songsInfo=new List<Song>();
            using (var context = new spotifyDBContext())
            {
                songsInfo = context.Songs.ToList();
            }
            return songsInfo;

        }
    }
}
