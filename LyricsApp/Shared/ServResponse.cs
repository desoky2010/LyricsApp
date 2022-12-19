using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricsApp.Shared
{
    public class ServResponse <T>
    {
        public T Data { get; set; }

        public bool Success { get; set; } = true;

        public string Mesage { get; set; }
    }
}
