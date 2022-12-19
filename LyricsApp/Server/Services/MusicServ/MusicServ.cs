using Blazorise;
using LyricsApp.Server.Data;
using LyricsApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace LyricsApp.Server.Services.MusicServ
{
    public class MusicServ : IMusicServ
    {
        private readonly AplicationContext _aplicationContext;

        public MusicServ(AplicationContext aplicationContext)
        {
            _aplicationContext = aplicationContext;
        }

        public async Task AddMusic(Music music)
        {
            var newmusic = new Music
            {
                Author = music.Author,
                ImgURL = music.ImgURL,
                MusicId = music.MusicId,
                Lyric = music.Lyric,
                Title = music.Title,
                VideoUrl = music.VideoUrl
            };
            await _aplicationContext.Musics.AddAsync(newmusic);
            await _aplicationContext.SaveChangesAsync();    
        }

        public async Task DeleteMusic(int id)
        {
            var music = await _aplicationContext.Musics.FirstOrDefaultAsync(m => m.MusicId == id);
            if(music is not null)
            {
                 _aplicationContext.Musics.Remove(music);
                await _aplicationContext.SaveChangesAsync();
            }
        }

        public async Task<ServResponse<Music>> GetMusicByIdAsync(int id)
        {
            var music = await _aplicationContext.Musics.FindAsync(id);
            var response = new ServResponse<Music>();
            if(music == null)
            {
                response.Success = false;
                response.Mesage = "Sorry , This music has no data :(";
            }
            else
            {
                response.Data = music;
            }
            return response;
        }

        public async Task<ServResponse<List<Music>>> GetMusicsAsync()
        {
            var musics = await _aplicationContext.Musics.ToListAsync();
            var response = new ServResponse<List<Music>>
            {
                Data = musics
            };
            return response;
        }

        public async Task UpdateMusic(Music music)
        {
            var newmusic = await _aplicationContext.Musics.FirstOrDefaultAsync(m => m.MusicId == music.MusicId);
            if(newmusic is not null)
            {
                newmusic.MusicId = music.MusicId;
            }
            _aplicationContext.Musics.Update(newmusic);
            await _aplicationContext.SaveChangesAsync();
        }
    }
}
