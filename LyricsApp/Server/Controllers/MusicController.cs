using LyricsApp.Server.Services.MusicServ;
using LyricsApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LyricsApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly IMusicServ _musicServ;

        public MusicController(IMusicServ musicServ)
        {
            _musicServ = musicServ;
        }

        [HttpGet]
        public async Task<ActionResult<ServResponse<List<Music>>>> GetAllMusics()
        {
            var response = await _musicServ.GetMusicsAsync();
            return Ok(response);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServResponse<Music>>> GetOneMusic(int id)
        {
            var response = await _musicServ.GetMusicByIdAsync(id);
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> AddMusic(MusicDTO musicDTO)
        {
            var newmusic = new Music()
            {
                Author = musicDTO.Author,
                ImgURL = musicDTO.ImgURL,
                Lyric=musicDTO.Lyric,
                Title=musicDTO.Title,
                VideoUrl=musicDTO.VideoUrl
            };
            await _musicServ.AddMusic(newmusic);
            return Ok("music added");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusic(int id)
        {
            await _musicServ.DeleteMusic(id);
            return Ok("Music Deleted");
        }
    }
}
