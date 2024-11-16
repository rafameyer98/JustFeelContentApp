using JustFeelContentApp.Models;
using JustFeelContentApp.ViewModels;
using System.Collections.ObjectModel;

namespace JustFeelContentApp.ViewModels
{
    public class PlaylistViewModel
    {
        public ObservableCollection<Playlist> Playlists { get; set; }

        public PlaylistViewModel()
        {
            Playlists = new ObservableCollection<Playlist>();
            LoadPlaylists();
        }

        // Simulação de carregamento de playlists
        private void LoadPlaylists()
        {
            Playlists.Add(new Playlist { Name = "Playlist 1" });
            Playlists.Add(new Playlist { Name = "Playlist 2" });
        }

        // Método para adicionar uma nova playlist
        public void AddPlaylist(string name)
        {
            Playlists.Add(new Playlist { Name = name });
        }
    }
}
