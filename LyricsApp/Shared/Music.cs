using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricsApp.Shared
{
    public class Music
    {
        [Key]
        public int MusicId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Lyric { get; set; } = string.Empty;

        public string VideoUrl { get; set; } = string.Empty;

        public string ImgURL { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty; 
    }
}
