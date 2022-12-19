using LyricsApp.Shared;

namespace LyricsApp.Client.Services.MusicService
{
    public interface IMusicServ
    {
        List<Music> Musics { get; set; }

        Task GetMusics();
        Task<ServResponse<Music>> GetMusicById(int? id);
        Task AddMusic(MusicDTO musicDTO);

        
    }
}
