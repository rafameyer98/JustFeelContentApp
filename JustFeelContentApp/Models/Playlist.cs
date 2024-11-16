using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustFeelContentApp.Models
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<string> Contents { get; set; } // Lista de IDs ou nomes de conteúdos
    }
}
