using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MobileAppsProject2017.Models;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MobileAppsProject2017
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public ObservableCollection<Character> MarvelHeroes{ get; set; }
        public ObservableCollection<ComicBook> MarvelComics { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            MarvelHeroes = new ObservableCollection<Character>();
            MarvelComics = new ObservableCollection<ComicBook>();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {

            APIAccess.IsActive = true;
            APIAccess.Visibility = Visibility.Visible;
            await MarvelFacade.PopulateMarvelCharactersAsync(MarvelHeroes);

            APIAccess.IsActive = false;
            APIAccess.Visibility = Visibility.Collapsed;
        }

        private async void MasterView_ItemClick(object sender, ItemClickEventArgs e)
        {

            APIAccess.IsActive = true;
            APIAccess.Visibility = Visibility.Visible;

            var selectedChar = (Character)e.ClickedItem;

            CharBioName.Text = selectedChar.name;
            CharBio.Text = selectedChar.description;

            var largeImage = new BitmapImage();
            Uri uri = new Uri(selectedChar.thumbnail.large);

            largeImage.UriSource = uri;

            CharBioImage.Source = largeImage;

            MarvelComics.Clear();

            await MarvelFacade.PopulateMarvelComicsAsync(selectedChar.id, MarvelComics);

            APIAccess.IsActive = false;
            APIAccess.Visibility = Visibility.Collapsed;


        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
