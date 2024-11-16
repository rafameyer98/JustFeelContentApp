using JustFeelContentApp.Views;
using Microsoft.Maui.Controls;

namespace JustFeelContentApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ManagePlaylistsPage());
        }
    }
}
