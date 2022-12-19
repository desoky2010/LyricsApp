using LyricsApp.Shared;

namespace LyricsApp.Server.Services.MusicServ
{
    public interface IMusicServ
    {
        Task<ServResponse<List<Music>>> GetMusicsAsync();
        Task<ServResponse<Music>> GetMusicByIdAsync(int id);
        public Task AddMusic(Music music);
        public Task DeleteMusic(int id);
        public Task UpdateMusic(Music music);   
    }
}
