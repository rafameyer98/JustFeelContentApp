using JustFeelContentApp.ViewModels;
using JustFeelContentApp.Models;
using JustFeelContentApp.Views;


namespace JustFeelContentApp.Views
{
    public partial class ManagePlaylistsPage : ContentPage
    {
        private PlaylistViewModel _viewModel;

        public ManagePlaylistsPage()
        {
            InitializeComponent();
            _viewModel = (PlaylistViewModel)BindingContext;
        }

        private async void OnCreatePlaylistClicked(object sender, EventArgs e)
        {
            var playlistName = await DisplayPromptAsync("Nova Playlist", "Digite o nome da nova playlist");
            if (!string.IsNullOrEmpty(playlistName))
            {
                _viewModel.AddPlaylist(playlistName);
            }
        }
    }
}