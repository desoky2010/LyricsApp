using LyricsApp.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LyricsApp.Client.Services.MusicService
{
    public class MusicServ : IMusicServ
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;

        public MusicServ(HttpClient httpClient,NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
        }

        public List<Music> Musics { get; set; } = new List<Music>();

        protected Music music = new();
        public async Task AddMusic(MusicDTO musicDTO)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Music", music);
            GoHome();
                
        }

        public async Task<ServResponse<Music>> GetMusicById(int? id)
        {
            var result = await _httpClient.GetFromJsonAsync<ServResponse<Music>>($"api/Music/{id}");
            
            return result;
        }

        public async Task GetMusics()
        {
            var result = await _httpClient.GetFromJsonAsync<ServResponse<List<Music>>>("api/Music");
            Musics = result.Data;
        }
        public void GoHome()
        {
            _navigationManager.NavigateTo("/music");
        }
    }
}
